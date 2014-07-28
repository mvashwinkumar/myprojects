package com.iss.basket.models;

import com.iss.basket.models.OrderItem;
import com.iss.basket.models.SubscriptionItem;
import javax.annotation.Generated;
import javax.persistence.metamodel.CollectionAttribute;
import javax.persistence.metamodel.SingularAttribute;
import javax.persistence.metamodel.StaticMetamodel;

@Generated(value="EclipseLink-2.5.1.v20130918-rNA", date="2014-02-16T09:40:23")
@StaticMetamodel(Inventory.class)
public class Inventory_ { 

    public static volatile SingularAttribute<Inventory, Double> price;
    public static volatile CollectionAttribute<Inventory, OrderItem> orderItemCollection;
    public static volatile SingularAttribute<Inventory, String> description;
    public static volatile SingularAttribute<Inventory, String> name;
    public static volatile SingularAttribute<Inventory, String> imgPath;
    public static volatile SingularAttribute<Inventory, Integer> inventoryId;
    public static volatile SingularAttribute<Inventory, Integer> quantity;
    public static volatile CollectionAttribute<Inventory, SubscriptionItem> subscriptionItemCollection;
    public static volatile SingularAttribute<Inventory, String> discount;

}