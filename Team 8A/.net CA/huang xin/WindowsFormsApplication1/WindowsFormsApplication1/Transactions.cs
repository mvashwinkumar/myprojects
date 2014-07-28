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

namespace LibraryTeam8A
{
    public partial class Form_Transactions : Form
    {
        SqlConnection cnTransactions;
        SqlCommand cmShowStatus;
        SqlDataAdapter daShowStatus;
        SqlCommandBuilder cmb;
        DataSet dsShowStatus;
        DataView dvShowStatus;
        int posn = -1;
        string tempBookID;
        string tempMemberID;


        public Form_Transactions()
        {
            InitializeComponent();
            btn_Loan.Enabled = false;
            btn_Return.Enabled = false;

        }


        private void btn_ShowStatus_Click(object sender, EventArgs e)
        {
            cmShowStatus = new SqlCommand("select t.BookID, b.BookName, t.IssueDate, t.DueDate from Transactions t left outer join Books b on t.BookID = b.BookID where MemberID = '" + txt_MemberID.Text + "' and Status = 'Out'", cnTransactions);
            daShowStatus = new SqlDataAdapter(cmShowStatus);
            dsShowStatus = new DataSet();
            daShowStatus.Fill(dsShowStatus);
            dg_PersonalLoanStatus.DataSource = dsShowStatus.Tables[0];

            tempMemberID = txt_MemberID.Text;
        }

        private void Form_Transactions_Load(object sender, EventArgs e)
        {
            cnTransactions = new SqlConnection(@"data source=(local); integrated security=SSPI;initial catalog=library");

            cnTransactions.Open();

        }

        private void btn_MemberInfo_Click(object sender, EventArgs e)
        {
            cmShowStatus = new SqlCommand("select * from Members where MemberID = '" + txt_MemberID.Text + "'", cnTransactions);
            daShowStatus = new SqlDataAdapter(cmShowStatus);
            dsShowStatus = new DataSet();
            daShowStatus.Fill(dsShowStatus);
            dg_MemberInfo.DataSource = dsShowStatus.Tables[0];

            tempMemberID = txt_MemberID.Text;
        }

        private void btn_retrieve_Click(object sender, EventArgs e)
        {
            cmShowStatus = new SqlCommand("select * from Books", cnTransactions);
            daShowStatus = new SqlDataAdapter(cmShowStatus);
            dsShowStatus = new DataSet();
            daShowStatus.Fill(dsShowStatus);
            
            dvShowStatus = new DataView();
            dvShowStatus.Table = dsShowStatus.Tables[0];
            dvShowStatus.Sort = "BookID";
            posn = dvShowStatus.Find(txt_BookID.Text);
            tempBookID = dvShowStatus.Table.Rows[posn]["BookID"].ToString();

            // write the four lines to a single method
            cmShowStatus = new SqlCommand("select * from Books where BookID ='"+txt_BookID.Text+"'", cnTransactions);
            daShowStatus = new SqlDataAdapter(cmShowStatus);
            dsShowStatus = new DataSet();
            daShowStatus.Fill(dsShowStatus);
            dg_BookInfo.DataSource = dsShowStatus.Tables[0];
            btn_Loan.Enabled = true;
            btn_Return.Enabled = true;

        }

        private void btn_Loan_Click(object sender, EventArgs e)
        {
            cmShowStatus = new SqlCommand("select * from Transactions", cnTransactions);
            daShowStatus = new SqlDataAdapter(cmShowStatus);
            cmb = new SqlCommandBuilder(daShowStatus);
            dsShowStatus = new DataSet();
            daShowStatus.Fill(dsShowStatus,"Transactions");
            DataRow dr = dsShowStatus.Tables[0].NewRow();
            dr["TransactionID"] = "T" + dsShowStatus.Tables[0].Rows.Count.ToString();
            dr["BookID"] = Convert.ToInt16(tempBookID);
            dr["MemberID"] = tempMemberID;
            dr["IssueDate"] = System.DateTime.Today;
            dr["DueDate"] = System.DateTime.Today.AddDays(30);
            dr["ReturnDate"] = System.DateTime.Today.AddDays(2000);
            dr["Status"] = "Out";
            dr["Remarks"] = "Checked Out";
            dsShowStatus.Tables[0].Rows.Add(dr);
            daShowStatus.Update(dsShowStatus,"Transactions");

            tempMemberID = "";
            tempBookID = "";

            cmShowStatus = new SqlCommand("select * from Books", cnTransactions);
            daShowStatus = new SqlDataAdapter(cmShowStatus);
            cmb = new SqlCommandBuilder(daShowStatus);
            dsShowStatus = new DataSet();
            daShowStatus.Fill(dsShowStatus,"Books");
            dsShowStatus.Tables[0].Rows[posn]["NumberLended"] = Convert.ToInt32(dsShowStatus.Tables[0].Rows[posn]["NumberLended"].ToString())+1;
            daShowStatus.Update(dsShowStatus,"Books");
        }

        private void btn_Return_Click(object sender, EventArgs e)
        {
            cmShowStatus = new SqlCommand("select * from Transactions where MemberID = '" +tempMemberID+ "' and Status = 'Out'", cnTransactions);
            daShowStatus = new SqlDataAdapter(cmShowStatus);
            cmb = new SqlCommandBuilder(daShowStatus);
            dsShowStatus = new DataSet();
            daShowStatus.Fill(dsShowStatus, "Transactions");
            dvShowStatus = new DataView();
            dvShowStatus.Table = dsShowStatus.Tables[0];
            dvShowStatus.Sort = "BookID";
            int posnTran = dvShowStatus.Find(tempBookID);
            dsShowStatus.Tables[0].Rows[posnTran]["ReturnDate"] = System.DateTime.Today;
            dsShowStatus.Tables[0].Rows[posnTran]["Status"] = "In";
            dsShowStatus.Tables[0].Rows[posnTran]["Remarks"] = "Ok";

            daShowStatus.Update(dsShowStatus, "Transactions");

            cmShowStatus = new SqlCommand("select * from Books", cnTransactions);
            daShowStatus = new SqlDataAdapter(cmShowStatus);
            cmb = new SqlCommandBuilder(daShowStatus);
            dsShowStatus = new DataSet();
            daShowStatus.Fill(dsShowStatus, "Books");
            dsShowStatus.Tables[0].Rows[posn]["NumberLended"] = Convert.ToInt32(dsShowStatus.Tables[0].Rows[posn]["NumberLended"].ToString()) - 1;
            daShowStatus.Update(dsShowStatus, "Books");
        }
    }
}
