package com.iss.basket.models;

import com.iss.basket.models.Inventory;
import com.iss.basket.models.Orders;
import javax.annotation.Generated;
import javax.persistence.metamodel.SingularAttribute;
import javax.persistence.metamodel.StaticMetamodel;

@Generated(value="EclipseLink-2.5.1.v20130918-rNA", date="2014-02-16T09:40:23")
@StaticMetamodel(OrderItem.class)
public class OrderItem_ { 

    public static volatile SingularAttribute<OrderItem, Inventory> inventoryId;
    public static volatile SingularAttribute<OrderItem, Integer> quantity;
    public static volatile SingularAttribute<OrderItem, Integer> itemId;
    public static volatile SingularAttribute<OrderItem, Orders> orderId;
    public static volatile SingularAttribute<OrderItem, Long> discount;

}