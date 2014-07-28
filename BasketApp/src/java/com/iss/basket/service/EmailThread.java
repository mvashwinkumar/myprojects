package com.iss.basket.service;

import com.iss.basket.util.EmailServlet;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author yc
 */
public class EmailThread implements Runnable{

    //String sendto_name,String sendto_email,String sendto_content
    String sendto_name;
    String sendto_email;
    String sendto_content;
    String sendto_title;
   
    public EmailThread(String sendto_name, String sendto_email, String sendto_content, String sendto_title)
    {
        this.sendto_name = sendto_name;
        this.sendto_email = sendto_email;
        this.sendto_content = sendto_content;
        this.sendto_title = sendto_title;
    }
    @Override
    public void run() {
       
        EmailServlet.sendEmail_gmail(sendto_name, sendto_email, sendto_content, sendto_title);
        
    }
    
}
