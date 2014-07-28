/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.iss.basket.servlet;

import com.iss.basket.bizLogic.AuthenticateService;
import com.iss.basket.bizLogic.CustomerService;
import com.iss.basket.models.Customers;
import com.iss.basket.models.Users;
import com.iss.basket.util.SearchCookie;
import java.io.IOException;
import java.io.PrintWriter;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.ejb.EJB;
import javax.json.Json;
import javax.json.JsonObjectBuilder;
import javax.servlet.RequestDispatcher;
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
@WebServlet("/login")
public class LoginServlet extends HttpServlet {

    @EJB
    private AuthenticateService loginService;
    @EJB
    private CustomerService custService;

    @Override
    protected void doPost(HttpServletRequest req, HttpServletResponse resp) {

        String username = req.getParameter("username");
        String password = req.getParameter("password");
        boolean remember = Boolean.parseBoolean(req.getParameter("remember"));
        try {
            //authenticate
            req.login(username, password);
            //check if remember is true
            //if true invoke loginService.rememberUser
            if (remember) {
                String uid = loginService.rememberUser(username);
                //create new cookie with uid, replacing any existing cookies and db entries
                Cookie rememberCookie = new Cookie("remember", uid);
                resp.addCookie(rememberCookie);
            } else //else remove user from remembercheck and also remove any cookies
            {
                loginService.forgetUser(username);
                Cookie[] cookieList = req.getCookies();
                if (cookieList == null) {
                    cookieList = new Cookie[0];
                }
                Cookie c = SearchCookie.getCookie(cookieList, "remember");
                if (c != null) {
                    c.setMaxAge(0); //expires immediately
                }
            }

            Cookie newVerified = SearchCookie.getCookie(req.getCookies(), "verified");
            if (newVerified != null) {
                newVerified.setMaxAge(0);
            }
            Cookie c = new Cookie("verified", "true");
            c.setPath("/BasketApp/store");
            resp.addCookie(c);

            resp.setStatus(HttpServletResponse.SC_OK);
            Customers currCustomer = custService.getCustomer(username);
            if (c != null) {
                JsonObjectBuilder jb = Json.createObjectBuilder();
                jb.add("address", currCustomer.getAddress());
                try {
                    PrintWriter pr = resp.getWriter();
                    pr.println(jb.build().toString());
                } catch (IOException ex) {
                    Logger.getLogger(LoginServlet.class.getName()).log(Level.SEVERE, null, ex);
                }

            }

        } catch (ServletException ex) {
            if (req.getUserPrincipal() != null) {
                    
                    Customers currCustomer = custService.getCustomer(username);
                    JsonObjectBuilder jb = Json.createObjectBuilder();
                    jb.add("address", currCustomer.getAddress());
                    resp.setStatus(HttpServletResponse.SC_OK);
                    try {
                        PrintWriter pr = resp.getWriter();
                        pr.println(jb.build().toString());
                    } catch (IOException e) {
                        Logger.getLogger(LoginServlet.class.getName()).log(Level.SEVERE, null, e);
                    }               
            }
            resp.setStatus(HttpServletResponse.SC_UNAUTHORIZED);
        }
    }

    @Override
    protected void doGet(HttpServletRequest req, HttpServletResponse resp) {

        if (req.getUserPrincipal() == null) {

            //check if cookie exists
            Cookie rememberCookie = SearchCookie.getCookie(req.getCookies(), "remember");
            boolean loginResult = false;
            if (rememberCookie != null) {
                //try to perform log-in
                Users user = loginService.rememberVerify(rememberCookie.getValue());
                if (user != null) {
                    try {
                        req.login(user.getUsername(), user.getPassword());
                        loginResult = true;
                        Cookie c = new Cookie("verified", "true");
                        c.setPath("/BasketApp/store");
                        resp.addCookie(c);

                        //also check if cart exists
                        if(req.getCookies()!=null)
                        {
                            Cookie cart = SearchCookie.getCookie(req.getCookies(), "cart");
                            if(cart==null)
                            {
                                //create a new cookie
                                Customers currCustomer = (Customers)user.getCustomersCollection().toArray()[0];
                                cart = new Cookie("cart","{\"cart\":{},\"username\":\""+user.getUsername()+"\", \"address\":\""+currCustomer.getAddress()+"\"}");
                                cart.setPath("/BasketApp/store");
                                resp.addCookie(cart);
                            }
                        }
                        try {
                            resp.sendRedirect(req.getAttribute(RequestDispatcher.FORWARD_REQUEST_URI).toString().replace("", ""));
                            return;
                        } catch (IOException ex) {
                            System.out.println("Forward Fail");
                        }

                    } catch (ServletException ex) {
                        System.out.println("login fail");
                    }
                }

            }
            //not logged in            

            Cookie c = new Cookie("verified", "false");
            c.setPath("/BasketApp/store");
            resp.addCookie(c);
            RequestDispatcher rd = req.getRequestDispatcher("/login.html");
            try {
                rd.forward(req, resp);

            } catch (ServletException ex) {

            } catch (IOException ex) {

            }
        } else {
            try {
                req.logout();
            
            Cookie c = new Cookie("verified", "false");
            c.setPath("/BasketApp/store");
            resp.addCookie(c);
            RequestDispatcher rd = req.getRequestDispatcher("/login.html");
            rd.forward(req,resp);
            //shouldn't need to do anything
            }
            catch (ServletException ex) {
                Logger.getLogger(LoginServlet.class.getName()).log(Level.SEVERE, null, ex);
            }
            catch(IOException e)
            {
                //io exception
            }

        }

    }

}
