using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalizedProject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(string s)
        {
            InitializeComponent();
       lbl_showData.Text += s;
        }

        private void Transaction_button_Click(object sender, EventArgs e)
        {
            this.Close();
            Form3 form3 = new Form3();

            form3.ShowDialog();
            
        }

        private void Maintance_button_Click(object sender, EventArgs e)
        {
          
            this.Close();
            Book_form memb = new Book_form();
            memb.ShowDialog();
        }

        //Maintaincnent member click
          private void button1_Click(object sender, EventArgs e)
        {
            Member_Form memb = new Member_Form();
            this.Close();
            memb.ShowDialog();
        }

         private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
          {
             this.Close();
                         
          }

            }
}
