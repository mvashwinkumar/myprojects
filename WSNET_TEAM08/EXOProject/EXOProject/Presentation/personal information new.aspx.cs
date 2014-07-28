using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EXOProject.Presentation
{
    public partial class personal_information_new : System.Web.UI.Page
    {
        private EXOProject.Service.UserAccountService userAccountService = new Service.UserAccountService();
        

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    string loggedUser = System.Web.HttpContext.Current.Session["CustomerID"].ToString();
                    txtName.Text = loggedUser;
                    Cust loggedCustomer = userAccountService.getCustomerInfo(Convert.ToInt32(loggedUser.Trim()));
                    txtName.Text = loggedCustomer.Name;
                    txtPassportNo.Text = loggedCustomer.Passport;
                    txtAge.Text = loggedCustomer.Age.ToString();
                    txtMobile.Text = loggedCustomer.Mobile.ToString();
                    txtAddress.Text = loggedCustomer.Address;
                    txtNOKName.Text = loggedCustomer.NOKName;
                    txtNOKAddress.Text = loggedCustomer.NOKAddress;
                    txtNOKContact.Text = loggedCustomer.NOKContact.ToString();
                    if (loggedCustomer.Sex.ToUpper().Trim() == "MALE") { rdbMale.Checked = true; rdbFemale.Checked = false; }
                    else { rdbMale.Checked = false; rdbFemale.Checked = true; }
                    btnRegister.Text = "Save";
                }
                catch (Exception ex)
                {
                    btnRegister.Text = "Register";
                }
            }
        }

        protected void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Session.Remove("newCustomerID");
            Session.Remove("newUserID");
            Response.Redirect("~/Presentation/WelcomePageNew.aspx");
        }


        protected void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                string loggedUser = System.Web.HttpContext.Current.Session["CustomerID"].ToString();
                Cust updCustomer = userAccountService.getCustomerInfo(Convert.ToInt32(System.Web.HttpContext.Current.Session["CustomerID"].ToString().Trim()));
                updCustomer.Name = txtName.Text;
                if (rdbMale.Checked) updCustomer.Sex = "Male";
                else updCustomer.Sex = "Female";
                updCustomer.Passport = txtPassportNo.Text;
                updCustomer.Age = Convert.ToInt32(txtAge.Text.Trim());
                updCustomer.Mobile = txtMobile.Text.Trim();
                updCustomer.Address = txtAddress.Text;
                updCustomer.NOKName = txtNOKName.Text;
                updCustomer.NOKAddress = txtNOKAddress.Text;
                updCustomer.NOKContact = txtNOKContact.Text;
                userAccountService.updateCustomerInfo(updCustomer);
            }
            catch (Exception ex)
            {
                Cust newCustomer = new Cust();
                Login newUser = new Login();
                newUser.UserName = Session["newUserName"].ToString();
                newUser.Password = Session["newPassword"].ToString();
                newUser.Security_Question = Session["newSecurity_Question"].ToString();
                newUser.Answer = Session["newAnswer"].ToString();
                newUser.Type = Session["newType"].ToString();
                userAccountService.createNewUser(newUser);
                Login tempUser = userAccountService.getLoginInfo(newUser.UserName);
                
                newCustomer.Name = txtName.Text;
                newCustomer.UID = Convert.ToInt32(tempUser.UID);
                newCustomer.Passport = txtPassportNo.Text;
                newCustomer.Age = Convert.ToInt32(txtAge.Text.Trim());
                newCustomer.Mobile = txtMobile.Text.Trim();
                newCustomer.Address = txtAddress.Text;
                newCustomer.NOKName = txtNOKName.Text;
                newCustomer.NOKAddress = txtNOKAddress.Text;
                newCustomer.NOKContact = txtNOKContact.Text;
                if (rdbMale.Checked) newCustomer.Sex = "Male";
                else newCustomer.Sex = "Female";
                userAccountService.createNewCustomer(newCustomer);
                int tempCID = userAccountService.getCustomerInfobyUID(tempUser.UID).CID;

                System.Web.HttpContext.Current.Session["CustomerID"] = tempCID.ToString();
                System.Web.HttpContext.Current.Session["LoginId"] = tempUser.UID.ToString();
                System.Web.HttpContext.Current.Session["LoginName"] = tempUser.UserName;
                System.Web.HttpContext.Current.Session["LoginType"] = tempUser.Type;

                Session.Remove("newUserName");
                Session.Remove("newPassword");
                Session.Remove("newSecurity_Question");
                Session.Remove("newAnswer");
                Session.Remove("newType");

                Response.Redirect("~/Presentation/WelcomePageNew.aspx");
            }
        }
    }
}