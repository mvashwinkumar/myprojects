﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LibraryTeam8A
{
    public partial class Form_Login : Form
    {
        Form_Transactions TransactionScreen;
        TransactionsController transactionsControl;

        SqlConnection cnLogin;
        SqlCommand cmSubmit;
        SqlDataAdapter daSubmit;
        DataSet dsStaff;
        DataView dvStaff;

        public Form_Login(TransactionsController tc)
        {
            InitializeComponent();
            transactionsControl = tc;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            string str = transactionsControl.getStaffIDPassword(txt_StaffID.Text,txt_Password.Text);
            MessageBox.Show(str);
            //dvStaff.Sort = "StaffID";
            //int posnID = dvStaff.Find(txt_StaffID.Text);
            //dvStaff.Sort = "StaffPassword";
            //int posnPwd = dvStaff.Find(txt_Password.Text);
            //if (posnID >= 0 && posnPwd >= 0)
            //{
            //    MessageBox.Show("Welcome " + dsStaff.Tables["Staff"].Rows[posnID]["StaffName"].ToString());
            //    TransactionScreen = new Form_Transactions();
            //    TransactionScreen.Show();
            //}
            //else
            //    MessageBox.Show("Incorrect Login");
          
        }

        private void Form_Login_Load(object sender, EventArgs e)
        {
            //cnLogin = new SqlConnection(@"data source=(local); integrated security=SSPI;initial catalog=library");
            //cmSubmit = new SqlCommand("Select * from Staff", cnLogin);
            //daSubmit = new SqlDataAdapter(cmSubmit);
            //dsStaff = new DataSet();
            //cnLogin.Open();
            //daSubmit.Fill(dsStaff, "Staff");
            //dvStaff = new DataView();
            //dvStaff.Table = dsStaff.Tables["Staff"];
           
            
            
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
