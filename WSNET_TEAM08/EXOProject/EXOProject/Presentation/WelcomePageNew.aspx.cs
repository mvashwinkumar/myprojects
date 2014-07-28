using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webCA
{
    public partial class WelcomePageNew : System.Web.UI.Page
    {
        private string[] months = { "", "Jan", "Feb", "Mar", "Apr", "May", "Jun", "July", "Aug", "Sept", "Oct", "Nov", "Dec" };
        protected void Page_Load(object sender, EventArgs e)
        {
            lblFooter.Text = DateTime.Now.Day.ToString() + "-" + months[DateTime.Now.Month] + "-" + DateTime.Now.Year;
        }
    }
}