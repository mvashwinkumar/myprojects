﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using com.iss.inventory.Entity;
using com.iss.inventory.BusinessLogic;
using com.iss.inventory.CustomModels;
using com.iss.inventory.Controllers;

namespace Staionery_Inventory.Presentation.StockCard
{
    public partial class StockCard : System.Web.UI.Page
    {
        StockCardController stockCardControl = new StockCardController();
        StockCardModel model = new StockCardModel();
        InvManagementEntities em = new InvManagementEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            int itemID;
            List<StationeryItem> items = new List<StationeryItem>();
            if(!IsPostBack)
            if (Session["Search_allselecteddata"] != null)
            {
                items = Session["Search_allselecteddata"] as List<StationeryItem>;
                itemID = items[0].ItemID;
                model = stockCardControl.getStockCardbyItemId(itemID.ToString());
                List<StockCardDetailsModel> details = model.getStockCardDetails();

                txtSearchItemId.Text = model.getItem().ItemID.ToString();
                lblItemDescriptionValue.Text = model.getItem().Description;
                SupplierPriceList supplierPriceList = em.SupplierPriceLists.Where(x => x.ItemID == itemID && x.SupplierCategory == 1).FirstOrDefault();
                lblItemSupplierValue.Text = supplierPriceList.Supplier.Name;
                lblItemUnitOfMeasureValue.Text = model.getItem().UnitofMeasure;

                gvItemStockDetails.DataSource = details;
                gvItemStockDetails.DataBind();
                
            }
        }

        protected void btnSearchItemId_Click(object sender, EventArgs e)
        {
            if (txtSearchItemId.Text.Trim() != null)
            {
                StockCardModel model = new StockCardModel();

                model = stockCardControl.getStockCardbyItemId(txtSearchItemId.Text.Trim());

                List<StockCardDetailsModel> details = model.getStockCardDetails();

                txtSearchItemId.Text = model.getItem().ItemID.ToString();
                int temp_itemID = model.getItem().ItemID;
                lblItemDescriptionValue.Text = model.getItem().Description;
                SupplierPriceList supplierPriceList = em.SupplierPriceLists.Where(x => x.ItemID == temp_itemID && x.SupplierCategory == 1).FirstOrDefault();
                lblItemSupplierValue.Text = supplierPriceList.Supplier.Name;
                lblItemUnitOfMeasureValue.Text = model.getItem().UnitofMeasure;

                gvItemStockDetails.DataSource = details;
                gvItemStockDetails.DataBind();
            }
        }

        protected void btnToSearchPage_Click(object sender, EventArgs e)
        {
            SearchItemsModel model = new SearchItemsModel();
            model.SingleSelectMode = true;
            Session["searchitemsmodel"] = model;
            Response.Redirect("~/Presentation/Search/SearchItemsPage.aspx");
        }
    }
}