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
public class ProductList {
    
    private int maxResults;
    private List<Inventory> products;
    

    /**
     * @return the maxResults
     */
    public int getMaxResults() {
        return maxResults;
    }

    /**
     * @param maxResults the maxResults to set
     */
    public void setMaxResults(int maxResults) {
        this.maxResults = maxResults;
    }

    /**
     * @return the products
     */
    public List<Inventory> getProducts() {
        return products;
    }

    /**
     * @param products the products to set
     */
    public void setProducts(List<Inventory> products) {
        this.products = products;
    }
    
    
}
