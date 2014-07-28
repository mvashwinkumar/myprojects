using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FinalizedProject
{
    public partial class Member_Form : Form
    {
        bool insert = false;
        public Member_Form()
        {
            InitializeComponent();
            selectData();
            btn_oldest.Enabled = false;
            btn_order.Enabled = false;
            txt_MemberID.Enabled = false;
        }
        public Member_Form(bool i)
        {
            InitializeComponent();
            if (i == true)
            {
                txt_MemberID.Text = generateMemberID();
                insert = true;
                txt_MemberID.Enabled = false;
            }
        }
        private void btn_Insert_Click(object sender, EventArgs e)
        {
            if (insert == false)
            {
               txt_MemberID.Text = generateMemberID();
                txt_Address.Clear();
                txt_MemberName.Clear();
                txt_PhoneNumber.Clear();
                txt_MemberID.Enabled = false;
                btn_delete.Enabled = false;
                btn_Update.Enabled = false;
                insert = true;
            }
            else
            {
                InsertData();
                insert = false;
            }
        }

        public void InsertData()
        {
            LibraryEntities6 lbe = new LibraryEntities6();
            Member m = new Member();
            m.MemberID = txt_MemberID.Text.Trim();
            m.MemberName = txt_MemberName.Text.Trim();
            m.PhoneNumber = txt_PhoneNumber.Text.Trim();
            m.Address = txt_Address.Text.Trim();
            lbe.Members.AddObject(m);
            lbe.SaveChanges();
            toolStripStatusLabel1.Text = "Data inserting process is successful";
            btn_delete.Enabled = true;
            btn_Update.Enabled = true;

        }

        public void selectData()
        {
            LibraryEntities6 lbe = new LibraryEntities6();
            var select_firstData = (from o in lbe.Members select o).Take(1);
            foreach (var i in select_firstData)
            {
                txt_MemberID.Text = i.MemberID.ToString();
                txt_MemberName.Text = i.MemberName.ToString();
                txt_PhoneNumber.Text = i.PhoneNumber.ToString();
                txt_Address.Text = i.Address.ToString();
            }
        }

        public string generateMemberID()
        {
            LibraryEntities6 lbe = new LibraryEntities6();
            string num = null;
            var text = from o in lbe.Members orderby o.MemberID descending select o.MemberID;
            foreach (var i in text)
            {
                num = i.Trim();
                break;
            }
            
            string MemberID = num.Substring(1, 3);
            int temp = Convert.ToInt32(MemberID) + 1;
            if (temp < 10)
                MemberID = "M00" + temp.ToString();
            else if (temp < 100)
                MemberID = "M0" + temp.ToString();
            

            return MemberID;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            LibraryEntities6 lbe = new LibraryEntities6();
            var delete = (from o in lbe.Members where o.MemberID ==txt_MemberID.Text.Trim() select o).FirstOrDefault();
            lbe.Members.DeleteObject(delete);
            lbe.SaveChanges();
            toolStripStatusLabel1.Text = "Data Deleting process is success";
            selectData();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            LibraryEntities6 lbe = new LibraryEntities6();
            var update = (from o in lbe.Members where o.MemberID == txt_MemberID.Text.Trim() select o).FirstOrDefault();
            update.MemberID = txt_MemberID.Text.Trim();
            update.MemberName = txt_MemberName.Text.Trim();
            update.PhoneNumber = txt_PhoneNumber.Text.Trim();
            update.Address = txt_Address.Text.Trim();
            lbe.SaveChanges();
            toolStripStatusLabel1.Text = "Data Updating process is successful";
        }

        private void btn_oldest_Click(object sender, EventArgs e)
        {
            selectData();
            btn_order.Enabled = false;
            btn_Newer.Enabled = true;
            toolStripStatusLabel1.Text = "The First Data";

        }

        private void btn_Newest_Click(object sender, EventArgs e)
        {
            LibraryEntities6 lbe = new LibraryEntities6();
            string num = null;
            var text = from o in lbe.Members orderby o.MemberID descending select o.MemberID;
            foreach (var i in text)
            {
                num = i.Trim();
                break;
            }
            var select_firstData = from o in lbe.Members where o.MemberID == num select o;
            foreach (var i in select_firstData)
            {
                txt_MemberID.Text = i.MemberID.ToString();
                txt_MemberName.Text = i.MemberName.ToString();
                txt_PhoneNumber.Text = i.PhoneNumber.ToString();
                txt_Address.Text = i.Address.ToString();
            }
            toolStripStatusLabel1.Text = "The Last Data";
            btn_Newer.Enabled = false;
            btn_order.Enabled = true;
            btn_oldest.Enabled = true;
        }

        private void btn_order_Click(object sender, EventArgs e)
        {
            LibraryEntities6 lbe = new LibraryEntities6();
            int index = 1; bool stop = false; string virtual_memberID = null; string first_id = null;
            var first = (from o in lbe.Members select o).Take(1);
            foreach (var i in first)
            {
                first_id = i.MemberID.ToString();
            }
            do{
                virtual_memberID=submemberid(index);
                var text=from o in lbe.Members where o.MemberID==virtual_memberID select o;
                foreach(var i in text)
                {
                    if(i.MemberID!="")
                    {
                        txt_MemberID.Text=i.MemberID.ToString();
                        txt_MemberName.Text=i.MemberName.ToString();
                        txt_PhoneNumber.Text=i.PhoneNumber.ToString();
                        txt_Address.Text=i.Address.ToString();
                        stop=true;
                        if(first_id==i.MemberID)
                        {
                            btn_order.Enabled=false;
                            btn_oldest.Enabled=false;
                        }
                    }
                    else
                    {
                        btn_order.Enabled=false;
                    }
              }
                index++;
            }while(stop!=true);
            btn_Newer.Enabled = true;
            btn_Newest.Enabled = true;
        }

        public string submemberid(int i)
        {
            string num = txt_MemberID.Text.Trim().Substring(1, 3);
            int temp = Convert.ToInt32(num) - i;
            if (temp < 10)
                num = "M00" + temp.ToString();
            else if (temp < 100)
                num = "B0" + temp.ToString();
            return num;
        }

        private void btn_Newer_Click(object sender, EventArgs e)
        {
            LibraryEntities6 lbe = new LibraryEntities6();
            int index = 1; bool stop = false; string virtual_memberID = null; string last_id = null;
            var first = from o in lbe.Members orderby o.MemberID descending select o.MemberID;
            foreach (var i in first)
            {
                last_id = i.ToString();
                break;
             }
            do
            {
                virtual_memberID = addMemberid(index);
                var text = from o in lbe.Members where o.MemberID == virtual_memberID select o;
                foreach (var i in text)
                {
                    if (i.MemberID != "")
                    {
                        txt_MemberID.Text = i.MemberID.ToString();
                        txt_MemberName.Text = i.MemberName.ToString();
                        txt_PhoneNumber.Text = i.PhoneNumber.ToString();
                        txt_Address.Text = i.Address.ToString();
                        stop = true;
                        if (last_id == i.MemberID.ToString())
                        {
                            btn_Newer.Enabled = false;
                            btn_Newest.Enabled = false;
                        }
                        btn_oldest.Enabled = true;
                        btn_order.Enabled = true;
                    }
                    else
                    {
                        btn_Newer.Enabled = false;
                    }
                    
                }
                index++;
            } while (stop != true);

        }

        public string addMemberid(int i)
        {
            string num = txt_MemberID.Text.Trim().Substring(1, 3);
            int temp = Convert.ToInt32(num) + i;
            if (temp < 10)
                num = "M00" + temp.ToString();
            else if (temp < 100)
                num = "M0" + temp.ToString();
            return num;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string text = txt_searchMemberID.Text.ToString();
            LibraryEntities6 lbl = new LibraryEntities6();
            string first_data = null; string last_data = null;
            var lasttemp_data = (from o in lbl.Members orderby o.MemberID descending select o.MemberID).Take(1);
            foreach (var i in lasttemp_data)
            {
                last_data = i.ToString();
            }
            var firsttemp_data = (from o in lbl.Members select o.MemberID).Take(1);
            foreach (var i in firsttemp_data)
            {
                first_data = i.ToString();
            }
            var command = from o in lbl.Members where o.MemberID == txt_searchMemberID.Text.Trim() select o;
            bool match = false;
            foreach (var i in command)
            {
                txt_MemberID.Text = i.MemberID.ToString();
                txt_MemberName.Text = i.MemberName.ToString();
                txt_PhoneNumber.Text = i.PhoneNumber.ToString();
                txt_Address.Text = i.Address.ToString();
                match = true;
                if (i.MemberID == first_data)
                {
                    btn_oldest.Enabled = false;
                    btn_order.Enabled = false;
                    btn_Newest.Enabled = true;
                    btn_Newer.Enabled = true;
                 }
                else if (i.MemberID == last_data)
                {
                    btn_Newer.Enabled = false;
                    btn_Newest.Enabled = false;
                    btn_order.Enabled = true;
                    btn_oldest.Enabled = true;
                }
                else
                {
                    btn_Newer.Enabled = true;
                    btn_Newest.Enabled = true;
                    btn_order.Enabled = true;
                    btn_oldest.Enabled = true;
                }
            }
            if (match == false)
            {
                toolStripStatusLabel1.Text = "No Match Data";
            }
        }

        private void ToolStripMenuItemLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_Login fc = new Form_Login();

        }

        private void TransactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 trn = new Form3();
            this.Close();
            trn.ShowDialog();

        }

        private void searchBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchBooks sr = new SearchBooks();
            this.Close();
            sr.ShowDialog();
        }

        private void createNewInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Book_form bf = new Book_form(true);
            this.Close();
            bf.ShowDialog();
        }

        private void editBookInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Book_form bf = new Book_form();
            this.Close();
            bf.ShowDialog();
        }

           
        
      }
}
