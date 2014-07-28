/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package com.iss.basket.bizLogic;

import com.iss.basket.models.RememberCheck;
import com.iss.basket.models.Users;
import java.util.List;
import java.util.UUID;
import javax.ejb.Stateless;
import javax.persistence.EntityManager;
import javax.persistence.PersistenceContext;
import javax.persistence.Query;

/**
 *
 * @author yc
 */
@Stateless
public class AuthenticateService {
    
    @PersistenceContext
    private EntityManager em;
    
    public String rememberUser(String username)
    {
        //remember me table
        //check if username exists in remember me table
        String sql = "select r from RememberCheck r where r.username=:username";
        Query q = em.createQuery(sql);
        q.setParameter("username", username);
        List<RememberCheck> rememberList = q.getResultList();
        for(RememberCheck r:rememberList)
        {
            em.remove(r); //remove all current entries
        }
        String uid  = UUID.randomUUID().toString();
        RememberCheck r = new RememberCheck();
        r.setUuid(uid);
        r.setUsername(username);
        em.persist(r); //add to database
        
        //save cookie
        return uid;
        
    }
    
    //get user from remember table if it exists
    public Users rememberVerify(String uid)
    {
        //retrieve uid from database
        RememberCheck r = em.find(RememberCheck.class, uid);
        Users user = em.find(Users.class, r.getUsername());
        return user;
    }
    
    public void forgetUser(String username)
    {
        String sql = "select r from RememberCheck r where r.username=:username";
        Query q = em.createQuery(sql);
        q.setParameter("username", username);        
        List<RememberCheck> rememberList = q.getResultList();
        for(RememberCheck r:rememberList)
        {
            em.remove(r);
        }        
    }
}
