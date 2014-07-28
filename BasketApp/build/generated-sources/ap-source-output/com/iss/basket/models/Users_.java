package com.iss.basket.models;

import com.iss.basket.models.Customers;
import com.iss.basket.models.UsersGroups;
import javax.annotation.Generated;
import javax.persistence.metamodel.CollectionAttribute;
import javax.persistence.metamodel.SingularAttribute;
import javax.persistence.metamodel.StaticMetamodel;

@Generated(value="EclipseLink-2.5.1.v20130918-rNA", date="2014-02-16T09:40:23")
@StaticMetamodel(Users.class)
public class Users_ { 

    public static volatile CollectionAttribute<Users, Customers> customersCollection;
    public static volatile SingularAttribute<Users, String> username;
    public static volatile SingularAttribute<Users, UsersGroups> usersGroups;
    public static volatile SingularAttribute<Users, String> role;
    public static volatile SingularAttribute<Users, String> password;

}