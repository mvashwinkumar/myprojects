using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EXOProject.Presentation
{
    public partial class Paymentnew : System.Web.UI.Page
    {
        private EXOProject.Service.UserAccountService userAccountService = new Service.UserAccountService();
        private Room bookingRoom;
        private Cust customerInfo;
        private Order newOrder;
        private double paymentFare;
        protected void Page_Load(object sender, EventArgs e)
        {
            Calendar1.Visible = false;
            paymentFare = Convert.ToDouble(System.Web.HttpContext.Current.Session["BookingOrderFare"].ToString());
        }
        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Calendar1.Visible = true;
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            txtED.Text = Calendar1.SelectedDate.ToShortDateString();
            Calendar1.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (CheckBox1.Checked)
            {
                bookingRoom = userAccountService.getRoomInfo(System.Web.HttpContext.Current.Session["BookingRoomName"].ToString(), System.Web.HttpContext.Current.Session["BookingRoomType"].ToString());
                int temp = Convert.ToInt32(System.Web.HttpContext.Current.Session["LoginId"].ToString());
                customerInfo = userAccountService.getCustomerInfobyUID(Convert.ToInt32(System.Web.HttpContext.Current.Session["LoginId"].ToString()));
                newOrder = new Order();
                newOrder.CID = customerInfo.CID;
                newOrder.RID = bookingRoom.RID;
                newOrder.DateIn = Convert.ToDateTime(System.Web.HttpContext.Current.Session["BookingDateIn"].ToString());
                newOrder.DateOut = Convert.ToDateTime(System.Web.HttpContext.Current.Session["BookingDateOut"].ToString());
                newOrder.PaxCount = Convert.ToInt32(System.Web.HttpContext.Current.Session["BookingPaxCount"].ToString());
                newOrder.RoomCount = Convert.ToInt32(System.Web.HttpContext.Current.Session["BookingRoomCount"].ToString());
                newOrder.SpecialRequest = System.Web.HttpContext.Current.Session["BookingRoomSpecialRequest"].ToString();
                int orderID = userAccountService.createNewOrder(newOrder);
                System.Web.HttpContext.Current.Session["BookedOrderID"] = orderID;
                Response.Write("Order Booked");
                Response.Redirect("~/Presentation/orderinfo.aspx");
            }
            else lblErrMessage.Text = "Check the Privacy policy box";
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Session.Remove("BookingRoomName");
            Session.Remove("BookingRoomType");
            Session.Remove("BookingDateIn");
            Session.Remove("BookingDateOut");
            Session.Remove("BookingPaxCount");
            Session.Remove("BookingRoomCount");
            Session.Remove("BookingOrderFare");
            Session.Remove("BookingRoomSpecialRequest");
            Response.Redirect("~/Presentation/selectroomN.aspx");
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        
    }
}