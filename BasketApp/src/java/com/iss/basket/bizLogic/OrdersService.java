/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.iss.basket.bizLogic;

import com.iss.basket.ajaxModels.CustomerOrders;
import com.iss.basket.ajaxModels.Status;
import com.iss.basket.models.Customers;
import com.iss.basket.models.Inventory;
import com.iss.basket.models.OrderItem;
import com.iss.basket.models.Orders;
import com.iss.basket.models.Users;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import javax.ejb.EJB;
import javax.ejb.Stateless;
import javax.persistence.EntityManager;
import javax.persistence.PersistenceContext;
import javax.persistence.Query;

/**
 *
 * @author yc
 */
@Stateless
public class OrdersService {

    @EJB private ProductService prodService;
    
    @PersistenceContext
    private EntityManager em;

    public Status checkout(CustomerOrders orders) {
        //check stock just before entering 
        Status status = new Status();
        List<Inventory> itemList = orders.getOrderItems();
        boolean stockCheck = true;
        //retrieve user
        Query userQuery = em.createQuery("select u from Users u where u.username=:username");
        userQuery.setParameter("username", orders.getUsername());
        Users user = (Users) userQuery.getSingleResult();
        if (user != null) {
            for (Inventory i : itemList) {
                //check the stock
                String sql = "select i from Inventory i where i.inventoryId=:inventoryId and i.quantity>=:qty";
                Query q = em.createQuery(sql);
                q.setParameter("inventoryId", i.getInventoryId());
                q.setParameter("qty", i.getQuantity());
                List<Inventory> list = q.getResultList();
                if (list.size() <= 0) {
                    stockCheck = false;
                }

            }
            if (stockCheck) //successful
            {
                //create order
                Orders o = new Orders();
                Query q = em.createQuery("select c from Customers c where c.username=:username");         
                q.setParameter("username", user);
                List<Customers> cList = q.getResultList(); //bug prone
                Customers c = cList.get(0);
                if (c != null) {
                    o.setCustomerId(c.getCustomerId());
                    o.setCustomersCustomerId(c);
                    o.setOrderDate(new Date());
                    ArrayList<OrderItem> orderList = new ArrayList<OrderItem>();
                    for (Inventory i : itemList) {
                        OrderItem oi = new OrderItem();
                        oi.setInventoryId(new Inventory(i.getInventoryId()));
                        oi.setQuantity(i.getQuantity());
                        oi.setDiscount(Long.parseLong(i.getDiscount()));
                        oi.setOrderId(o);
//                        oi.setDiscount(Long.parseLong(i.getDiscount()));  //line added by ashwin
                    //TODO:Add discount
                        //-----------------
                        orderList.add(oi);
                    }
                    //insert into orders
                    o.setOrderItemCollection(orderList);
                    em.persist(o);
                    Query getLastQ = em.createQuery("select o from Orders o");
                    List<Orders> tempList = getLastQ.getResultList();
                    Orders lastOrder = (Orders) tempList.get(tempList.size()-1);
                    
                    String temp = lastOrder.getOrderId().toString();
                    //deduct stock
                    prodService.deductStock(itemList);
                    
                    status.setError(false);
                    status.setErrorMessage(temp); // if no error, error status stores the orderID for future reference
                }
                
            } else {
                status.setError(true);
                status.setErrorMessage("One or more product is out of stock. Please double check the available stock and try again.");
            }
            //
        }
        return status;
    }
    
    public Orders getOrderfromOrderId(String orderId){
        Integer OID = Integer.valueOf(orderId);
    Orders temp_Order = em.find(Orders.class, OID);
    return temp_Order;
    }
}
