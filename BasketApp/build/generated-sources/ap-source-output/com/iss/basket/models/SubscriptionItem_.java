package com.iss.basket.models;

import com.iss.basket.models.Inventory;
import com.iss.basket.models.Subscription;
import javax.annotation.Generated;
import javax.persistence.metamodel.SingularAttribute;
import javax.persistence.metamodel.StaticMetamodel;

@Generated(value="EclipseLink-2.5.1.v20130918-rNA", date="2014-02-16T09:40:23")
@StaticMetamodel(SubscriptionItem.class)
public class SubscriptionItem_ { 

    public static volatile SingularAttribute<SubscriptionItem, Integer> subscriptionItemId;
    public static volatile SingularAttribute<SubscriptionItem, Inventory> inventoryId;
    public static volatile SingularAttribute<SubscriptionItem, Subscription> subscriptionId;

}