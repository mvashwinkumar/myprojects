/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package com.iss.basket.servlet;

import com.iss.basket.util.SearchCookie;
import java.io.IOException;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.Cookie;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

/**
 *
 * @author yc
 */
@WebServlet("/logout")
public class LogoutServlet extends HttpServlet{

    @Override
    protected void doGet(HttpServletRequest req, HttpServletResponse resp){
        try {
            req.logout();
            Cookie c = new Cookie("verified","false");
            c.setPath("/BasketApp/store");
            resp.addCookie(c);
            Cookie subscription = SearchCookie.getCookie(req.getCookies(),"subscription");            
            Cookie remember  = SearchCookie.getCookie(req.getCookies(), "remember");
            
            if(remember!=null)
            {
                remember.setMaxAge(0);
                remember.setValue(null);
                resp.addCookie(remember);
            }
            if(subscription!=null)
            {
                subscription.setMaxAge(0);
                subscription.setValue(null);
                resp.addCookie(subscription);           
            }
            try {
                resp.sendRedirect("/BasketApp/store");
            } catch (IOException ex) {
                Logger.getLogger(LogoutServlet.class.getName()).log(Level.SEVERE, null, ex);
            }
            
        } catch (ServletException ex) {
            Logger.getLogger(LogoutServlet.class.getName()).log(Level.SEVERE, null, ex);
        }
        
    }
    
}
