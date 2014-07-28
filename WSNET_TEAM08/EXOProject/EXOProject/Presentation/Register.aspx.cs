using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EXOProject.Presentation
{
    public partial class Register : System.Web.UI.Page
    {
        private EXOProject.Service.UserAccountService userAccountService = new Service.UserAccountService();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Login newLogin = new Login();
            newLogin.UID = 0;
            newLogin.UserName = txtCustomerName.Text;
            newLogin.Password = txtPassword.Text;
            newLogin.Security_Question = ddlSecurityQuestion.SelectedValue;
            newLogin.Answer = txtAnswer.Text;
            newLogin.Type = "user";
            Session.Add("newUserName", newLogin.UserName);
            Session.Add("newPassword", newLogin.Password);
            Session.Add("newSecurity_Question", newLogin.Security_Question);
            Session.Add("newAnswer", newLogin.Answer);
            Session.Add("newType", newLogin.Type);
            
            Response.Redirect("~/Presentation/personal information new.aspx");
        }

        protected void ddlSecurityQuestion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Session.Remove("newUserID");
            Response.Redirect("~/Presentation/WelcomePageNew.aspx");
        }
    }
}