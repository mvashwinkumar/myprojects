/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.iss.basket.bizLogic;

import com.iss.basket.ajaxModels.Status;
import com.iss.basket.models.Customers;
import com.iss.basket.models.Inventory;
import com.iss.basket.models.Subscription;
import com.iss.basket.models.SubscriptionItem;
import com.iss.basket.models.Users;
import com.iss.basket.models.UsersGroups;
import com.iss.basket.service.CurrencyThread;
import com.iss.basket.service.EmailThread;
import java.util.ArrayList;
import java.util.Collection;
import java.util.List;
import javax.ejb.Stateless;
import javax.inject.Inject;
import javax.persistence.EntityManager;
import javax.persistence.PersistenceContext;
import javax.persistence.Query;

/**
 *
 * @author yc
 */
@Stateless

public class CustomerService {

    @Inject private CurrencyThread threadPool;
    
    @PersistenceContext
    EntityManager em;

    public boolean isCustomerExist(String username) {
        boolean result = false;
        String sql = "select c from Customers c where c.username.username=:username";
        Query q = em.createQuery(sql);
        q.setParameter("username", username);
        if (q.getResultList().size() > 0) {
            result = true;
        }
        return result;
    }
    
    public boolean isEmailExists(String email)
    {
        boolean result=false;
        String sql = "select c from Customers c where c.email=:email";
        Query q = em.createQuery(sql);
        q.setParameter("email",email);
        if(q.getResultList().size()>0)
            result=true;
        return result;
    }

    public int registerCustomer(Customers c) {
        int result = -1;
        String username = c.getUsername().getUsername();

        if (isCustomerExist(username)) {
            return result;
        }
        if(isEmailExists(c.getEmail()))
        {
            return -2;
        }
            
        
            //add user
            UsersGroups group = new UsersGroups();
            group.setGroupId("user");
            group.setUsername(username);
            
            c.getUsername().setUsersGroups(group);
            Users user = c.getUsername();
            ArrayList<Customers> customerList = new ArrayList();
            customerList.add(c);
            user.setCustomersCollection(customerList);
            //-----------persist-----------
            em.persist(user);
            em.persist(c);   
            em.persist(group);
            
            result = 1;
            return result;
            //-------------end persis--------
        
    }

    //get subscriptions
    public Subscription getSubscription(String username) {
        em.flush();
        em.clear();

        String query = "select u from Users u where u.username=:username";
        Query q = em.createQuery(query);
        q.setParameter("username", username);
        Users currUser = (Users) q.getSingleResult();

        if (currUser != null) {
            Customers customer = null;
            Collection<Customers> cList = currUser.getCustomersCollection();
            if (cList.size() > 0) {
                customer = (Customers) (cList.toArray()[0]);
            }
            Subscription subscription = null;
            if (customer.getSubscriptionCollection().size() > 0) {
                //there is subscription
                return (Subscription) customer.getSubscriptionCollection().toArray()[0];
            }
        }
        return null;
    }

    //add subscription
    public Inventory addSubscription(String username, int inventoryId) {
        //get inventory
      
        Inventory subscriptionInventory = em.find(Inventory.class, Integer.valueOf(inventoryId));
        
        //get the user's subscription
        String query = "select u from Users u where u.username=:username";
        Query q = em.createQuery(query);
        q.setParameter("username", username);
        Users currUser = (Users) q.getSingleResult();
        if (currUser != null) {
            Customers customer = (Customers) currUser.getCustomersCollection().toArray()[0];
            if (customer.getSubscriptionCollection().size() <= 0) {
                //if customer has no subscription
                //create new subscription
                Subscription newSubscription = new Subscription();
                newSubscription.setCustomerId(customer);
                //em.persist(newSubscription);
                SubscriptionItem newSubscriptionItem = new SubscriptionItem();
                newSubscriptionItem.setInventoryId(subscriptionInventory);
                newSubscriptionItem.setSubscriptionId(newSubscription);
                ArrayList<SubscriptionItem> subscriptionItemList = new ArrayList<SubscriptionItem>();
                subscriptionItemList.add(newSubscriptionItem);

                newSubscription.setSubscriptionItemList(subscriptionItemList);
                customer.getSubscriptionCollection().add(newSubscription);
                em.persist(newSubscription);
                

            } else {
                //subscription already exist
                Subscription currSubscription = (Subscription) customer.getSubscriptionCollection().toArray()[0];

                SubscriptionItem newSubscriptionItem = new SubscriptionItem();
                newSubscriptionItem.setInventoryId(subscriptionInventory);
                newSubscriptionItem.setSubscriptionId(currSubscription);

                //add this back to the collect 
                currSubscription.getSubscriptionItemList().add(newSubscriptionItem);
                em.persist(newSubscriptionItem);
                em.flush();

            }
        }
        return subscriptionInventory;
    }

