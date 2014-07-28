namespace FinalizedProject
{
    partial class Book_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_BookID = new System.Windows.Forms.Label();
            this.lbl_Book = new System.Windows.Forms.Label();
            this.lbl_Author = new System.Windows.Forms.Label();
            this.lbl_Publisher = new System.Windows.Forms.Label();
            this.l = new System.Windows.Forms.Label();
            this.lbl_TotalStocks = new System.Windows.Forms.Label();
            this.lbl_NumberLended = new System.Windows.Forms.Label();
            this.lbl_Location = new System.Windows.Forms.Label();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.txt_BookName = new System.Windows.Forms.TextBox();
            this.txt_Author = new System.Windows.Forms.TextBox();
            this.txt_Publisher = new System.Windows.Forms.TextBox();
            this.txt_Category = new System.Windows.Forms.TextBox();
            this.txt_TotalStocks = new System.Windows.Forms.TextBox();
            this.txt_NumberLended = new System.Windows.Forms.TextBox();
            this.txt_Location = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btn_oldest = new System.Windows.Forms.Button();
            this.btn_order = new System.Windows.Forms.Button();
            this.btn_Newer = new System.Windows.Forms.Button();
            this.btn_Newest = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_searchBookID = new System.Windows.Forms.TextBox();
            this.lbl_searchBook = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.membersProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booksCatalogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Error = new System.Windows.Forms.Label();
            this.ErrorlblPublisher = new System.Windows.Forms.Label();
            this.ErrorBookName = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_BookID
            // 
            this.lbl_BookID.AutoSize = true;
            this.lbl_BookID.Location = new System.Drawing.Point(66, 37);
            this.lbl_BookID.Name = "lbl_BookID";
            this.lbl_BookID.Size = new System.Drawing.Size(46, 13);
            this.lbl_BookID.TabIndex = 0;
            this.lbl_BookID.Text = "Book ID";
            // 
            // lbl_Book
            // 
            this.lbl_Book.AutoSize = true;
            this.lbl_Book.Location = new System.Drawing.Point(66, 77);
            this.lbl_Book.Name = "lbl_Book";
            this.lbl_Book.Size = new System.Drawing.Size(63, 13);
            this.lbl_Book.TabIndex = 1;
            this.lbl_Book.Text = "Book Name";
            // 
            // lbl_Author
            // 
            this.lbl_Author.AutoSize = true;
            this.lbl_Author.Location = new System.Drawing.Point(66, 117);
            this.lbl_Author.Name = "lbl_Author";
            this.lbl_Author.Size = new System.Drawing.Size(38, 13);
            this.lbl_Author.TabIndex = 2;
            this.lbl_Author.Text = "Author";
            // 
            // lbl_Publisher
            // 
            this.lbl_Publisher.AutoSize = true;
            this.lbl_Publisher.Location = new System.Drawing.Point(66, 161);
            this.lbl_Publisher.Name = "lbl_Publisher";
            this.lbl_Publisher.Size = new System.Drawing.Size(50, 13);
            this.lbl_Publisher.TabIndex = 3;
            this.lbl_Publisher.Text = "Publisher";
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Location = new System.Drawing.Point(66, 202);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(49, 13);
            this.l.TabIndex = 4;
            this.l.Text = "Category";
            // 
            // lbl_TotalStocks
            // 
            this.lbl_TotalStocks.AutoSize = true;
            this.lbl_TotalStocks.Location = new System.Drawing.Point(66, 242);
            this.lbl_TotalStocks.Name = "lbl_TotalStocks";
            this.lbl_TotalStocks.Size = new System.Drawing.Size(67, 13);
            this.lbl_TotalStocks.TabIndex = 5;
            this.lbl_TotalStocks.Text = "Total Stocks";
            // 
            // lbl_NumberLended
            // 
            this.lbl_NumberLended.AutoSize = true;
            this.lbl_NumberLended.Location = new System.Drawing.Point(66, 285);
            this.lbl_NumberLended.Name = "lbl_NumberLended";
            this.lbl_NumberLended.Size = new System.Drawing.Size(83, 13);
            this.lbl_NumberLended.TabIndex = 6;
            this.lbl_NumberLended.Text = "Number Lended";
            // 
            // lbl_Location
            // 
            this.lbl_Location.AutoSize = true;
            this.lbl_Location.Location = new System.Drawing.Point(66, 333);
            this.lbl_Location.Name = "lbl_Location";
            this.lbl_Location.Size = new System.Drawing.Size(48, 13);
            this.lbl_Location.TabIndex = 7;
            this.lbl_Location.Text = "Location";
            // 
            // txtBookID
            // 
            this.txtBookID.Location = new System.Drawing.Point(217, 37);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(166, 20);
            this.txtBookID.TabIndex = 8;
            // 
            // txt_BookName
            // 
            this.txt_BookName.Location = new System.Drawing.Point(217, 77);
            this.txt_BookName.Name = "txt_BookName";
            this.txt_BookName.Size = new System.Drawing.Size(166, 20);
            this.txt_BookName.TabIndex = 9;
            // 
            // txt_Author
            // 
            this.txt_Author.Location = new System.Drawing.Point(217, 117);
            this.txt_Author.Name = "txt_Author";
            this.txt_Author.Size = new System.Drawing.Size(166, 20);
            this.txt_Author.TabIndex = 10;
            // 
            // txt_Publisher
            // 
            this.txt_Publisher.Location = new System.Drawing.Point(217, 161);
            this.txt_Publisher.Name = "txt_Publisher";
            this.txt_Publisher.Size = new System.Drawing.Size(166, 20);
            this.txt_Publisher.TabIndex = 11;
            // 
            // txt_Category
            // 
            this.txt_Category.Location = new System.Drawing.Point(217, 202);
            this.txt_Category.Name = "txt_Category";
            this.txt_Category.Size = new System.Drawing.Size(166, 20);
            this.txt_Category.TabIndex = 12;
            // 
            // txt_TotalStocks
            // 
            this.txt_TotalStocks.Location = new System.Drawing.Point(217, 242);
            this.txt_TotalStocks.Name = "txt_TotalStocks";
            this.txt_TotalStocks.Size = new System.Drawing.Size(166, 20);
            this.txt_TotalStocks.TabIndex = 13;
            // 
            // txt_NumberLended
            // 
            this.txt_NumberLended.Location = new System.Drawing.Point(217, 282);
            this.txt_NumberLended.Name = "txt_NumberLended";
            this.txt_NumberLended.Size = new System.Drawing.Size(166, 20);
            this.txt_NumberLended.TabIndex = 14;
            // 
            // txt_Location
            // 
            this.txt_Location.Location = new System.Drawing.Point(217, 333);
            this.txt_Location.Name = "txt_Location";
            this.txt_Location.Size = new System.Drawing.Size(166, 20);
            this.txt_Location.TabIndex = 15;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 497);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(978, 22);
            this.statusStrip1.TabIndex = 17;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // btn_oldest
            // 
            this.btn_oldest.Location = new System.Drawing.Point(102, 431);
            this.btn_oldest.Name = "btn_oldest";
            this.btn_oldest.Size = new System.Drawing.Size(47, 23);
            this.btn_oldest.TabIndex = 20;
            this.btn_oldest.Text = "<<";
            this.btn_oldest.UseVisualStyleBackColor = true;
            this.btn_oldest.Click += new System.EventHandler(this.btn_oldest_Click);
            // 
            // btn_order
            // 
            this.btn_order.Location = new System.Drawing.Point(177, 431);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(47, 23);
            this.btn_order.TabIndex = 21;
            this.btn_order.Text = "<";
            this.btn_order.UseVisualStyleBackColor = true;
            this.btn_order.Click += new System.EventHandler(this.btn_order_Click);
            // 
            // btn_Newer
            // 
            this.btn_Newer.Location = new System.Drawing.Point(272, 431);
            this.btn_Newer.Name = "btn_Newer";
            this.btn_Newer.Size = new System.Drawing.Size(47, 23);
            this.btn_Newer.TabIndex = 22;
            this.btn_Newer.Text = ">";
            this.btn_Newer.UseVisualStyleBackColor = true;
            this.btn_Newer.Click += new System.EventHandler(this.btn_Newer_Click);
            // 
            // btn_Newest
            // 
            this.btn_Newest.Location = new System.Drawing.Point(358, 431);
            this.btn_Newest.Name = "btn_Newest";
            this.btn_Newest.Size = new System.Drawing.Size(47, 23);
            this.btn_Newest.TabIndex = 23;
            this.btn_Newest.Text = ">>";
            this.btn_Newest.UseVisualStyleBackColor = true;
            this.btn_Newest.Click += new System.EventHandler(this.btn_Newest_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_search);
            this.groupBox1.Controls.Add(this.txt_searchBookID);
            this.groupBox1.Controls.Add(this.lbl_searchBook);
            this.groupBox1.Location = new System.Drawing.Point(587, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 204);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(79, 122);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 17;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_searchBookID
            // 
            this.txt_searchBookID.Location = new System.Drawing.Point(107, 47);
            this.txt_searchBookID.Name = "txt_searchBookID";
            this.txt_searchBookID.Size = new System.Drawing.Size(166, 20);
            this.txt_searchBookID.TabIndex = 9;
            // 
            // lbl_searchBook
            // 
            this.lbl_searchBook.AutoSize = true;
            this.lbl_searchBook.Location = new System.Drawing.Point(42, 50);
            this.lbl_searchBook.Name = "lbl_searchBook";
            this.lbl_searchBook.Size = new System.Drawing.Size(46, 13);
            this.lbl_searchBook.TabIndex = 1;
            this.lbl_searchBook.Text = "Book ID";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemLogout,
            this.membersProfileToolStripMenuItem,
            this.booksCatalogToolStripMenuItem,
            this.searchBookToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(978, 24);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItemLogout
            // 
            this.ToolStripMenuItemLogout.Name = "ToolStripMenuItemLogout";
            this.ToolStripMenuItemLogout.Size = new System.Drawing.Size(60, 20);
            this.ToolStripMenuItemLogout.Text = "Log out";
            this.ToolStripMenuItemLogout.Click += new System.EventHandler(this.ToolStripMenuItemLogout_Click);
            // 
            // membersProfileToolStripMenuItem
            // 
            this.membersProfileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewProfileToolStripMenuItem,
            this.editProfileToolStripMenuItem});
            this.membersProfileToolStripMenuItem.Name = "membersProfileToolStripMenuItem";
            this.membersProfileToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.membersProfileToolStripMenuItem.Text = "Members Profile";
            // 
            // createNewProfileToolStripMenuItem
            // 
            this.createNewProfileToolStripMenuItem.Name = "createNewProfileToolStripMenuItem";
            this.createNewProfileToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.createNewProfileToolStripMenuItem.Text = "Create New Profile";
            this.createNewProfileToolStripMenuItem.Click += new System.EventHandler(this.createNewProfileToolStripMenuItem_Click);
            // 
            // editProfileToolStripMenuItem
            // 
            this.editProfileToolStripMenuItem.Name = "editProfileToolStripMenuItem";
            this.editProfileToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.editProfileToolStripMenuItem.Text = "Edit Profile";
            this.editProfileToolStripMenuItem.Click += new System.EventHandler(this.editProfileToolStripMenuItem_Click);
            // 
            // booksCatalogToolStripMenuItem
            // 
            this.booksCatalogToolStripMenuItem.Name = "booksCatalogToolStripMenuItem";
            this.booksCatalogToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.booksCatalogToolStripMenuItem.Text = "Transaction";
            this.booksCatalogToolStripMenuItem.Click += new System.EventHandler(this.booksCatalogToolStripMenuItem_Click);
            // 
            // searchBookToolStripMenuItem
            // 
            this.searchBookToolStripMenuItem.Name = "searchBookToolStripMenuItem";
            this.searchBookToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.searchBookToolStripMenuItem.Text = "Search_Book";
            this.searchBookToolStripMenuItem.Click += new System.EventHandler(this.searchBookToolStripMenuItem_Click);
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(69, 378);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(75, 23);
            this.btn_Insert.TabIndex = 16;
            this.btn_Insert.Text = "Insert";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(217, 378);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 18;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(375, 378);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 19;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(436, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(436, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Number Lended";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(436, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Total Stocks";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(436, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Category";
            // 
            // Error
            // 
            this.Error.AutoSize = true;
            this.Error.ForeColor = System.Drawing.Color.Red;
            this.Error.Location = new System.Drawing.Point(436, 161);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(50, 13);
            this.Error.TabIndex = 28;
            this.Error.Text = "Publisher";
            // 
            // ErrorlblPublisher
            // 
            this.ErrorlblPublisher.AutoSize = true;
            this.ErrorlblPublisher.ForeColor = System.Drawing.Color.Red;
            this.ErrorlblPublisher.Location = new System.Drawing.Point(436, 117);
            this.ErrorlblPublisher.Name = "ErrorlblPublisher";
            this.ErrorlblPublisher.Size = new System.Drawing.Size(0, 13);
            this.ErrorlblPublisher.TabIndex = 27;
            // 
            // ErrorBookName
            // 
            this.ErrorBookName.AutoSize = true;
            this.ErrorBookName.ForeColor = System.Drawing.Color.Red;
            this.ErrorBookName.Location = new System.Drawing.Point(436, 77);
            this.ErrorBookName.Name = "ErrorBookName";
            this.ErrorBookName.Size = new System.Drawing.Size(0, 13);
            this.ErrorBookName.TabIndex = 26;
            // 
            // Book_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 519);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Error);
            this.Controls.Add(this.ErrorlblPublisher);
            this.Controls.Add(this.ErrorBookName);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Newest);
            this.Controls.Add(this.btn_Newer);
            this.Controls.Add(this.btn_order);
            this.Controls.Add(this.btn_oldest);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.txt_Location);
            this.Controls.Add(this.txt_NumberLended);
            this.Controls.Add(this.txt_TotalStocks);
            this.Controls.Add(this.txt_Category);
            this.Controls.Add(this.txt_Publisher);
            this.Controls.Add(this.txt_Author);
            this.Controls.Add(this.txt_BookName);
            this.Controls.Add(this.txtBookID);
            this.Controls.Add(this.lbl_Location);
            this.Controls.Add(this.lbl_NumberLended);
            this.Controls.Add(this.lbl_TotalStocks);
            this.Controls.Add(this.l);
            this.Controls.Add(this.lbl_Publisher);
            this.Controls.Add(this.lbl_Author);
            this.Controls.Add(this.lbl_Book);
            this.Controls.Add(this.lbl_BookID);
            this.Name = "Book_form";
            this.Text = "Book_form";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_BookID;
        private System.Windows.Forms.Label lbl_Book;
        private System.Windows.Forms.Label lbl_Author;
        private System.Windows.Forms.Label lbl_Publisher;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.Label lbl_TotalStocks;
        private System.Windows.Forms.Label lbl_NumberLended;
        private System.Windows.Forms.Label lbl_Location;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.TextBox txt_BookName;
        private System.Windows.Forms.TextBox txt_Author;
        private System.Windows.Forms.TextBox txt_Publisher;
        private System.Windows.Forms.TextBox txt_Category;
        private System.Windows.Forms.TextBox txt_TotalStocks;
        private System.Windows.Forms.TextBox txt_NumberLended;
        private System.Windows.Forms.TextBox txt_Location;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btn_oldest;
        private System.Windows.Forms.Button btn_order;
        private System.Windows.Forms.Button btn_Newer;
        private System.Windows.Forms.Button btn_Newest;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_searchBookID;
        private System.Windows.Forms.Label lbl_searchBook;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemLogout;
        private System.Windows.Forms.ToolStripMenuItem membersProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem booksCatalogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchBookToolStripMenuItem;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Error;
        private System.Windows.Forms.Label ErrorlblPublisher;
        private System.Windows.Forms.Label ErrorBookName;
    }
}