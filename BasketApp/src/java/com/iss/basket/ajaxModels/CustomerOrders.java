/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package com.iss.basket.ajaxModels;

import com.iss.basket.models.Inventory;
import java.util.List;
import javax.xml.bind.annotation.XmlRootElement;

/**
 *
 * @author yc
 */
@XmlRootElement
public class CustomerOrders {
    
    //{ orderItems:[{inventoryId:xx..}], username:xxx}
    private String username;
    private String address;
    private List<Inventory> orderItems;

    /**
     * @return the username
     */
    public String getUsername() {
        return username;
    }

    /**
     * @param username the username to set
     */
    public void setUsername(String username) {
        this.username = username;
    }

    /**
     * @return the orderItems
     */
    public List<Inventory> getOrderItems() {
        return orderItems;
    }

    /**
     * @param orderItems the orderItems to set
     */
    public void setOrderItems(List<Inventory> orderItems) {
        this.orderItems = orderItems;   
    }

    /**
     * @return the address
     */
    public String getAddress() {
        return address;
    }

    /**
     * @param address the address to set
     */
    public void setAddress(String address) {
        this.address = address;
    }
    
}
