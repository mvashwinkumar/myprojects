using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EXOProject.Presentation
{
    public partial class executivedetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBookEK_Click(object sender, EventArgs e)
        {
            
            System.Web.HttpContext.Current.Session["RoomName"] = "King";
            System.Web.HttpContext.Current.Session["RoomType"] = "Executive";
            Response.Redirect("~/Presentation/confirminfo.aspx");
           
        }
    }
}