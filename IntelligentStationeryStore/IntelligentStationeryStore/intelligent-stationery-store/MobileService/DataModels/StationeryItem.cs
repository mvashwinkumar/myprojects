using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.ServiceModel.Configuration;
using MobileService;
using com.iss.inventory;
using com.iss.inventory.Entity;
using com.iss.inventory.CustomModels;


namespace MobileService

    
{

    [DataContract] 
    public class StationeryItemMobile
   
{
    int itemID;
    string category;
    string description;
    int qtyLeft;
    int reorderLevel;
    int reorderQty;
    string unitOfMeasure;
    string location;


    public static StationeryItemMobile Make(int itemID, string category, string description, int qtyLeft, int reorderLevel, int reorderQty, string unitOfMeasure, string location)
    {
        StationeryItemMobile i = new StationeryItemMobile();
        i.itemID = itemID;
        i.category = category;
        i.description = description;
        i.qtyLeft = qtyLeft;
        i.reorderLevel = reorderLevel;
        i.reorderQty = reorderQty;
        i.unitOfMeasure = unitOfMeasure;
        i.location = location;
        return i;
    }

    [DataMember]
    public int ItemID
    {
        get { return itemID; }
        set { itemID = value; }
    }

    [DataMember]
    public string Category
    {
        get { return category; }
        set { category = value; }
    }

    [DataMember]
    public string Description
    {
        get { return description; }
        set { description = value; }
    }

    [DataMember]
    public int QtyLeft
    {
        get { return qtyLeft; }
        set { qtyLeft = value; }
    }

    [DataMember]
    public int ReorderLevel
    {
        get { return reorderLevel; }
        set { reorderLevel = value; }
    }

    [DataMember]
    public int ReorderQty
    {
        get { return reorderQty; }
        set { reorderQty = value; }
    }

    [DataMember]
    public string UnitOfMeasure
    {
        get { return unitOfMeasure; }
        set { unitOfMeasure = value; }
    }

    [DataMember]
    public string Location
    {
        get { return location; }
        set { location = value; }
    }

    public static StationeryItemMobile convert(StationeryItem item)
    {
        StationeryItemMobile i = new StationeryItemMobile();
        i.itemID = item.ItemID;
        i.category = item.Category;
        i.description = item.Description;
        i.qtyLeft = Convert.ToInt32(item.QtyLeft);
        i.reorderLevel = Convert.ToInt32(item.ReorderLevel);
        i.reorderQty = Convert.ToInt32(item.ReorderQty);
        i.unitOfMeasure = item.UnitofMeasure;
        i.location = item.Location;
        return i;
    }

    public static List<StationeryItemMobile> convertList(List<StationeryItem> itemList)
    {
        List<StationeryItemMobile> itemListMobile = new List<StationeryItemMobile>();
        foreach (StationeryItem l_item in itemList)
        {
            itemListMobile.Add(convert(l_item));
        }
        return itemListMobile;
    }
}
}