using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EXOProject.Presentation
{
    public partial class login : System.Web.UI.Page
    {
        private EXOProject.Service.UserAccountService userAccountService =new Service.UserAccountService();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnJoin_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Presentation/personal information new.aspx");
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            using (HotelDBEntities hde = new HotelDBEntities())
            {
                Login userLoginData =  userAccountService.validateLoginDetails(tbUserName.Text, tbPW.Text);
                if (userLoginData != null)
                {
                    System.Web.HttpContext.Current.Session["CustomerID"] = userAccountService.getCustomerInfobyUID(userLoginData.UID).CID;
                    System.Web.HttpContext.Current.Session["LoginId"] = userLoginData.UID;
                    System.Web.HttpContext.Current.Session["LoginName"] = userLoginData.UserName;
                    System.Web.HttpContext.Current.Session["LoginType"] = userLoginData.Type;
                    Response.Redirect("~/Presentation/WelcomePageNew.aspx");
                }
            }
        }
    }
}