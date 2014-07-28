using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EXOProject.Presentation
{
    public partial class Admin_Customer : System.Web.UI.Page
    {
        private EXOProject.Service.UserAccountService userAccountService = new Service.UserAccountService();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRetrieve_Click(object sender, EventArgs e)
        {
            Cust customer = userAccountService.getCustomerInfo(Convert.ToInt32(txtCustomerID.Text));
            if (customer != null)
            {
                txtName.Text = customer.Name;
                txtUserID.Text = customer.UID.ToString();
                txtCustomerID.Text = customer.CID.ToString();
                txtAge.Text = customer.Age.ToString();
                txtSex.Text = customer.Sex;
                txtMobile.Text = customer.Mobile;
                txtAddress.Text = customer.Address;
                txtNOKName.Text = customer.NOKName;
                txtNOKAddress.Text = customer.NOKAddress;
                txtNOKContact.Text = customer.NOKContact;
                txtPassport.Text = customer.Passport;
            }
            else ClearFields();

        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {
            Cust newCustomer = new Cust();

            newCustomer.UID = 0;        //to be filled
            newCustomer.Name = txtName.Text;
            newCustomer.Address = txtAddress.Text;
            newCustomer.NOKName = txtNOKName.Text;
            newCustomer.NOKAddress = txtNOKAddress.Text;
            newCustomer.Passport = txtPassport.Text;
            newCustomer.Sex = txtSex.Text;
            newCustomer.Mobile = txtMobile.Text;
            newCustomer.NOKContact = txtNOKContact.Text;
            newCustomer.Age = Convert.ToInt32(txtAge.Text);

            userAccountService.createNewCustomer(newCustomer);

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            Cust tempCustomer = userAccountService.getCustomerInfo(Convert.ToInt32(txtCustomerID.Text));

            //tempCustomer.CID = Convert.ToInt32(txtCustomerID.Text);
            //tempCustomer.UID = Convert.ToInt32(txtUserID.Text);
            tempCustomer.Name = txtName.Text;
            tempCustomer.Address = txtAddress.Text;
            tempCustomer.NOKName = txtNOKName.Text;
            tempCustomer.NOKAddress = txtNOKAddress.Text;
            tempCustomer.Passport = txtPassport.Text;
            tempCustomer.Sex = txtSex.Text;
            tempCustomer.Mobile = txtMobile.Text;
            tempCustomer.NOKContact = txtNOKContact.Text;
            tempCustomer.Age = Convert.ToInt32(txtAge.Text);

            userAccountService.updateCustomerInfo(tempCustomer);

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            userAccountService.deleteCustomerInfo(txtCustomerID.Text);
            ClearFields();
        }

        private void ClearFields()
        {
            txtName.Text = string.Empty;
            txtUserID.Text = string.Empty;
            txtCustomerID.Text = string.Empty;
            txtAge.Text = string.Empty;
            txtSex.Text = string.Empty;
            txtMobile.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtNOKName.Text = string.Empty;
            txtNOKAddress.Text = string.Empty;
            txtNOKContact.Text = string.Empty;
            txtPassport.Text = string.Empty;
        }
        
}
}