    //remove subscription
    public Inventory removeSubscription(String username, int inventoryId) {

        Inventory subscriptionInventory = em.find(Inventory.class, inventoryId);
        //get the user's subscription
        String query = "select u from Users u where u.username=:username";
        Query q = em.createQuery(query);
        q.setParameter("username", username);
        Users currUser = (Users) q.getSingleResult();

        Customers customer = (Customers) currUser.getCustomersCollection().toArray()[0];//bug proen
        Subscription currSubscription = (Subscription) customer.getSubscriptionCollection().toArray()[0];//bug prone

        //loop through the subscription to match inventoryId
        for (SubscriptionItem item : currSubscription.getSubscriptionItemList()) {
            if (item.getInventoryId().getInventoryId().intValue() == inventoryId) {
                currSubscription.getSubscriptionItemList().remove(item);
                em.remove(item);
                em.flush();
                break;
            }
        }

        return subscriptionInventory;

    }

    public Customers getCustomer(String username) {
        Query q = em.createQuery("select u from Users u where u.username=:username");
        q.setParameter("username", username);
        Users user = ((Users) q.getSingleResult());
        Customers c = (Customers) (user.getCustomersCollection().toArray()[0]);        
        return c;

    }

    public Status resetPassword(String email) {
        //
        Query q = em.createQuery("select c from Customers c where c.email=:email");
        q.setParameter("email", email);
        List<Customers> customers = q.getResultList();
        if (customers.size() > 0) {
            Customers c = customers.get(0);
            //customer exists
            //proceed with resetting password
            String newPassword = "";
            for (int i = 0; i < 6; i++) {
                int num = (int) (Math.random() * 10);
                newPassword += String.valueOf(num);
            }
            c.getUsername().setPassword(newPassword);
            em.merge(c);

            //Todo: email the password to the user
            Status s = new Status();
            s.setError(false);
            s.setErrorMessage("");
            
            //send email
            String msg = "Your new password is "+newPassword;
            EmailThread emailThread = new EmailThread(c.getName(), c.getEmail(), msg, "Basket: Reset Password");
            threadPool.getThreadPool().execute(emailThread); //send new password through email.
                    
            return s;
        } else {
            Status s = new Status();
            s.setError(true);
            s.setErrorMessage("The email that you have entered does not exist. Please try again.");
            return s;
        }

    }
    
    public Status editCustomer(Customers c)
    {
        String username = c.getUsername().getUsername();
        Customers currCustomer = em.find(Customers.class,c.getCustomerId());
        if(currCustomer!=null)
        {
            currCustomer.setAddress(c.getAddress());
            currCustomer.setDob(c.getDob());            
            currCustomer.setName(c.getName());
            currCustomer.setGender(c.getGender());
            currCustomer.getUsername().setPassword(c.getUsername().getPassword());
            em.merge(currCustomer);
            Status s = new Status();
            s.setError(false);
            s.setErrorMessage("");
            return s;
        }
        else
        {
            Status s = new Status();
            s.setError(true);
            s.setErrorMessage("There was a problem with the updating process. Please try again later.");
            return s;
        }
        
    }

}
