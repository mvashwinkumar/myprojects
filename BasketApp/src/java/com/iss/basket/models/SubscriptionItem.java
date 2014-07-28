/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package com.iss.basket.models;

import java.io.Serializable;
import javax.persistence.Basic;
import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.FetchType;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.JoinColumn;
import javax.persistence.ManyToOne;
import javax.persistence.NamedQueries;
import javax.persistence.NamedQuery;
import javax.persistence.Table;
import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlRootElement;

/**
 *
 * @author yc
 */
@Entity
@Table(name = "subscription_item")
@XmlRootElement
@XmlAccessorType(XmlAccessType.FIELD)
@NamedQueries({
    @NamedQuery(name = "SubscriptionItem.findAll", query = "SELECT s FROM SubscriptionItem s"),
    @NamedQuery(name = "SubscriptionItem.findBySubscriptionItemId", query = "SELECT s FROM SubscriptionItem s WHERE s.subscriptionItemId = :subscriptionItemId")})
public class SubscriptionItem implements Serializable {
    private static final long serialVersionUID = 1L;
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Basic(optional = false)
    @Column(name = "subscription_item_id")
    private Integer subscriptionItemId;
    @JoinColumn(name = "subscription_id", referencedColumnName = "subscription_id")
    @ManyToOne
    private Subscription subscriptionId;
    @JoinColumn(name = "inventory_id", referencedColumnName = "inventory_id")
    @ManyToOne(fetch=FetchType.EAGER)
    private Inventory inventoryId;

    public SubscriptionItem() {
    }

    public SubscriptionItem(Integer subscriptionItemId) {
        this.subscriptionItemId = subscriptionItemId;
    }

    public Integer getSubscriptionItemId() {
        return subscriptionItemId;
    }

    public void setSubscriptionItemId(Integer subscriptionItemId) {
        this.subscriptionItemId = subscriptionItemId;
    }

    public Subscription getSubscriptionId() {
        return subscriptionId;
    }

    public void setSubscriptionId(Subscription subscriptionId) {
        this.subscriptionId = subscriptionId;
    }

    public Inventory getInventoryId() {
        return inventoryId;
    }

    public void setInventoryId(Inventory inventoryId) {
        this.inventoryId = inventoryId;
    }

    @Override
    public int hashCode() {
        int hash = 0;
        hash += (subscriptionItemId != null ? subscriptionItemId.hashCode() : 0);
        return hash;
    }

    @Override
    public boolean equals(Object object) {
        // TODO: Warning - this method won't work in the case the id fields are not set
        if (!(object instanceof SubscriptionItem)) {
            return false;
        }
        SubscriptionItem other = (SubscriptionItem) object;
        if ((this.subscriptionItemId == null && other.subscriptionItemId != null) || (this.subscriptionItemId != null && !this.subscriptionItemId.equals(other.subscriptionItemId))) {
            return false;
        }
        return true;
    }

    @Override
    public String toString() {
        return "com.iss.basket.models.SubscriptionItem[ subscriptionItemId=" + subscriptionItemId + " ]";
    }
    
}
