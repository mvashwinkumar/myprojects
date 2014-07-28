using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EXOProject.Presentation
{
    public partial class deluxedetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBookDK_Click(object sender, EventArgs e)
        {
                System.Web.HttpContext.Current.Session["RoomName"] = "King";
                System.Web.HttpContext.Current.Session["RoomType"] = "Deluxe";
                string val = System.Web.HttpContext.Current.Session["RoomName"].ToString();
                Response.Redirect("~/Presentation/confirminfo.aspx"); 
        }

        protected void btnBookDT_Click(object sender, EventArgs e)
        {

            System.Web.HttpContext.Current.Session["RoomName"] = "Twin";
            System.Web.HttpContext.Current.Session["RoomType"] = "Deluxe";
            Response.Redirect("~/Presentation/confirminfo.aspx");
        }
    }
}