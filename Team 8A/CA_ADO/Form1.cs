using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Test_for_Project
{
    public partial class Frm_Search : Form
    {
        public Frm_Search()
        {
            InitializeComponent();
            cmb_Search.SelectedIndex = 0;
            dtg_SearchResults.Visible = false;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {

        }
    }
}
