using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EXOProject.Presentation
{
    public partial class orderinfo : System.Web.UI.Page
    {
        private EXOProject.Service.UserAccountService userAccountService = new Service.UserAccountService();

        protected void Page_Load(object sender, EventArgs e)
        {
            Order dispOrder = userAccountService.getOrderInfo(System.Web.HttpContext.Current.Session["BookedOrderID"].ToString());
            lblOrderID.Text = dispOrder.OID.ToString();
            lblCustName.Text = userAccountService.getCustomerInfo(dispOrder.CID).Name;
            lblCustMobile.Text = userAccountService.getCustomerInfo(dispOrder.CID).Mobile.ToString();
            lblCheckInDate.Text = dispOrder.DateIn.ToShortDateString();
            lblCheckOutDate.Text = dispOrder.DateOut.ToShortDateString();
            lblPaxCount.Text = dispOrder.PaxCount.ToString();
            lblRoomCount.Text = dispOrder.RoomCount.ToString();
            lblRoomType.Text = userAccountService.getRoomInfo(dispOrder.RID).Type;
            lblSpecialRequest.Text = dispOrder.SpecialRequest;
            lblTotalPrice.Text = System.Web.HttpContext.Current.Session["BookingOrderFare"].ToString();
            lblDayCount.Text = userAccountService.getNumNightsCount(dispOrder.DateIn, dispOrder.DateOut).ToString();
            

        }
    }
}