/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package com.iss.basket.service;

import com.iss.basket.bizLogic.ProductService;
import com.iss.basket.models.Inventory;
import java.math.BigDecimal;
import java.util.List;
import javax.ejb.EJB;
import javax.enterprise.context.RequestScoped;
import javax.json.Json;
import javax.json.JsonArray;
import javax.json.JsonArrayBuilder;
import javax.json.JsonObject;
import javax.json.JsonObjectBuilder;
import javax.ws.rs.GET;
import javax.ws.rs.Path;
import javax.ws.rs.Produces;
import javax.ws.rs.QueryParam;
import javax.ws.rs.core.MediaType;
import javax.ws.rs.core.Response;

/**
 *
 * @author User
 */
@RequestScoped
@Path("/searchProducts")
public class SearchProductSvc {
    
    @EJB
    private ProductService service;
    
    @GET
    @Produces(MediaType.APPLICATION_JSON)
    public JsonObject get(@QueryParam("query") String query)  {
        JsonArrayBuilder arrBuilder = Json.createArrayBuilder();
    //    List<Inventory> productsList = service.getProductSearch(query);
        JsonObjectBuilder objBuilder = Json.createObjectBuilder();
      //  objBuilder.add("productId",productsList.get(0).getInventoryId()).add("productName", productsList.get(0).getName()).add("imagePath", productsList.get(0).getImgPath());
        return objBuilder.build();
//        for(Inventory i : productsList) {
//            JsonObjectBuilder objBuilder = Json.createObjectBuilder();
//            objBuilder.add("productId",i.getInventoryId()).add("productName", i.getName()).add("imagePath", i.getImgPath());
//            arrBuilder.add(objBuilder);
        }
        
    }

