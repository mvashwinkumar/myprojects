/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.iss.basket.service;

import com.iss.basket.ajaxModels.ProductList;
import com.iss.basket.bizLogic.ProductService;
import com.iss.basket.models.Inventory;
import com.iss.basket.service.sse.DiscountHandler;
import com.iss.basket.service.sse.InventoryHandler;
import java.util.List;
import javax.ejb.EJB;
import javax.inject.Inject;
import javax.json.Json;
import javax.json.JsonObject;
import javax.json.JsonObjectBuilder;
import javax.ws.rs.Consumes;
import javax.ws.rs.GET;
import javax.ws.rs.POST;
import javax.ws.rs.Path;
import javax.ws.rs.PathParam;
import javax.ws.rs.Produces;
import org.glassfish.sse.api.ServerSentEventContext;
import org.glassfish.sse.api.ServerSentEventData;
import org.glassfish.sse.api.ServerSentEventHandlerContext;

/**
 *
 * @author yc
 */
@Path("/Products")
public class ProductWebSvc {

    @EJB
    private ProductService service;

    @Inject
    @ServerSentEventContext("/inventory")
    ServerSentEventHandlerContext<InventoryHandler> context;

    @Inject
    @ServerSentEventContext("/discount")
    ServerSentEventHandlerContext<DiscountHandler> discountContext;

    @POST
    @Path("/get")
    @Produces("application/json")
    @Consumes("application/json")
    public ProductList getProducts(JsonObject request) {
        int currentPage = Integer.parseInt(request.get("currentPage").toString());
        int resultsPerPage = Integer.parseInt(request.get("resultsPerPage").toString());

        return service.getProducts(currentPage, resultsPerPage);

    }

    @POST
    @Path("/filterProducts")
    @Produces("application/json")
    @Consumes("application/json")
    public ProductList filterProducts(JsonObject request) {
        int currentPage = Integer.parseInt(request.get("currentPage").toString());
        int resultsPerPage = Integer.parseInt(request.get("resultsPerPage").toString());
        String keyword = request.get("keyword").toString();

        return service.filterProducts(currentPage, resultsPerPage, keyword);
    }
    

    @POST
    @Path("/details")
    @Produces("application/json")
    @Consumes("application/json")
    public Inventory getProductDetails(JsonObject request) {
        if (request.get("productId") != null) {
            int productId = Integer.parseInt(request.get("productId").toString());
            return service.getProductDetail(productId);
        } else {
            return new Inventory();
        }
    }

    @POST
    @Path("/getStock")
    @Consumes("application/json")
    @Produces("application/json")
    public List<Inventory> getStock(List<Inventory> productList) {
        return service.getProductStock(productList);

    }

    @POST
    @Path("/pushInventory")
    public void pushInventoryUpdate(Integer[] productIds) {
        for (int i = 0; i < productIds.length; i++) {

            //get latest stock
            Inventory item = service.getProductDetail(productIds[i].intValue());
            if (item != null) {
                JsonObjectBuilder response = Json.createObjectBuilder();
                String inventoryId = item.getInventoryId().toString();
                String quantity = String.valueOf(item.getQuantity());
                response.add("productId", inventoryId).add("qty", quantity);
                ServerSentEventData data = new ServerSentEventData();
                data.event(inventoryId); //set event
                data.data(response.build().toString());

                //send to each connection
                for (InventoryHandler h : context.getHandlers()) {
                    h.sendInventoryUpdate(data);
                }
            }
        }
    }

    @POST
    @Path("/updateDiscount")
    @Produces("application/json")
    @Consumes("application/json")
    public Inventory updateProductDiscount(JsonObject requestUpdate) {
        if (requestUpdate.get("inventoryId") != null) {
            int productId = Integer.parseInt(requestUpdate.get("inventoryId").toString());
            String discount = requestUpdate.get("productDiscount").toString();
            Inventory inv = service.updateDiscount(productId, discount);
            JsonObjectBuilder response = Json.createObjectBuilder();
            response.add("productId", inv.getInventoryId()).add("discount", inv.getDiscount());
            ServerSentEventData data = new ServerSentEventData();
//        data.event("1"); //set event
            data.data(response.build().toString());

            //send to each connection
            for (DiscountHandler d : discountContext.getHandlers()) {
                d.sendDiscountUpdate(data);
            }
            return inv;
        } else {
            return new Inventory();
        }
    }

    @GET
    @Path("/filterProducts/{key}")
    @Consumes("application/json")
    @Produces("application/json")
    public List<Inventory> filterProduct(@PathParam("key") String productFilter) {
        return service.filterResult(productFilter);
    }

}
