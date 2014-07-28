using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webCA
{
    public partial class CA : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string name = System.Web.HttpContext.Current.Session["LoginName"].ToString();
                lblUserName.Text = "Welcome " + name;
                btnLogout.Visible = true;
                btnLogin.Visible = false;
                btnRegister.Visible = false;
                LinkButtonOrderHistory.Visible = true;
                LinkButtonPersonalInfo.Visible = true;
                string type = System.Web.HttpContext.Current.Session["LoginType"].ToString().ToLower().Trim();
                if ( type == "admin")
                {
                    btnAdminCustomer.Visible = true;
                    btnAdminLogin.Visible = true;
                    btnAdminOrder.Visible = true;
                    btnAdminRoom.Visible = true;
                }
                else
                {
                    btnAdminCustomer.Visible = false;
                    btnAdminLogin.Visible = false;
                    btnAdminOrder.Visible = false;
                    btnAdminRoom.Visible = false;
                }

            }
            catch (Exception ex)
            {
                lblUserName.Text = "Welcome guest";
                btnLogout.Visible = false;
                btnLogin.Visible = true;
                btnRegister.Visible = true;
                LinkButtonOrderHistory.Visible = false;
                LinkButtonPersonalInfo.Visible = false;
                btnAdminCustomer.Visible = false;
                btnAdminLogin.Visible = false;
                btnAdminOrder.Visible = false;
                btnAdminRoom.Visible = false;
            }

        }


        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.RemoveAll();
            Response.Redirect("~/Presentation/WelcomePageNew.aspx");
        }

        protected void LinkButtonPersonalInfo_Click(object sender, EventArgs e)
        {

        }
    }
}