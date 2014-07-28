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
    public partial class SearchBooks : Form
    {
        SqlConnection cn;
        SqlCommand cm;
        SqlDataAdapter da;
        DataSet ds;
        DataView dv;
        string Connectionstring = "data source=(local);initial catalog=Library;Integrated Security=SSPI";
        
        string selectedBookID;

        public SearchBooks()
        {
            InitializeComponent();
        }

        private void SearchBooks_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(Connectionstring);
            cn.Open();
            btn_CheckAvailability.Enabled = false;
            cb_SortBy.Enabled = false;
            cb_SearchBy.SelectedIndex = 0;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            cm = new SqlCommand("select * from books where " + cb_SearchBy.Text + " like '%" + txt_SearchBy.Text + "%'", cn);
            da = new SqlDataAdapter(cm);
            ds = new DataSet();
            da.Fill(ds);
            dv = new DataView();
            dv.Table = ds.Tables[0];

            dv.Sort = "Category";
            dg_SearchResults.DataSource = dv;
            cb_SortBy.Enabled = true;

            dt = dv.ToTable(true,"Category");
            cb_SortBy.Items.Clear();
            
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cb_SortBy.Items.Add(dt.Rows[i]["Category"].ToString());
            }

        }


        private void dg_SearchResults_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRow = this.dg_SearchResults.SelectedRows;
            selectedBookID = this.dg_SearchResults.Rows[selectedRow[0].Index].Cells[0].Value.ToString();
            btn_CheckAvailability.Enabled = true;
        }

        private void cb_SortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            dv.RowFilter = "Category='" + cb_SortBy.Text + "'";
            dg_SearchResults.DataSource = dv;
        }

        private void btn_CheckAvailability_Click(object sender, EventArgs e)
        {   int availcount;
        string commmandtext1 = "Select bookID,TotalStock-NumberLended as avail_book from Books where bookID='";
            //   cm = new SqlCommand("exec calc_avail " + selectedBookID, cn);
           cm = new SqlCommand(commmandtext1+selectedBookID+"'",cn);
            da = new SqlDataAdapter(cm);
            ds = new DataSet();
            da.Fill(ds);
            availcount = Convert.ToInt32(ds.Tables[0].Rows[0][1].ToString());
            if (availcount.ToString() == "0")
            {
                try
                {
                    string commandTextdudate1 = "select t.duedate from [tran] t left outer join books b on b.bookID=t.bookid where t.bookID='";
                    string commandTextdudate2 = " and t.status='Out'";
                    //cm = new SqlCommand("exec last_duedate " + selectedBookID, cn);
                    cm = new SqlCommand(commandTextdudate1 + selectedBookID + "'" + commandTextdudate2, cn);
                    da = new SqlDataAdapter(cm);
                    ds = new DataSet();
                    da.Fill(ds);
                    MessageBox.Show("Book not Available. Next Available Date is" + ds.Tables[0].Rows[0][0].ToString());
                }
                catch (Exception exc)
                {
                    throw;
                }
            }
            else
            {
                cm = new SqlCommand("select * from Books where BookID='" + selectedBookID + "'", cn);
                da = new SqlDataAdapter(cm);
                ds = new DataSet();
                da.Fill(ds);
                MessageBox.Show(availcount.ToString() + " Books available.");
            }
            
        }

        private void HomeToolStripMenu_Click(object sender, EventArgs e)
        {
             this.Close();
         }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_SearchBy.Clear();
            cb_SearchBy.SelectedIndex = 0;

            dg_SearchResults.DataSource = null;
         
                    
        }
          }
}
