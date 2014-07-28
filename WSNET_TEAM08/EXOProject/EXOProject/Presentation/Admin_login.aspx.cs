using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EXOProject.Presentation
{
    public partial class Admin_login : System.Web.UI.Page
    {
        private EXOProject.Service.UserAccountService userAccountService = new Service.UserAccountService();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRetrieve_Click(object sender, EventArgs e)
        {

            Login login = userAccountService.getLoginInfo(Convert.ToInt32(txtUserID.Text.Trim()));
            if (login != null)
            {
                txtUserID.Text = login.UID.ToString();
                txtUserName.Text = login.UserName;
                txtPassword.Text = login.Password;
                txtSecurityQue.Text = login.Security_Question;
                txtSecurityQueAns.Text = login.Answer;
                txtRoomType.Text = login.Type;

            }
            else ClearFields();

        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {
            Login newLogin = new Login();

            newLogin.UID = 0;
            newLogin.UserName = txtUserName.Text;
            newLogin.Password = txtPassword.Text;
            newLogin.Security_Question = txtSecurityQue.Text;
            newLogin.Answer = txtSecurityQueAns.Text;
            newLogin.Type = txtRoomType.Text;

            userAccountService.createNewUser(newLogin);
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            Login tempLogin = userAccountService.getLoginInfo(txtUserID.Text);


            tempLogin.UID = Convert.ToInt32(txtUserID.Text);
            tempLogin.UserName = txtUserName.Text;
            tempLogin.Password = txtPassword.Text;
            tempLogin.Security_Question = txtSecurityQue.Text;
            tempLogin.Answer = txtSecurityQueAns.Text;
            tempLogin.Type = txtRoomType.Text;

            userAccountService.updateUserInfo(tempLogin);
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            userAccountService.deleteUserInfo(txtUserID.Text);
            ClearFields();
        }

        private void ClearFields()
        {
            txtUserID.Text = string.Empty;
            txtUserName.Text = string.Empty;
            txtRoomType.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtSecurityQueAns.Text = string.Empty;
            txtSecurityQue.Text = string.Empty;

        }
    }
}