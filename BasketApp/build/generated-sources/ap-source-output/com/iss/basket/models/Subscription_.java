package com.iss.basket.models;

import com.iss.basket.models.Customers;
import com.iss.basket.models.SubscriptionItem;
import javax.annotation.Generated;
import javax.persistence.metamodel.ListAttribute;
import javax.persistence.metamodel.SingularAttribute;
import javax.persistence.metamodel.StaticMetamodel;

@Generated(value="EclipseLink-2.5.1.v20130918-rNA", date="2014-02-16T09:40:23")
@StaticMetamodel(Subscription.class)
public class Subscription_ { 

    public static volatile SingularAttribute<Subscription, Customers> customerId;
    public static volatile ListAttribute<Subscription, SubscriptionItem> subscriptionItemList;
    public static volatile SingularAttribute<Subscription, Integer> subscriptionId;

}