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
        public Form_Login()
        {
            InitializeComponent();         
        }
               
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            LibraryEntities6 lib = new LibraryEntities6();
            var check = from o in lib.Staffs where o.StaffID == txt_StaffID.Text && o.StaffPassword == txt_Password.Text select o;
            Staff staff = check.FirstOrDefault<Staff>();
            if (staff != null)
            {
               
               Form2 main = new Form2( staff.StaffName);
               txt_Password.Clear();
               txt_StaffID.Clear();
               txt_StaffID.Select();
               main.ShowDialog();
            }
            else
            {
                MessageBox.Show("pls enter right Staff ID and Password!!!");
            }

            }

        private void Form_Login_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_StaffID.Text = "";
            txt_Password.Text = "";
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            txt_StaffID.Text = "";
            txt_Password.Text = "";
            SearchBooks searchBooks = new SearchBooks();
            searchBooks.ShowDialog();
        }

       
       
    }
}
