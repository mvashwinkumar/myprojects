using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FinalizedProject
{
    public partial class Form_Login : Form
    {
        string connectionstring="data source=(local);initial catalog=Library;Integrated Security=SSPI";//add
        Form_Transactions TransactionScreen;


        SqlConnection cnLogin;
        SqlCommand cmSubmit;
        SqlDataAdapter daSubmit;
        DataSet dsStaff;
        DataView dvStaff;

        public Form_Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            dvStaff.Sort = "StaffID";
            int posnID = dvStaff.Find(txt_StaffID.Text);
            dvStaff.Sort = "StaffPassword";
            int posnPwd = dvStaff.Find(txt_Password.Text);
            if (posnID >= 0 && posnPwd >= 0)
            {
                MessageBox.Show("Welcome " + dsStaff.Tables["Staff"].Rows[posnID]["StaffName"].ToString());
                TransactionScreen = new Form_Transactions();
                TransactionScreen.Show();
            }
            else
                MessageBox.Show("Incorrect Login");
            }

        private void Form_Login_Load(object sender, EventArgs e)
        {
            cnLogin = new SqlConnection(connectionstring);//change
            cmSubmit = new SqlCommand("Select * from Staff", cnLogin);
            daSubmit = new SqlDataAdapter(cmSubmit);
            dsStaff = new DataSet();
            cnLogin.Open();
            daSubmit.Fill(dsStaff, "Staff");
            dvStaff = new DataView();
            dvStaff.Table = dsStaff.Tables["Staff"];
            
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_StaffID.Text = "";
            txt_Password.Text = "";
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            SearchBooks searchBooks = new SearchBooks();
            searchBooks.Show();
        }
    }
}
