using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using com.iss.inventory.Entity;

namespace Staionery_Inventory.Presentation
{
    public partial class ajaxtest : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [WebMethod]
        public static string getItemName(string itemID)
        {
            InvManagementEntities em = new InvManagementEntities();
            return  em.StationeryItems.Where(x => x.ItemID.Equals(Convert.ToInt32(itemID))).FirstOrDefault().Description;
        }
    }
}