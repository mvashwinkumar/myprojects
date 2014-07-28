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
import javax.persistence.Id;
import javax.persistence.NamedQueries;
import javax.persistence.NamedQuery;
import javax.persistence.Table;
import javax.validation.constraints.NotNull;
import javax.validation.constraints.Size;
import javax.xml.bind.annotation.XmlRootElement;

/**
 *
 * @author yc
 */
@Entity
@Table(name = "remember_check")
@XmlRootElement
@NamedQueries({
    @NamedQuery(name = "RememberCheck.findAll", query = "SELECT r FROM RememberCheck r"),
    @NamedQuery(name = "RememberCheck.findByUuid", query = "SELECT r FROM RememberCheck r WHERE r.uuid = :uuid"),
    @NamedQuery(name = "RememberCheck.findByUsername", query = "SELECT r FROM RememberCheck r WHERE r.username = :username")})
public class RememberCheck implements Serializable {
    private static final long serialVersionUID = 1L;
    @Id
    @Basic(optional = false)
    @NotNull
    @Size(min = 1, max = 50)
    @Column(name = "uuid")
    private String uuid;
    @Size(max = 100)
    @Column(name = "username")
    private String username;

    public RememberCheck() {
    }

    public RememberCheck(String uuid) {
        this.uuid = uuid;
    }

    public String getUuid() {
        return uuid;
    }

    public void setUuid(String uuid) {
        this.uuid = uuid;
    }

    public String getUsername() {
        return username;
    }

    public void setUsername(String username) {
        this.username = username;
    }

    @Override
    public int hashCode() {
        int hash = 0;
        hash += (uuid != null ? uuid.hashCode() : 0);
        return hash;
    }

    @Override
    public boolean equals(Object object) {
        // TODO: Warning - this method won't work in the case the id fields are not set
        if (!(object instanceof RememberCheck)) {
            return false;
        }
        RememberCheck other = (RememberCheck) object;
        if ((this.uuid == null && other.uuid != null) || (this.uuid != null && !this.uuid.equals(other.uuid))) {
            return false;
        }
        return true;
    }

    @Override
    public String toString() {
        return "com.iss.basket.models.RememberCheck[ uuid=" + uuid + " ]";
    }
    
}
