/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package com.iss.basket.util;

import java.io.UnsupportedEncodingException;
import java.util.Properties;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.mail.BodyPart;
import javax.mail.Message;
import javax.mail.MessagingException;
import javax.mail.Multipart;
import javax.mail.Session;
import javax.mail.Transport;
import javax.mail.internet.InternetAddress;
import javax.mail.internet.MimeBodyPart;
import javax.mail.internet.MimeMessage;
import javax.mail.internet.MimeMultipart;

/**
 *
 * @author AshwinKumar
 */

public class EmailServlet {
    public static boolean sendEmail_gmail(String sendto_name,String sendto_email,String sendto_content, String sendto_title) {
        boolean status = false;
        
            String host = "smtp.gmail.com";
            String userName = "hifiveiss@gmail.com";
            String userMail = "hifiveiss@gmail.com";
            String authorization = "true";
            String port = "465";
            String socketFactoryClass = "javax.net.ssl.SSLSocketFactory";
            String socketFactoryPort = "465";
            String password = "issteam5";
        
        try {
            
            Properties props_emailsession = new Properties();
            props_emailsession.put("mail.host", host);
            props_emailsession.put("mail.smtp.class", "com.sun.mail.smtp.SMTPTransport");
            props_emailsession.put("mail.store.protocol", "imap");
            props_emailsession.put("mail.smtp.port", port);
            props_emailsession.put("mail.user", userName);
            props_emailsession.put("mail.smtp.auth", authorization);
            props_emailsession.put("mail.debug", "false");
            props_emailsession.put("mail.from", userMail);
            props_emailsession.put("mail.imap.class", "com.sun.mail.imap.IMAPStore");
            props_emailsession.put("mail.transport.protocol", "smtp");
            props_emailsession.put("mail.smtp.socketFactory.class", socketFactoryClass);
            props_emailsession.put("mail.smtp.socketFactory.port", socketFactoryPort);
            
            Session toGmail = Session.getInstance(props_emailsession);
            
            MimeMessage message = new MimeMessage(toGmail);
            message.addHeader("X-Mailer", "JavaMail API");
            message.setSubject(sendto_title);
            try {
                message.setRecipient(Message.RecipientType.TO, new InternetAddress(sendto_email, sendto_name));
            } catch (UnsupportedEncodingException ex) {
                Logger.getLogger(EmailServlet.class.getName()).log(Level.SEVERE, null, ex);
            }
            Multipart body = new MimeMultipart();
//            BodyPart part = new MimeBodyPart();
            String strContent = sendto_content;
            if(!strContent.isEmpty())
//            part.setText("hello from "+strContent+"!");
//            body.addBodyPart(part);
            {
            MimeBodyPart htmlPart = new MimeBodyPart();
            htmlPart.setContent(strContent, "text/html");
            body.addBodyPart(htmlPart);
            message.setContent(body);
            
            Transport transport = toGmail.getTransport("smtp");
            transport.connect(host, userName, password);
            transport.sendMessage(message, message.getAllRecipients());
            transport.close();
            status=true;
            }
            
        } catch (MessagingException ex) {
            Logger.getLogger(EmailServlet.class.getName()).log(Level.SEVERE, null, ex);
        }
            return status;
        
    }
}
