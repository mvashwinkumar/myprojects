using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using com.iss.inventory;
using com.iss.inventory.CustomModels;

namespace Staionery_Inventory
{
    public partial class login : System.Web.UI.Page
    {
        MainController mc;
               
        protected void Page_Load(object sender, EventArgs e)
        {
            mc = new MainController();
         }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            List<string> log = new List<string>();
            String username=txtName.Text.ToString();
            String password=txtPass.Text.ToString();
           
            log= mc.LoginController(username, password);
            if (log.Count<2)
            {
                lblLoginInfo.Text = log[0];
                txtName.Text = "";
            }
            else
            {
                
                   Session["empID"] = log[0];
                   Session["role"] = log[1];
                   Session["Department"] = log[2];
                   Session["ApproveID"] = log[3];
              
                Response.Redirect("~/Presentation/StationeryRequest/StationeryRequisitionForm.aspx?name="+this.txtName.Text);
              

            }
                       
        }

      
    }
}