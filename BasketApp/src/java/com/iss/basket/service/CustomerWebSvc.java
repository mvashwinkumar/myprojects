/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.iss.basket.service;

import com.iss.basket.ajaxModels.Status;
import com.iss.basket.bizLogic.CustomerService;
import com.iss.basket.models.Customers;
import com.iss.basket.models.Inventory;
import com.iss.basket.models.Subscription;
import com.iss.basket.models.SubscriptionItem;
import java.util.ArrayList;
import java.util.List;
import javax.ejb.EJB;
import javax.json.JsonObject;
import javax.ws.rs.Consumes;
import javax.ws.rs.POST;
import javax.ws.rs.Path;
import javax.ws.rs.Produces;

/**
 *
 * @author yc
 */
@Path("/Customer")
public class CustomerWebSvc {

    @EJB
    CustomerService service;

    @Path("/register")
    @POST
    @Consumes("application/json")
    public Status registerCustomer(Customers c) {
        int result = service.registerCustomer(c);
        if (result>0) {
            
            Status s = new Status();
            s.setError(false);
            return s;
        } else {
            Status s = new Status();
            s.setError(true);
            if(result==-1)
                s.setErrorMessage("User with this username already exists");
            else
                s.setErrorMessage("User with this email already exists");
            
            return s;
        }
    }

    //get subscriptions
    @Path("/getSubscriptions")
    @POST
    @Consumes("application/json")
    @Produces("application/json")
    public List<SubscriptionItem> getSubscriptions(JsonObject request) {
        String username = request.get("username").toString();
        Subscription subscription = service.getSubscription(username);

        if (subscription != null) {
            List<SubscriptionItem> itemList = subscription.getSubscriptionItemList();
            for (SubscriptionItem item : itemList) {
                item.setSubscriptionId(null);  //prevent infinite nesting of json objects        
            }
            return itemList;
        } else {
            return new ArrayList<SubscriptionItem>();

        }

    }

    //add subscriptions
    @Path("/addSubscription")
    @POST
    @Consumes("application/json")
    @Produces("application/json")
    public Inventory addSubscription(JsonObject request) {
        String username = request.get("username").toString();
        int inventoryId = Integer.parseInt(request.get("inventoryId").toString());
        return service.addSubscription(username, inventoryId);
    }

    //remove subscriptions
    @Path("/removeSubscription")
    @POST
    @Consumes("application/json")
    @Produces("application/json")
    public Inventory removeSubscription(JsonObject request) {
        String username = request.get("username").toString();
        int inventoryId = Integer.parseInt(request.get("inventoryId").toString());
        return service.removeSubscription(username, inventoryId);
        //assume done
    }
    
    @Path("/resetPassword")
    @POST
    @Consumes("application/json")
    @Produces("application/json")
    public Status resetPassword(JsonObject request)
    {
        String email = request.get("email").toString();
        return service.resetPassword(email);
        
    }
    
    @Path("/getCustomer")
    @POST
    @Consumes("application/json")
    @Produces("application/json")
    public Customers getCustomer(JsonObject request)
    {
        String username=request.get("username").toString();
        Customers c = service.getCustomer(username);
        c.setSubscriptionCollection(null);
        c.getUsername().setCustomersCollection(null);
        c.getUsername().setUsersGroups(null);
        
        return c;
    }
    
    @Path("/editCustomer")
    @POST
    @Consumes("application/json")
    @Produces("application/json")
    public Status updateCustomer(Customers c)
    {
        return service.editCustomer(c);
    }

}
