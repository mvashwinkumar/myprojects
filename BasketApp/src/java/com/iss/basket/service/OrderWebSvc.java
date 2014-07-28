package com.iss.basket.service;

import com.iss.basket.ajaxModels.CustomerOrders;
import com.iss.basket.ajaxModels.Status;
import com.iss.basket.bizLogic.OrdersService;
import com.iss.basket.models.Inventory;
import com.iss.basket.models.OrderItem;
import com.iss.basket.models.Orders;
import com.iss.basket.service.sse.InventoryHandler;
import java.text.NumberFormat;
import java.util.ArrayList;
import java.util.Collection;
import javax.ejb.EJB;
import javax.inject.Inject;
import javax.ws.rs.Consumes;
import javax.ws.rs.POST;
import javax.ws.rs.Path;
import javax.ws.rs.Produces;
import org.glassfish.sse.api.ServerSentEventContext;
import org.glassfish.sse.api.ServerSentEventHandlerContext;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
/**
 *
 * @author yc
 */
@Path("/Orders")
public class OrderWebSvc {

    @Inject
    private CurrencyThread ThreadPool;

    @EJB
    private OrdersService service;

    @Inject
    @ServerSentEventContext("/inventory")
    ServerSentEventHandlerContext<InventoryHandler> context;

    @Inject
    private ProductWebSvc productService;

    @POST
    @Path("/checkout")
    @Consumes("application/json")
    @Produces("application/json")
    public Status checkout(CustomerOrders orders) {

        Status status = service.checkout(orders);
        ArrayList<Integer> productIdList = new ArrayList<Integer>();
        for (Inventory i : orders.getOrderItems()) {
            productIdList.add(i.getInventoryId());
        }
        productService.pushInventoryUpdate(productIdList.toArray(new Integer[productIdList.size()]));
        mailOrderInfo(status.getErrorMessage());
        return status;
    }

    public void mailOrderInfo(String productId) {
        Orders temp_order = service.getOrderfromOrderId(productId); //productId = orderId
        String html_Content = OrderToHTML_Mail(temp_order);
        String sendto_Name = temp_order.getCustomersCustomerId().getName();
        String sendto_Email = temp_order.getCustomersCustomerId().getEmail();

        //---------spawn a new thread for this-----------        
        //Boolean check = EmailServlet.sendEmail_gmail(sendto_Name,sendto_Email, html_Content);
        EmailThread emailThread = new EmailThread(sendto_Name, sendto_Email, html_Content,"Basket: Order Confirmation");
        ThreadPool.getThreadPool().submit(emailThread);
        //-------------end spawn a new thread-------------        
    }

    public String OrderToHTML_Mail(Orders order) {

        NumberFormat formatter = NumberFormat.getCurrencyInstance();
        String GreetingMsg = "<h2>Thank You for Shopping with Us!!</h2>";
        String Head = "<h2>Order Confirmation No. : " + order.getOrderId() + "</h2>";
        String ContentHead = "<h3>Customer Name :" + order.getCustomersCustomerId().getName() + "</h3>"
                + "<h3>Delivery Address :" + order.getCustomersCustomerId().getAddress() + "</h3><hr>";
        Collection<OrderItem> itemsList = order.getOrderItemCollection();

        String TableHead = "<table border=\"1\" style=\"width:400px\">"
                + "<caption>List of Items</caption>"
                + "<thead>"
                + "<tr>"
                + "<th>Item Name</th>"
                + "<th>Quantity</th>"
                + "<th>Subtotal</th>"
                + "</tr>"
                + "</thead>";

        String TableContent = "<tbody>";
        double totalAmt = 0;
        for (OrderItem item : itemsList) {
            double tempaftDiscount = 1.0;
            if (item.getDiscount() != null) {
                tempaftDiscount = ((100 - item.getDiscount()) / 100.0);
            }
            double tempQty = item.getQuantity();
            double tempPrice = item.getInventoryId().getPrice();
            double tempAmt = tempaftDiscount * tempQty * tempPrice;

            String tempAmtStr = formatter.format(tempAmt);
            TableContent += "<tr>";
            TableContent += "<td style=\"padding:2px\">" + item.getInventoryId().getName() + "</td>";
            TableContent += "<td style=\"text-align:center\">" + item.getQuantity() + "</td>";
            totalAmt += tempAmt;
            TableContent += "<td style=\"text-align:right padding:2px\">$" + tempAmtStr + "</td>";
            TableContent += "</tr>";
        }
        TableContent += "</tbody>"
                + "</table>";

        String totalAmtStr = formatter.format(totalAmt);
        
        String TotalPriceContent = "<h4>Total Price : $" + totalAmtStr + "</h4>";

        String htmlContent = GreetingMsg + Head + ContentHead + TableHead + TableContent + TotalPriceContent;
        return htmlContent;

    }

}
