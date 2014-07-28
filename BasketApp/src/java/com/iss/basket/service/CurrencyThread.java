/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package com.iss.basket.service;

import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;
import javax.enterprise.context.ApplicationScoped;

/**
 *
 * @author yc
 */
@ApplicationScoped
public class CurrencyThread {
    ExecutorService threadPool;
    public CurrencyThread()
    {
        threadPool = Executors.newCachedThreadPool();        
    }
    public ExecutorService getThreadPool()
    {
        return threadPool;
    }
}
