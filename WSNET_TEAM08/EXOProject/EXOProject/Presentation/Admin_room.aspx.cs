using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EXOProject.Presentation
{
    public partial class Admin_room : System.Web.UI.Page
    {
        private EXOProject.Service.UserAccountService userAccountService = new Service.UserAccountService();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRetrieve_Click(object sender, EventArgs e)
        {
            Room room = userAccountService.getRoomInfo(Convert.ToInt32(txtRoomID.Text));
            if (room != null)
            {
                txtRoomName.Text = room.Name;
                txtRoomType.Text = room.Type;
                txtSummary.Text = room.Summary;
                txtRoomCapacity.Text = room.Capacity.ToString();
                txtAmenities.Text = room.Amenities;
                txtPrice.Text = room.Price.ToString();
                txtImageURL.Text = room.ImageURL;
            }
            else ClearFields();

        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {
            Room newRoom = new Room();

            newRoom.Name = txtRoomName.Text;
            newRoom.Capacity = Convert.ToInt32(txtRoomCapacity.Text);
            newRoom.Summary = txtSummary.Text;
            newRoom.Amenities = txtAmenities.Text;
            newRoom.Price = Convert.ToInt32(txtPrice.Text);
            newRoom.Type = txtRoomType.Text;
            newRoom.ImageURL = txtImageURL.Text;

            userAccountService.createNewRoom(newRoom);


        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            Room tempRoom = userAccountService.getRoomInfo(Convert.ToInt32(txtRoomID.Text));

            tempRoom.Name = txtRoomName.Text;
            tempRoom.Capacity = Convert.ToInt32(txtRoomCapacity.Text);
            tempRoom.Summary = txtSummary.Text;
            tempRoom.Amenities = txtAmenities.Text;
            tempRoom.Price = Convert.ToInt32(txtPrice.Text);
            tempRoom.Type = txtRoomType.Text;
            tempRoom.ImageURL = txtImageURL.Text;

            userAccountService.updateRoomInfo(tempRoom);
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            userAccountService.deleteRoomInfo(txtRoomID.Text);
            ClearFields();
        }

        private void ClearFields()
        {
            txtRoomID.Text = string.Empty;
            txtRoomName.Text = string.Empty;
            txtRoomType.Text = string.Empty;
            txtSummary.Text = string.Empty;
            txtRoomCapacity.Text = string.Empty;
            txtAmenities.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtImageURL.Text = string.Empty;
        }

    }
}