/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package com.iss.basket.service.sse;

import java.io.IOException;
import static java.lang.System.console;
import javax.enterprise.context.RequestScoped;
import org.glassfish.sse.api.ServerSentEvent;
import org.glassfish.sse.api.ServerSentEventConnection;
import org.glassfish.sse.api.ServerSentEventData;
import org.glassfish.sse.api.ServerSentEventHandler;

/**
 *
 * @author yc
 */
@ServerSentEvent("/inventory")
public class InventoryHandler extends ServerSentEventHandler{

   
    @Override
    public void onConnected(ServerSentEventConnection connection) {
        super.onConnected(connection);
        System.out.println("client connected. "+connection.toString());
       
    }

    @Override
    public void onClosed() {
        super.onClosed(); //To change body of generated methods, choose Tools | Templates.
        System.out.println("Connection Closed>>>>>>");
    }


    
    
    
    public void sendInventoryUpdate(ServerSentEventData data)
    {
        try {
          connection.sendMessage(data);
        } catch (IOException ex) {
           System.out.println("Inventory update failed.. InventoryHandler.java "+ex.getMessage());
        }
    }
}
