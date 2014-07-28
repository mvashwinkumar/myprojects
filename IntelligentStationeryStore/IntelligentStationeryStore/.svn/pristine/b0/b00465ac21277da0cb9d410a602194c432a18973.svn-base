using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using com.iss.inventory.BusinessLogic;
using com.iss.inventory.CustomModels;
using com.iss.inventory.Entity;

namespace Staionery_Inventory.Presentation.Search
{
    public partial class SearchItemsPage : System.Web.UI.Page
    {
        SearchController searchControl = new SearchController();
        SearchItemsModel model = new SearchItemsModel();
        SearchItemsModel resultModel;
        InvManagementEntities em = new InvManagementEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
                model.getCriteriaList().Add("");
                model.getCriteriaList().Add("");
                model.getCriteriaList().Add("");
                model.getCriteriaList().Add("");
                model.getCriteriaList().Add("");
                model.getCriteriaList().Add("");
                model.getCriteriaList().Add("");
                if (!IsPostBack)
                {
                    btnFilter.Enabled = false;
                    rbtItemCategory.Checked = true;
                    ViewState["PreviousPage"] = Request.UrlReferrer;
                    // add initializer values here
                }
        }

        protected void btnSearchItemName_Click(object sender, EventArgs e)
        {
            model.getCriteriaList()[2] = txtSearchItemName.Text.Trim();
        //    SearchItemsModel tempmodel = searchControl.getSearchByItemID(model);

            if (txtSearchItemName.Text.Trim().Length != 0)
                resultModel = searchControl.getSearchByItemName(model);
            else
                resultModel = searchControl.getAllItemDetails(model);

            List<StationeryItem> resultItemList = resultModel.getStationeryItemsList();
            gvSearchItems.DataSource = resultItemList;
            gvSearchItems.DataBind();
            if (resultItemList.Count > 0) btnFilter.Enabled = true;
        }

        protected void btnFilter_Click(object sender, EventArgs e)
        {
            if(txtFilter.Text.Trim().Length!=0) {
                if (rbtItemCategory.Checked == true)
                {
                    model.getCriteriaList()[6] = txtFilter.Text.Trim();
                    resultModel = searchControl.getSearchByItemCategory(model);

                    gvSearchItems.DataSource = resultModel.getStationeryItemsList();
                    gvSearchItems.DataBind();
                }
                else
                {
                    int tempSupplierID = Convert.ToInt32(txtFilter.Text.Trim());
                    model.getCriteriaList()[0] = txtFilter.Text.Trim();
                    List<StationeryItem> temp_staItems = searchControl.getSearchBySupplierID(model).getStationeryItemsList();
                    var tempItemList = from r in temp_staItems
                                  where 
                                  r.Description.ToLower().Contains(txtSearchItemName.Text.ToLower())
                                  select r;
                    //List<StationeryItem> temp2 = tempItemList.ToList<StationeryItem>()
                    List<StationeryItem> temp2 = temp_staItems.Where(p => p.Description.Contains(txtSearchItemName.Text.Trim())).ToList();
                    var temp = temp_staItems.Where(r=>r.Description.Contains(txtSearchItemName.Text.Trim()));
                    List<StationeryItem> tempi = temp.ToList<StationeryItem>();
                    gvSearchItems.DataSource = tempItemList.ToList<StationeryItem>();
                    gvSearchItems.DataBind();
                
                }
            }
        }

        protected void btnSelectItems_Click(object sender, EventArgs e)
        {
            List<string> selectedItemsId = new List<string>();
            foreach(GridViewRow gvr in gvSearchItems.Rows)   {
            //CheckBox cb = (CheckBox)gvr.Cells[4].Controls[0];
            CheckBox cb = gvr.FindControl("cbSelectItem") as CheckBox;

                if(cb.Checked == true)  {
                    string temp = gvr.Cells[0].Text;
                    selectedItemsId.Add(temp);
                }
            }
            Session["Search_SelectedItemsId"] = selectedItemsId;
            // creates session state variables to store the items and use it in previous page
            Response.Redirect(ViewState["PreviousPage"].ToString());
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect(ViewState["PreviousPage"].ToString());
        }
    }
}