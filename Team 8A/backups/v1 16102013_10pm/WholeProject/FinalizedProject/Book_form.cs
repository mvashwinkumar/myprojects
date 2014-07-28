//Written by AUNG PAING PHYO

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
    public partial class Book_form : Form
    {
        bool insert = false;
        public Book_form()
        {
            InitializeComponent();
            selectData();
            btn_oldest.Enabled = false;
            btn_order.Enabled = false;
        }
        
        private void btn_Insert_Click(object sender, EventArgs e)
        {
            if (insert == false)
            {
                txtBookID.Text = generateBookID();
                txt_Author.Clear();
                txt_BookName.Clear();
                txt_Category.Clear();
                txt_Location.Clear();
                txt_NumberLended.Clear();
                txt_Publisher.Clear();
                txt_TotalStocks.Clear();
                txtBookID.Enabled = false;
                btn_delete.Enabled = false;
                btn_Update.Enabled = false;
                insert = true;
            }
            else
            {
                LibraryEntities6 lbe = new LibraryEntities6();
                Book b = new Book();
                b.BookID = txtBookID.Text.Trim();
                b.BookName = txt_BookName.Text.Trim();
                b.Author = txt_Author.Text.Trim();
                b.Publisher = txt_Publisher.Text.Trim();
                b.Category = txt_Category.Text.Trim();
                b.TotalStock = Convert.ToInt32(txt_TotalStocks.Text.Trim());
                b.NumberLended = Convert.ToInt32(txt_NumberLended.Text.Trim());
                b.Location = txt_Location.Text.Trim();
                lbe.Books.AddObject(b);
                lbe.SaveChanges();
                toolStripStatusLabel1.Text = "Data inserting process is successful";
                btn_delete.Enabled = true;
                btn_Update.Enabled = true;
                btn_oldest.Enabled = true;
                btn_order.Enabled = true;
                btn_Newer.Enabled = false;
                insert = false;
            }
         }
                
       private void btn_Update_Click(object sender, EventArgs e)
        {
            LibraryEntities6 lbe = new LibraryEntities6();
            var update = (from o in lbe.Books where o.BookID == txtBookID.Text.Trim() select o).FirstOrDefault();
            update.BookID = txtBookID.Text.Trim();
            update.BookName = txt_BookName.Text.Trim();
            update.Author = txt_Author.Text.Trim();
            update.Publisher = txt_Publisher.Text.Trim();
            update.Category = txt_Category.Text.Trim();
            update.TotalStock = Convert.ToInt32(txt_TotalStocks.Text.Trim());
            update.NumberLended = Convert.ToInt32(txt_NumberLended.Text.Trim());
            update.Location = txt_Location.Text.Trim();
            lbe.SaveChanges();
            toolStripStatusLabel1.Text = "Data Updating process is successful";
                
        }

        private void btn_oldest_Click(object sender, EventArgs e)
        {
            selectData();
            btn_order.Enabled = false;
            btn_Newer.Enabled = true;
            toolStripStatusLabel1.Text = "This is Oldest Data";
        }

        private void btn_Newest_Click(object sender, EventArgs e)
        {
            LibraryEntities6 lbe = new LibraryEntities6();
            string num = null;
            var text = from o in lbe.Books orderby o.BookID descending select o.BookID;
            foreach (var i in text)
            {
                num = i.Trim();
                break;
            } 
            var select_firData = from o in lbe.Books where o.BookID == num select o;
            foreach (var i in select_firData)
            {
                txtBookID.Text = i.BookID.ToString();
                txt_BookName.Text = i.BookName.ToString();
                txt_Author.Text = i.Author.ToString();
                txt_Publisher.Text = i.Publisher.ToString();
                txt_Category.Text = i.Category.ToString();
                txt_TotalStocks.Text = i.TotalStock.ToString();
                txt_NumberLended.Text = i.NumberLended.ToString();
                txt_Location.Text = i.Location.ToString();

            }
            toolStripStatusLabel1.Text = "The Newest Data";
            btn_Newer.Enabled = false;
            btn_order.Enabled = true;
            btn_oldest.Enabled = true;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            LibraryEntities6 lbe = new LibraryEntities6();
            var delete = (from o in lbe.Books where o.BookID == txtBookID.Text.Trim() select o).FirstOrDefault();
            lbe.Books.DeleteObject(delete);
            lbe.SaveChanges();
            toolStripStatusLabel1.Text = "Data Deleting process is success";
            selectData();
        }

        //GenerateBookID
        public string generateBookID()
        {
            LibraryEntities6 lbe = new LibraryEntities6();
            string num = null;
            var text = from o in lbe.Books orderby o.BookID descending select o.BookID;
            foreach (var i in text)
            {
                num = i.Trim();
                break;
            }
            string bookID = num.Substring(1, 3);
            int temp = Convert.ToInt32(bookID) + 1;
            if (temp < 10)
                bookID = "B00" + temp.ToString();
            else if (temp < 100)
                bookID = "B0" + temp.ToString();
            return bookID;
        }

        //Select first Data From DataBase
        public void selectData()
        {
            LibraryEntities6 lbe = new LibraryEntities6();
            var select_firData = (from o in lbe.Books select o).Take(1);
            foreach (var i in select_firData)
            {
                txtBookID.Text = i.BookID.ToString();
                txt_BookName.Text = i.BookName.ToString();
                txt_Author.Text = i.Author.ToString();
                txt_Publisher.Text = i.Publisher.ToString();
                txt_Category.Text = i.Category.ToString();
                txt_TotalStocks.Text = i.TotalStock.ToString();
                txt_NumberLended.Text = i.NumberLended.ToString();
                txt_Location.Text = i.Location.ToString();
            }
            btn_order.Enabled = false;
            btn_oldest.Enabled = false;
            btn_Newer.Enabled = true;
            btn_Newest.Enabled = true;
        }

        private void btn_Newer_Click(object sender, EventArgs e)
        {
            LibraryEntities6 lbe = new LibraryEntities6();
            int index = 1; bool stop = false; string virtual_bookID = null; string last_id = null;
            var first = from o in lbe.Books orderby o.BookID descending select o.BookID;
            foreach (var i in first)
            {
                last_id = i.ToString();
                break;
            }
            do
            {
                virtual_bookID = addBookid(index);
                var text = from o in lbe.Books where o.BookID == virtual_bookID select o;
                foreach (var i in text)
                {
                    if (i.BookID != "")
                    {
                        txtBookID.Text = i.BookID.ToString();
                        txt_BookName.Text = i.BookName.ToString();
                        txt_Author.Text = i.Author.ToString();
                        txt_Publisher.Text = i.Publisher.ToString();
                        txt_Category.Text = i.Category.ToString();
                        txt_TotalStocks.Text = i.TotalStock.ToString();
                        txt_NumberLended.Text = i.NumberLended.ToString();
                        txt_Location.Text = i.Location.ToString();
                        stop = true;
                        if (last_id == i.BookID.ToString())
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

        public string addBookid(int i)
        {
            string num = txtBookID.Text.Trim().Substring(1, 3);
            int temp = Convert.ToInt32(num) + i;
            if (temp < 10)
                num = "B00" + temp.ToString();
            else if (temp < 100)
                num = "B0" + temp.ToString();
            return num;
        }

        private void btn_order_Click(object sender, EventArgs e)
        {
           
             LibraryEntities6 lbe = new LibraryEntities6();
             int index = 1; bool stop = false; string virtual_bookID = null; string first_id = null;
             var first = (from o in lbe.Books select o).Take(1);
             foreach (var i in first)
             {
                 first_id = i.BookID.ToString();
             }
            do
            {
                virtual_bookID = subbookid(index);
                var text = from o in lbe.Books where o.BookID ==virtual_bookID  select o;
                foreach (var i in text)
                {
                    if (i.BookID != "")
                    {
                        txtBookID.Text = i.BookID.ToString();
                        txt_BookName.Text = i.BookName.ToString();
                        txt_Author.Text = i.Author.ToString();
                        txt_Publisher.Text = i.Publisher.ToString();
                        txt_Category.Text = i.Category.ToString();
                        txt_TotalStocks.Text = i.TotalStock.ToString();
                        txt_NumberLended.Text = i.NumberLended.ToString();
                        txt_Location.Text = i.Location.ToString();
                        stop = true;
                        if (first_id == i.BookID.ToString())
                        {
                            btn_oldest.Enabled = false;
                            btn_order.Enabled = false;

                        }
                    }
                   else
                    {
                        btn_order.Enabled = false;
                    }
                    
                }
                index++;
            } while (stop != true   );
            btn_Newer.Enabled = true;
            btn_Newest.Enabled = true;
        }

        public string subbookid(int i)
        {
            string num = txtBookID.Text.Trim().Substring(1, 3);
            int temp = Convert.ToInt32(num) - i;
            if (temp < 10)
                num = "B00" + temp.ToString();
            else if (temp < 100)
                num = "B0" + temp.ToString();
            return num;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string text = txt_searchBookID.Text.ToString();
            LibraryEntities6 lbl = new LibraryEntities6();
            string first_data = null; string last_data = null; 
            var lasttemp_data = (from o in lbl.Books orderby o.BookID descending select o.BookID).Take(1);
            foreach (var i in lasttemp_data)
            {
                last_data = i.ToString();
            }
            var firsttemp_data = (from o in lbl.Books select o.BookID).Take(1);
            foreach (var i in firsttemp_data)
            {
                first_data = i.ToString();
            }
            var command = from o in lbl.Books where o.BookID == txt_searchBookID.Text.Trim() select o;
            bool match = false;
            foreach (var i in command)
            {
                if (i.BookID != null)
                {
                    txtBookID.Text = i.BookID.ToString();
                    txt_BookName.Text = i.BookName.ToString();
                    txt_Author.Text = i.Author.ToString();
                    txt_Publisher.Text = i.Publisher.ToString();
                    txt_Category.Text = i.Category.ToString();
                    txt_TotalStocks.Text = i.TotalStock.ToString();
                    txt_NumberLended.Text = i.NumberLended.ToString();
                    txt_Location.Text = i.Location.ToString();
                    match = true;
                    if (i.BookID == first_data)
                    {
                        btn_oldest.Enabled = false;
                        btn_order.Enabled = false;
                        btn_Newest.Enabled = true;
                        btn_Newer.Enabled = true;
                    }
                    else if (i.BookID == last_data)
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
                
            }
            if (match == false)
            {
                toolStripStatusLabel1.Text = "No Match Data";
            }

        }
           
            }
}
