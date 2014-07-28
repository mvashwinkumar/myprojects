using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EXOProject.Presentation
{
    public partial class suitedetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBookLS_Click(object sender, EventArgs e)
        {
            
            System.Web.HttpContext.Current.Session["RoomName"] = "Loft";
            System.Web.HttpContext.Current.Session["RoomType"] = "Suite";
            Response.Redirect("~/Presentation/confirminfo.aspx");
            
        }

        protected void btnBookES_Click(object sender, EventArgs e)
        {
            
            System.Web.HttpContext.Current.Session["RoomName"] = "Executive";
            System.Web.HttpContext.Current.Session["RoomType"] = "Suite";
            Response.Redirect("~/Presentation/confirminfo.aspx");
          
        }

        protected void btnBookPS_Click(object sender, EventArgs e)
        {
            
            System.Web.HttpContext.Current.Session["RoomName"] = "Pissaro";
            System.Web.HttpContext.Current.Session["RoomType"] = "Suite";
            Response.Redirect("~/Presentation/confirminfo.aspx");
            
        }
    }
}