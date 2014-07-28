/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.iss.basket.bizLogic;

import com.iss.basket.ajaxModels.ProductList;
import com.iss.basket.models.Inventory;
import java.util.ArrayList;
import java.util.List;
import javax.ejb.Stateless;
import javax.persistence.EntityManager;
import javax.persistence.PersistenceContext;
import javax.persistence.Query;

/**
 *
 * @author yc
 */
@Stateless
public class ProductService {

    @PersistenceContext
    EntityManager em;

    public ProductList getProducts(int currentPage, int resultsPerPage) {
        ProductList pList = new ProductList();
        String sql = "select i from Inventory i";
        Query q = em.createQuery(sql);
        q.setFirstResult((resultsPerPage * (currentPage - 1)));
        q.setMaxResults(resultsPerPage);
        pList.setProducts(q.getResultList());

        String sqlCount = "select count(i) from Inventory i";
        q = em.createQuery(sqlCount);
        pList.setMaxResults(Integer.parseInt(q.getSingleResult().toString()));
        return pList;
    }

    public ProductList filterProducts(int currentPage, int resultsPerPage, String keyword) 
    {
        ProductList pList = new ProductList();
        String sql = "select i from Inventory i where i.name like :keyword";
        Query q = em.createQuery(sql);
        q.setParameter("keyword", "%"+keyword+"%");
        q.setFirstResult((resultsPerPage * (currentPage - 1)));
        q.setMaxResults(resultsPerPage);
        pList.setProducts(q.getResultList());

        String sqlCount = "select count(i) from Inventory i where i.name like :keyword";
        q = em.createQuery(sqlCount);
        q.setParameter("keyword", "%"+keyword+"%");
        pList.setMaxResults(Integer.parseInt(q.getSingleResult().toString()));
        return pList;
    }

    public Inventory getProductDetail(int productId) {
        Inventory i = em.find(Inventory.class, productId); //return one product
        return i;
    }

    public List<Inventory> getProductStock(List<Inventory> productList) {
        ArrayList<String> productIdList = new ArrayList();
        for (Inventory i : productList) {
            productIdList.add(i.getInventoryId().toString());
        }
        String sql = "select i from Inventory i where i.inventoryId IN :myList";
        Query q = em.createQuery(sql);
        q.setParameter("myList", productIdList);
        return q.getResultList();
    }

    //deduct stock
    public void deductStock(List<Inventory> inventories) {
        for (Inventory item : inventories) {

            Inventory existingItem = em.find(Inventory.class, item.getInventoryId());
            if (existingItem != null) {
                existingItem.setQuantity(existingItem.getQuantity() - item.getQuantity());
                em.merge(existingItem);
            } else {
                System.out.println("existingItem is null : ProductService.java/deductStock");
            }
        }
        //done
    }

    public Inventory updateDiscount(int productId, String discount) {
        Inventory i = em.find(Inventory.class, productId);
        i.setDiscount(discount);
        em.merge(i);
        return em.find(Inventory.class, i.getInventoryId());
    }

    public List<Inventory> filterResult(String key) {
        Query q = em.createQuery("select i from Inventory i where i.name like :key");
        q.setParameter("key", "%" + key + "%");
        return q.getResultList();
    }

}
