/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package com.iss.basket.util;

import javax.servlet.http.Cookie;


public class SearchCookie {
    
   
    public static Cookie getCookie(Cookie[] cList, String key)
    {
        
        for(Cookie c:cList)
        {
            //get the cookies
            if(c.getName().equals(key))
            {
                return c;
            }
        }
        return null;
    }
}
