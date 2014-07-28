﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.iss.inventory.Entity;
using com.iss.inventory.CustomModels;

namespace com.iss.inventory.BusinessLogic
{
    public class SearchController
    {
        SearchItemsModel searchItems;
        InvManagementEntities em = new InvManagementEntities();

        public SearchItemsModel getSearchBySupplierID(SearchItemsModel searchItemsCriteria)
        {
            int supplierId = Convert.ToInt32(searchItemsCriteria.getCriteriaList()[0]);
            var staItemsList = from s in em.SupplierPriceLists
                          where s.SupplierID == supplierId && s.SupplierCategory == 1  //1 - primary supplier
                          select s.StationeryItem; 
            List<StationeryItem> itemsList = staItemsList.ToList<StationeryItem>();
            searchItemsCriteria.setStationeryItemsList(itemsList);
            return searchItemsCriteria;
        }

        public SearchItemsModel getSearchByItemID(SearchItemsModel searchItemsCriteria)
        {
            int itemId = Convert.ToInt32(searchItemsCriteria.getCriteriaList()[1]);
            var staItemsList = from s in em.StationeryItems
                               where s.ItemID ==  itemId
                               select s;
            List<StationeryItem> itemsList = staItemsList.ToList<StationeryItem>();
            searchItemsCriteria.setStationeryItemsList(itemsList);
            return searchItemsCriteria;
        }

        public SearchItemsModel getSearchByItemCategory(SearchItemsModel searchItemsCriteria)
        {
            string itemCategory = searchItemsCriteria.getCriteriaList()[6];
            var staItemsList = from s in em.StationeryItems
                               where s.Category.ToLower().Contains(itemCategory.ToLower())
                               select s;
            List<StationeryItem> itemsList = staItemsList.ToList<StationeryItem>();
            searchItemsCriteria.setStationeryItemsList(itemsList);
            return searchItemsCriteria;
        }

        public SearchItemsModel getSearchByItemName(SearchItemsModel searchItemsCriteria)
        {
            string itemName = searchItemsCriteria.getCriteriaList()[2];
            
            var staItemsList = from s in em.StationeryItems
                               where s.Description.Contains(itemName)
                               select s;
            List<StationeryItem> itemsList = staItemsList.ToList<StationeryItem>();
            searchItemsCriteria.setStationeryItemsList(itemsList);
            return searchItemsCriteria;
        }

        public SearchItemsModel getAllItemDetails(SearchItemsModel searchItemsAll)
        {
            var staItemsList = from s in em.StationeryItems
                               select s;
            List<StationeryItem> itemsList = staItemsList.ToList<StationeryItem>();
            searchItemsAll.setStationeryItemsList(itemsList);
            return searchItemsAll;
        }

        public SearchItemsModel getSearchByItemBinNumber(SearchItemsModel searchItemsCriteria)
        {
            string itemLocation =searchItemsCriteria.getCriteriaList()[5];
            var staItemsList = from s in em.StationeryItems
                               where s.Location == itemLocation
                               select s;
            List<StationeryItem> itemsList = staItemsList.ToList<StationeryItem>();
            searchItemsCriteria.setStationeryItemsList(itemsList);
            return searchItemsCriteria;
        }
    }
}
