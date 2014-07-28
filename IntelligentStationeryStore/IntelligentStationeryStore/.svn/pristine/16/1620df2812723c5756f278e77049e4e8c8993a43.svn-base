using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.iss.inventory.Entity;

namespace com.iss.inventory.Controllers
{
    public class ItemMaintenanceController
    {
        public ItemMaintenanceController(){ }

        public List<String> getAllItemID()
        {
            InvManagementEntities IME = new InvManagementEntities();
            var result = from item in IME.StationeryItems
                         select new { item.ItemID };
            List<String> allItemID = new List<String>();
            foreach (var s in result.ToList())
            {
                allItemID.Add(s.ItemID.ToString());
            }
            return allItemID;
        }

        public String[] getItemByID(String txtDeptID)
        {
            InvManagementEntities IME = new InvManagementEntities();
            var iID = Convert.ToInt32(txtDeptID);
            StationeryItem i = IME.StationeryItems.First<StationeryItem>(x => x.ItemID == iID);
            String[] item = { Convert.ToString(i.ItemID), i.Category, i.Description, Convert.ToString(i.QtyLeft), Convert.ToString(i.ReorderLevel), Convert.ToString(i.ReorderQty), i.UnitofMeasure, i.Location };
            return item;
        }

        public String[] getPrevItem(String txtItemID)
        {
            return getItemByID(txtItemID);
        }

        public String[] getNextItem(String txtItemID)
        {
            return getItemByID(txtItemID);
        }

        public String deleteItem(String txtItemID)
        {
            InvManagementEntities IME = new InvManagementEntities();
            var iID = Convert.ToInt32(txtItemID);
            StationeryItem i = IME.StationeryItems.First<StationeryItem>(x => x.ItemID == iID);
            if (i != null)
            {
                IME.DeleteObject(i);
                IME.SaveChanges();
            }
            return "Delete Item Successfully";
        }

        public String updateItem(String txtItemID, String btnCategory, String txtDescription, String txtQtyLeft, String txtReorderLevel, String txtReorderQty, String btnUnitofMeasure, String txtLocation)
        {
            InvManagementEntities IME = new InvManagementEntities();
            List<String> allItemID = getAllItemID();
            //duplication checking
            foreach (String s in allItemID) {
                var ID = Convert.ToInt32(s);
                StationeryItem i = IME.StationeryItems.First<StationeryItem>(x => x.ItemID == ID);
                if (i.ItemID == Convert.ToInt32(txtItemID)) { continue; }
                if (i.Location == txtLocation) return "* This location already exist, please enter a new one";
            }
            //main function
            var tempID = Convert.ToInt32(txtItemID);
            StationeryItem item= IME.StationeryItems.First<StationeryItem>(x => x.ItemID == tempID);
            item.Category = btnCategory; item.Description = txtDescription; item.QtyLeft = Convert.ToInt32(txtQtyLeft); item.ReorderLevel = Convert.ToInt32(txtReorderLevel); item.ReorderQty = Convert.ToInt32(txtReorderQty); item.UnitofMeasure = btnUnitofMeasure; item.Location = txtLocation;
            IME.SaveChanges();
            return "Update Item Successfully";
        }

        public String createItem(String btnCategory, String txtDescription, String txtQtyLeft, String txtReorderLevel, String txtReorderQty, String btnUnitofMeasure, String txtLocation)
        {
            InvManagementEntities IME = new InvManagementEntities();
            List<String> allItemID = getAllItemID();
            //duplication checking
            foreach (String s in allItemID)
            {
                var ID = Convert.ToInt32(s);
                StationeryItem i = IME.StationeryItems.First<StationeryItem>(x => x.ItemID == ID);
                if (i.Location == txtLocation) return "* This location already exist, please enter a new one";
            }
            //main function
            StationeryItem item = new StationeryItem();
            item.Category = btnCategory; item.Description = txtDescription; item.QtyLeft = Convert.ToInt32(txtQtyLeft); item.ReorderLevel = Convert.ToInt32(txtReorderLevel); item.ReorderQty = Convert.ToInt32(txtReorderQty); item.UnitofMeasure = btnUnitofMeasure; item.Location = txtLocation;
            IME.AddToStationeryItems(item);
            IME.SaveChanges();
            return "Create Item Successfully";
        }
    }
}
