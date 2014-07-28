using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using com.iss.inventory.Controllers;
using com.iss.inventory.Entity;

namespace Staionery_Inventory.Presentation.StationeryRetrieval
{
    public partial class StationeryRetrievalForm : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               // initializeSRFDetails();
            }
        }

        [WebMethod]
        public static List<SRFDetail> initalizeSRFDetails()
        {
            StationeryRetrievalController srfControl = new StationeryRetrievalController();
            List<SRFDetail> newSRFDetails = srfControl.getIncompleteRequestsforSRF();
            return newSRFDetails;
        }
    }
}