using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EXOProject.Presentation
{
    public partial class confirminfo : System.Web.UI.Page
    {
        private EXOProject.Service.UserAccountService userAccountService = new Service.UserAccountService();
        private Room bookingRoom;
        private double calcFare;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bool isLoggedIn = false;
                try
                {
                    string chkLoggedIn = (Session["LoginId"].ToString());
                    isLoggedIn = true;
                }
                catch (Exception ex)
                {
                    Session.Remove("RoomName");
                    Session.Remove("RoomType");
                }
                if (isLoggedIn)
                {
                    string tempRoomName = System.Web.HttpContext.Current.Session["RoomName"].ToString();
                    string tempRoomType = System.Web.HttpContext.Current.Session["RoomType"].ToString();
                    bookingRoom = userAccountService.getRoomInfo(tempRoomName, tempRoomType);
                    txtAmenities.Text = bookingRoom.Amenities;
                    txtSummary.Text = bookingRoom.Summary;
                    lblPerNightFare.Text = bookingRoom.Price.ToString();
                    txtDateIn.Text = DateTime.Now.Date.ToShortDateString();
                    btnConf.Enabled = false;
                    imgOrder.ImageUrl = bookingRoom.ImageURL;
                }
                else
                {
                    Response.Redirect("~/Presentation/login.aspx");
                }
            }
            else
            {
                string tempRoomName = System.Web.HttpContext.Current.Session["RoomName"].ToString();
                string tempRoomType = System.Web.HttpContext.Current.Session["RoomType"].ToString();
                bookingRoom = userAccountService.getRoomInfo(tempRoomName, tempRoomType);
                txtAmenities.Text = bookingRoom.Amenities;
                txtSummary.Text = bookingRoom.Summary;
                lblPerNightFare.Text = bookingRoom.Price.ToString();
                txtDateIn.Text = DateTime.Now.Date.ToShortDateString();
                btnConf.Enabled = false;
                imgOrder.ImageUrl = bookingRoom.ImageURL;
            }
        }

        protected void btnConf_Click(object sender, EventArgs e)
        {
            System.Web.HttpContext.Current.Session["BookingRoomName"] = System.Web.HttpContext.Current.Session["RoomName"].ToString();
            System.Web.HttpContext.Current.Session["BookingRoomType"] = System.Web.HttpContext.Current.Session["RoomType"].ToString();
            System.Web.HttpContext.Current.Session["BookingDateIn"] =   txtDateIn.Text;
            System.Web.HttpContext.Current.Session["BookingDateOut"] = txtDateOut.Text;
            System.Web.HttpContext.Current.Session["BookingPaxCount"] = txtPaxCount.Text;
            System.Web.HttpContext.Current.Session["BookingRoomCount"] = txtRoomCount.Text;
            System.Web.HttpContext.Current.Session["BookingRoomSpecialRequest"] = txtSpecialRequest.Text;
            
            Response.Redirect("~/Presentation/Paymentnew.aspx");
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

        protected void btnChkAvail_Click(object sender, EventArgs e)
        {
           bool chkAvail = userAccountService.isRoomAvailable(bookingRoom.RID, Convert.ToDateTime(txtDateIn.Text), Convert.ToDateTime(txtDateOut.Text), Convert.ToInt32(txtRoomCount.Text));
           if (chkAvail)
           {
               lblAvailStatus.Text = "Available";
               int temp = userAccountService.getNumNightsCount(Convert.ToDateTime(txtDateIn.Text), Convert.ToDateTime(txtDateOut.Text));
               calcFare = (bookingRoom.Price) * (temp);
               lblNumNights.Text = temp.ToString();
               lblTotalFare.Text = calcFare.ToString();
               System.Web.HttpContext.Current.Session["BookingOrderFare"] = calcFare.ToString();
               btnConf.Enabled = true;
           }
           else
           {
               lblAvailStatus.Text = "Not Available";
               btnConf.Enabled = false;
           }
        }

        protected void CalendarDateIn_SelectionChanged(object sender, EventArgs e)
        {
            txtDateIn.Text = CalendarDateIn.SelectedDate.ToShortDateString();
            CalendarDateIn.Visible = false;
        }

        protected void CalendarDateOut_SelectionChanged(object sender, EventArgs e)
        {
            txtDateOut.Text = CalendarDateOut.SelectedDate.ToShortDateString();
            CalendarDateOut.Visible = false;
        }

        protected void btnDateInCal_Click(object sender, ImageClickEventArgs e)
        {
            CalendarDateIn.Visible = true;
        }

        protected void btnDateOutCal_Click(object sender, ImageClickEventArgs e)
        {
            CalendarDateOut.Visible = true;
        }
    }
}