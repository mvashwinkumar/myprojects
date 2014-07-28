using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using com.iss.inventory.Entity;
using com.iss.inventory.BusinessLogic;
using com.iss.inventory.CustomModels;

namespace Staionery_Inventory.Presentation.Search
{
    public partial class testCaller : System.Web.UI.Page
    {
        SearchController searchControl = new SearchController();
        SearchItemsModel model = new SearchItemsModel();

        protected void Page_Load(object sender, EventArgs e)
        {


            //List<string> selectedItems = new List<string>();
            ////if (Request.Cookies["grid"].Value != null)
            ////{ }
            //if (Session["Search_SelectedItemsId"] != null)
            //{
            //    selectedItems = (List<string>)Session["Search_SelectedItemsId"];
            //    if (selectedItems.Count > 0 || selectedItems == null)
            //    {
            //        List<StationeryItem> items = new List<StationeryItem>();
            //        foreach (string itemID in selectedItems)
            //        {
            //            model.getCriteriaList().Add("");
            //            model.getCriteriaList().Add(itemID);
            //            StationeryItem stIt = searchControl.getSearchByItemID(model).getStationeryItemsList()[0];
            //            items.Add(stIt);
            //        }
            //        gvListItems.DataSource = items;
            //        gvListItems.DataBind();
            //    }
            //    Session.Remove("Search_SelectedItemsId");
            //}
        }

        protected void btnAddMore_Click(object sender, EventArgs e)
        {
            List<string> temp = new List<string>();

            foreach (GridViewRow gvr in gvListItems.Rows)
            {
                temp.Add(gvr.Cells[0].Text.Trim());
            }
            //HttpCookie temp_ck = new HttpCookie();
            //temp_ck.Name = "grid";
            //temp_ck.Value = temp.ToString();
            //temp_ck.Expires.AddDays(-1);
            //Response.Cookies.Add(temp_ck);
            Response.Redirect("~/Presentation/Search/SearchItemsPage.aspx");
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedMonth = DropDownList1.SelectedValue;
            int month = Convert.ToInt32(selectedMonth);
            DateTime startDate = new DateTime(2014,month,1);
            DateTime endDate = new DateTime();
            endDate.Date.AddMonths(startDate.Month + 1);
            

        }

        protected void btnTest_Click(object sender, EventArgs e)
        {
            string selectedMonth = DropDownList1.SelectedValue;
            int month = Convert.ToInt32(selectedMonth);
            DateTime selectedDateTime = new DateTime(2014, month,1);
            DateTime startDate = new DateTime(2014, month, 1);
            DateTime endDate = new DateTime();
            var thisMonthStart = startDate.AddDays(1 - selectedDateTime.Day);
            startDate = Convert.ToDateTime(thisMonthStart);
            var thisMonthEnd = thisMonthStart.AddMonths(1).AddSeconds(-1);
            endDate = Convert.ToDateTime(thisMonthEnd);
            Label1.Text = startDate.ToString();
            Label2.Text = endDate.ToString();
        }
    }
}