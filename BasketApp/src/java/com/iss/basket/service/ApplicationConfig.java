/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package com.iss.basket.service;

import java.util.Set;
import javax.ws.rs.core.Application;

/**
 *
 * @author yc
 */
@javax.ws.rs.ApplicationPath("api")
public class ApplicationConfig extends Application {

    @Override
    public Set<Class<?>> getClasses() {
        Set<Class<?>> resources = new java.util.HashSet<>();
        addRestResourceClasses(resources);
        return resources;
    }

    /**
     * Do not modify addRestResourceClasses() method.
     * It is automatically populated with
     * all resources defined in the project.
     * If required, comment out calling this method in getClasses().
     */
    private void addRestResourceClasses(Set<Class<?>> resources) {
        resources.add(com.iss.basket.service.CurrencyService.class);
        resources.add(com.iss.basket.service.CustomerWebSvc.class);
        resources.add(com.iss.basket.service.OrderWebSvc.class);
        resources.add(com.iss.basket.service.ProductWebSvc.class);
        resources.add(com.iss.basket.service.SearchProductSvc.class);
    }
    
}
