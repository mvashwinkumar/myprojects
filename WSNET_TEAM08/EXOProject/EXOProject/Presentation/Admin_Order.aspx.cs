using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EXOProject.Presentation
{
    public partial class Admin_Order : System.Web.UI.Page
    {
        private EXOProject.Service.UserAccountService userAccountService = new Service.UserAccountService();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRetrieve_Click(object sender, EventArgs e)
        {
            Order order = userAccountService.getOrderInfo(txtOrderID.Text);
            if (order != null)
            {
                txtOrderID.Text = order.OID.ToString();
                txtRoomID.Text = order.RID.ToString();
                txtCustomerID.Text = order.CID.ToString();
                txtDateIn.Text = order.DateIn.ToString();
                txtDateOut.Text = order.DateOut.ToString();
                txtPaxCount.Text = order.PaxCount.ToString();
                txtRoomCount.Text = order.RoomCount.ToString();
                txtSpecialRequest.Text = order.SpecialRequest;
            }
            else ClearFields();
        }

    protected void btnCreate_Click(object sender, EventArgs e)
        {
            Order newOrder = new Order();

            newOrder.RID = 0;       //to be filled
            newOrder.CID =  Convert.ToInt32(txtCustomerID.Text);
            newOrder.DateIn = Convert.ToDateTime(txtDateIn.Text);
            newOrder.DateOut = Convert.ToDateTime(txtDateOut.Text);
            newOrder.PaxCount =  Convert.ToInt32(txtPaxCount.Text);
            newOrder.RoomCount = Convert.ToInt32(txtRoomCount.Text);
            newOrder.SpecialRequest = txtSpecialRequest.Text;

            userAccountService.createNewOrder(newOrder);
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            Order tempOrder = userAccountService.getOrderInfo(txtOrderID.Text);

            //tempOrder.CID =  Convert.ToInt32(txtCustomerID.Text);
            //tempOrder.RID =  Convert.ToInt32(txtOrderID.Text);
            //tempOrder.CID =  Convert.ToInt32(txtCustomerID.Text);
            tempOrder.DateIn = Convert.ToDateTime(txtDateIn.Text);
            tempOrder.DateOut = Convert.ToDateTime(txtDateOut.Text);
            tempOrder.PaxCount =  Convert.ToInt32(txtPaxCount.Text);
            tempOrder.RoomCount =  Convert.ToInt32(txtRoomCount.Text);
            tempOrder.SpecialRequest = txtSpecialRequest.Text;
            

            userAccountService.updateOrderInfo(tempOrder);
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            userAccountService.deleteOrderInfo(txtOrderID.Text);
            ClearFields();
        }

        private void ClearFields()
        {
            txtOrderID.Text = string.Empty;
            txtRoomID.Text = string.Empty;
            txtCustomerID.Text = string.Empty;
            txtDateIn.Text = string.Empty;
            txtDateOut.Text = string.Empty;
            txtPaxCount.Text = string.Empty;
            txtRoomCount.Text = string.Empty;
            txtSpecialRequest.Text = string.Empty;
        }
        
    }
}