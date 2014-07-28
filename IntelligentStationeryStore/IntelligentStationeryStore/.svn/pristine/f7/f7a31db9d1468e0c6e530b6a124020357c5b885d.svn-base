using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using com.iss.inventory;
using com.iss.inventory.CustomModels;


namespace Staionery_Inventory
{
    public partial class StationeryRequisitionForm : System.Web.UI.Page
    {
        List<dummestaioneryData> lisdel = new List<dummestaioneryData>();
        MainController mc;
        RequestListModel requestListModel;
       

        protected void Page_Load(object sender, EventArgs e)
        {
            requestListModel = new RequestListModel();
            //dummy
            Label lbl = this.Master.FindControl("lblLogInName") as Label;
            mc = new MainController();
            if (lbl != null)
            {
                lbl.Text = Request.QueryString["name"];
            }
            lblDepartmentName.Text =(string)(Session["Department"]);
                List<dummestaioneryData> lis = new List<dummestaioneryData>();
                dummestaioneryData sh = new dummestaioneryData( "Pencil 2B", 32, "Dozen");
                //dummestaioneryData sh2 = new dummestaioneryData( "Clip Double 2", 32, "Dozen");
                //dummestaioneryData sh3 = new dummestaioneryData( "Clip Double 3/4", 32, "Dozen");

                lis.Add(sh);
                //lis.Add(sh2);
                ///lis.Add(sh3);
                gvStationeryRequisition.DataSource = lis;
                gvStationeryRequisition.DataBind();
                
             lisdel =(List<dummestaioneryData>)gvStationeryRequisition.DataSource;
       
            }

        protected void gvStationeryRequisition_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            lisdel.RemoveAt(e.RowIndex);
           // dt.Rows.RemoveAt(e.RowIndex);
            gvStationeryRequisition.DataSource = lisdel;
            gvStationeryRequisition.DataBind();
 
        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {

            HiddenField hf = this.Master.FindControl("hfconfirm") as HiddenField;
            if (hf.Value=="true")
            {
                requestListModel.EmployeeID = int.Parse(Session["empID"].ToString());
                requestListModel.ApproveID = int.Parse(Session["ApproveID"].ToString());
                requestListModel.DateSubmittion = DateTime.Today;
                if (txtSpecialRequest.Text != "")
                {
                    requestListModel.SpecialRequest = txtSpecialRequest.Text;
                }
                else
                    requestListModel.SpecialRequest = "None";
               requestListModel.Status = "Pending";
                int lastrequestID=mc.StationeryRequestController(requestListModel);
                 AddReustListDetail(gvStationeryRequisition,lastrequestID);
                 lblRequestID.Text = lastrequestID.ToString();
                 txtSpecialRequest.Enabled = false;
                 btnAddmore.Enabled = false;
                 btnsubmit.Enabled = false;
                 gvStationeryRequisition.Enabled = false;
            }
            
            
        }


        public void AddReustListDetail(GridView gv,int requestID)
        {
            foreach (GridViewRow gr in gv.Rows)
            {
                TextBox quantity = gr.FindControl("txtQuatity") as TextBox;
              mc.StationeryRequestDetailController(requestID,gr.Cells[0].Text,int.Parse(quantity.Text));
            }
        }
    }

    public class dummestaioneryData
    {
        
        int quan1;

        public int Quan1
        {
            get { return quan1; }
            set { quan1 = value; }
        }
        String des1;

        public String Des1
        {
            get { return des1; }
            set { des1 = value; }
        }
        int rquan;
        string umeasure;

        public string Umeasure
        {
            get { return umeasure; }
            set { umeasure = value; }
        }

        public int Rquan
        {
            get { return rquan; }
            set { rquan = value; }
        }

        public dummestaioneryData(String Des, int quna, string umeasure)
        {
            this.quan1 = quna;
            this.des1 = Des;
            this.umeasure = umeasure;
        }

        public dummestaioneryData(String Des, int quna, int rquan, string umeasure)
        {
             this.des1 = Des;
            this.rquan = rquan;
            this.umeasure = umeasure;
        }


    }
}