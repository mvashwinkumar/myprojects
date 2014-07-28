package com.iss.basket.models;

import com.iss.basket.models.Subscription;
import com.iss.basket.models.Users;
import java.util.Date;
import javax.annotation.Generated;
import javax.persistence.metamodel.CollectionAttribute;
import javax.persistence.metamodel.SingularAttribute;
import javax.persistence.metamodel.StaticMetamodel;

@Generated(value="EclipseLink-2.5.1.v20130918-rNA", date="2014-02-16T09:40:23")
@StaticMetamodel(Customers.class)
public class Customers_ { 

    public static volatile SingularAttribute<Customers, Users> username;
    public static volatile SingularAttribute<Customers, Integer> customerId;
    public static volatile SingularAttribute<Customers, String> email;
    public static volatile SingularAttribute<Customers, String> address;
    public static volatile SingularAttribute<Customers, String> name;
    public static volatile SingularAttribute<Customers, Date> dob;
    public static volatile SingularAttribute<Customers, String> gender;
    public static volatile CollectionAttribute<Customers, Subscription> subscriptionCollection;

}