/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package com.iss.basket.service.sse;

import java.io.IOException;
import org.glassfish.sse.api.ServerSentEvent;
import org.glassfish.sse.api.ServerSentEventConnection;
import org.glassfish.sse.api.ServerSentEventData;
import org.glassfish.sse.api.ServerSentEventHandler;

/**
 *
 * @author User
 */
@ServerSentEvent("/discount")
public class DiscountHandler extends ServerSentEventHandler{

    @Override
    public void onClosed() {
        super.onClosed(); //To change body of generated methods, choose Tools | Templates.
        System.out.println("Discount: Connection Closed>>>>>>");
    }

    @Override
    public void onConnected(ServerSentEventConnection connection) {
        super.onConnected(connection); //To change body of generated methods, choose Tools | Templates.
        System.out.println("Discount: client connected. "+connection.toString());
    }
    
    public void sendDiscountUpdate(ServerSentEventData data){
         try {
          connection.sendMessage(data);
        } catch (IOException ex) {
           System.out.println("Discount echo failed.. DiscountHandler.java"+ ex.getMessage());
        }
    }
}
