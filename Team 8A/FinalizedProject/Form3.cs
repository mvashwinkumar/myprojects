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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        //
        //Customer ID Button
        //
        string constring = "data source=(local);initial catalog=Library;Integrated Security=SSPI";
        private void CustomerInfo_button_Click(object sender, EventArgs e)
        {
            LibraryEntities6 lib = new LibraryEntities6();
            var cidcheck = (from cid in lib.Members where cid.MemberID == CustomerID_textbox.Text select cid).ToList();
            Member members = cidcheck.FirstOrDefault<Member>();
            if (members != null)
            {
                CustomerInfo_view.DataSource = cidcheck;
                toolStripStatusLabel1.Text = ("Member:\t\t" + members.MemberName + "\t's detail");
            }
            else
            {
                MessageBox.Show("pls enter right Member ID");
            }
        }
        //
        //Retrieve Book @ lend
        //
        private void RetrieveBook_button1_Click(object sender, EventArgs e)
        {
            LibraryEntities6 lib = new LibraryEntities6();
            var bookcheck = (from b in lib.Books where b.BookID == BookID_textBox1.Text select b).ToList();
            Book books = bookcheck.FirstOrDefault<Book>();
            if (books != null)
            {
                Book_dataGridView1.DataSource = bookcheck;
                toolStripStatusLabel1.Text = ("Book:\t" + books.BookName + "\t's detail");
            }
            else
            {
                MessageBox.Show("pls enter right Book ID");    
            }
        }
        //
        //show members lend status
        //
        private void Status_button_Click(object sender, EventArgs e)
        {
            LibraryEntities6 lib = new LibraryEntities6();
            var statuscheck = (from sc in lib.Trans where sc.MemberID == CustomerID_textbox.Text && sc.Status == "In" select sc).ToList();
            Tran tran = statuscheck.FirstOrDefault<Tran>();
            Tran t = new Tran();
            if (statuscheck != null)
            {
                Status_view.DataSource = statuscheck;
                toolStripStatusLabel1.Text = ("Member:\t\t" + t.MemberID + "\t's detail");
            }
             
            else
            {
                MessageBox.Show("pls check your Member ID again");
            }
        }
       
        //
        //generate Transaction ID automatically
        //
        public string generateTransactionID()
        {
            LibraryEntities6 lib = new LibraryEntities6();
            string num = null;
            var tran = from t in lib.Trans orderby t.TransactionID descending select t.TransactionID;
            foreach (var i in tran)
            {
                num = i.Trim();
                break;
            }
            int oringinaltextnum = num.ToString().Length-1;
            string TID = num.Substring(1, oringinaltextnum);
            int temp = Convert.ToInt32(TID) + 1;
            TID = "T" + temp.ToString();
            return TID;
        }
        //
        //loan button
        //
        private void Loan_button_Click(object sender, EventArgs e)
        {
            
            LibraryEntities6 lib = new LibraryEntities6();
            var tr = from t in lib.Trans where t.BookID == BookID_textBox1.Text && t.MemberID == CustomerID_textbox.Text select t;
            var update = (from o in lib.Books where o.BookID == BookID_textBox1.Text select o).FirstOrDefault();
            Tran tran = new Tran();
            Book books = new Book();
            //if (update.NumberLended < update.TotalStock && status_comboBox.SelectedItem != null)
            if (update.NumberLended < update.TotalStock)  
            {
                    tran.TransactionID = generateTransactionID();
                    tran.BookID = BookID_textBox1.Text;
                    tran.MemberID = CustomerID_textbox.Text;
                    tran.IssueDate = DateTime.Now.ToLocalTime();
                    tran.DueDate = Convert.ToDateTime(dateTimePicker1.Value.ToShortDateString());
                    tran.Status = "In";
                    tran.Remarks = "OK";
                    lib.SaveChanges();
                    update.NumberLended++;
                    lib.Trans.AddObject(tran);
                    lib.SaveChanges();
                    toolStripStatusLabel1.Text = "lend book successful";
                }
                else
                {
                    MessageBox.Show(update.BookName + "\nis no more! \nyou cannot lend! \nplease ask later!");
                }
            findValidData();
        }
        //
        //Return Book
        //
        public void findValidData()
        {
            SqlConnection con = new SqlConnection(constring);
            SqlCommand cmd = new SqlCommand("select count(TransactionID) from [tran] where MemberId='" + CustomerID_textbox + "'and status ='out' group by memberid", con);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            int count = ds.Tables[0].Rows.Count;
            con.Close();
            MessageBox.Show(count.ToString());
        }         
        private void Return_button_Click(object sender, EventArgs e)
        {
            LibraryEntities6 lib = new LibraryEntities6();
            //var retu = from r in lib.Tran where r.BookID == BookID_textBox1.Text && r.MemberID == CustomerID_textbox.Text select r;
            var delete = (from d in lib.Books where d.BookID == BookID_textBox2.Text select d).FirstOrDefault();
            var searchtid = (from stid in lib.Trans where stid.TransactionID == TransactionID_textBox.Text select stid).FirstOrDefault();
            Tran tran = new Tran();
            Book books = new Book();
            if (TransactionID_textBox != null)
            {
                if (searchtid.TransactionID == TransactionID_textBox.Text)
                {
                    if (delete.NumberLended >= 0)
                    {
                        searchtid.Status = "Out";
                        searchtid.Remarks = "Checked Out";
                        searchtid.ReturnDate = DateTime.Now.ToLocalTime();
                        lib.SaveChanges();
                        delete.NumberLended--;
                        lib.SaveChanges();
                        toolStripStatusLabel1.Text = "Return book successful";
                        BookID_textBox2.Clear();
                        TransactionID_textBox.Clear();
                        Book_dataGridView2.ClearSelection();
                    }
                }
            }
        }
        //
        //Retrieve Book @ return
        //
        private void button2_Click(object sender, EventArgs e)
        {
            LibraryEntities6 lib = new LibraryEntities6();
            var bookcheck = (from b in lib.Books where b.BookID == BookID_textBox2.Text select b).ToList();
            Book books = bookcheck.FirstOrDefault<Book>();
            if (books != null)
            {
                Book_dataGridView2.DataSource = bookcheck;
                toolStripStatusLabel1.Text = ("Book:\t" + books.BookName + "\t's detail");
            }
            else
            {
                MessageBox.Show("pls enter right Book ID");
            }
        }
          private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_Login frm = new Form_Login();
        }

        private void createNewProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Member_Form mf = new Member_Form(true);
            this.Close();
            mf.ShowDialog();

        }

        private void editProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Member_Form mf = new Member_Form();
            this.Close();
            mf.ShowDialog();
        }

        private void createBookProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Book_form bf = new Book_form(true);
            this.Close();
            bf.ShowDialog();
        }

        private void editProfileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Book_form bf = new Book_form();
            this.Close();
            bf.ShowDialog();
        }

        private void searchBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchBooks sr = new SearchBooks();
            this.Close();
            sr.ShowDialog();
        }
    } 
}
