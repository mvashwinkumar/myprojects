namespace FinalizedProject
{
    partial class Member_Form
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
            this.lbl_MemberID = new System.Windows.Forms.Label();
            this.lbl_MemberName = new System.Windows.Forms.Label();
            this.lbl_PhoneNumber = new System.Windows.Forms.Label();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.txt_MemberID = new System.Windows.Forms.TextBox();
            this.txt_MemberName = new System.Windows.Forms.TextBox();
            this.txt_PhoneNumber = new System.Windows.Forms.TextBox();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btn_Newest = new System.Windows.Forms.Button();
            this.btn_Newer = new System.Windows.Forms.Button();
            this.btn_order = new System.Windows.Forms.Button();
            this.btn_oldest = new System.Windows.Forms.Button();
            this.gb_search = new System.Windows.Forms.GroupBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_searchMemberID = new System.Windows.Forms.TextBox();
            this.lbl_searchMemberID = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.gb_search.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_MemberID
            // 
            this.lbl_MemberID.AutoSize = true;
            this.lbl_MemberID.Location = new System.Drawing.Point(70, 46);
            this.lbl_MemberID.Name = "lbl_MemberID";
            this.lbl_MemberID.Size = new System.Drawing.Size(56, 13);
            this.lbl_MemberID.TabIndex = 0;
            this.lbl_MemberID.Text = "MemberID";
            // 
            // lbl_MemberName
            // 
            this.lbl_MemberName.AutoSize = true;
            this.lbl_MemberName.Location = new System.Drawing.Point(70, 90);
            this.lbl_MemberName.Name = "lbl_MemberName";
            this.lbl_MemberName.Size = new System.Drawing.Size(76, 13);
            this.lbl_MemberName.TabIndex = 1;
            this.lbl_MemberName.Text = "Member Name";
            // 
            // lbl_PhoneNumber
            // 
            this.lbl_PhoneNumber.AutoSize = true;
            this.lbl_PhoneNumber.Location = new System.Drawing.Point(70, 143);
            this.lbl_PhoneNumber.Name = "lbl_PhoneNumber";
            this.lbl_PhoneNumber.Size = new System.Drawing.Size(78, 13);
            this.lbl_PhoneNumber.TabIndex = 2;
            this.lbl_PhoneNumber.Text = "Phone Number";
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Location = new System.Drawing.Point(70, 196);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(45, 13);
            this.lbl_Address.TabIndex = 3;
            this.lbl_Address.Text = "Address";
            // 
            // txt_MemberID
            // 
            this.txt_MemberID.Location = new System.Drawing.Point(226, 46);
            this.txt_MemberID.Name = "txt_MemberID";
            this.txt_MemberID.Size = new System.Drawing.Size(136, 20);
            this.txt_MemberID.TabIndex = 4;
            // 
            // txt_MemberName
            // 
            this.txt_MemberName.Location = new System.Drawing.Point(226, 83);
            this.txt_MemberName.Name = "txt_MemberName";
            this.txt_MemberName.Size = new System.Drawing.Size(136, 20);
            this.txt_MemberName.TabIndex = 5;
            // 
            // txt_PhoneNumber
            // 
            this.txt_PhoneNumber.Location = new System.Drawing.Point(226, 143);
            this.txt_PhoneNumber.Name = "txt_PhoneNumber";
            this.txt_PhoneNumber.Size = new System.Drawing.Size(136, 20);
            this.txt_PhoneNumber.TabIndex = 6;
            // 
            // txt_Address
            // 
            this.txt_Address.Location = new System.Drawing.Point(226, 196);
            this.txt_Address.Multiline = true;
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(140, 34);
            this.txt_Address.TabIndex = 7;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(350, 253);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 22;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(192, 253);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 21;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(44, 253);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(75, 23);
            this.btn_Insert.TabIndex = 20;
            this.btn_Insert.Text = "Insert";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 439);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(791, 22);
            this.statusStrip1.TabIndex = 23;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // btn_Newest
            // 
            this.btn_Newest.Location = new System.Drawing.Point(332, 325);
            this.btn_Newest.Name = "btn_Newest";
            this.btn_Newest.Size = new System.Drawing.Size(47, 23);
            this.btn_Newest.TabIndex = 27;
            this.btn_Newest.Text = ">>";
            this.btn_Newest.UseVisualStyleBackColor = true;
            this.btn_Newest.Click += new System.EventHandler(this.btn_Newest_Click);
            // 
            // btn_Newer
            // 
            this.btn_Newer.Location = new System.Drawing.Point(246, 325);
            this.btn_Newer.Name = "btn_Newer";
            this.btn_Newer.Size = new System.Drawing.Size(47, 23);
            this.btn_Newer.TabIndex = 26;
            this.btn_Newer.Text = ">";
            this.btn_Newer.UseVisualStyleBackColor = true;
            this.btn_Newer.Click += new System.EventHandler(this.btn_Newer_Click);
            // 
            // btn_order
            // 
            this.btn_order.Location = new System.Drawing.Point(151, 325);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(47, 23);
            this.btn_order.TabIndex = 25;
            this.btn_order.Text = "<";
            this.btn_order.UseVisualStyleBackColor = true;
            this.btn_order.Click += new System.EventHandler(this.btn_order_Click);
            // 
            // btn_oldest
            // 
            this.btn_oldest.Location = new System.Drawing.Point(76, 325);
            this.btn_oldest.Name = "btn_oldest";
            this.btn_oldest.Size = new System.Drawing.Size(47, 23);
            this.btn_oldest.TabIndex = 24;
            this.btn_oldest.Text = "<<";
            this.btn_oldest.UseVisualStyleBackColor = true;
            this.btn_oldest.Click += new System.EventHandler(this.btn_oldest_Click);
            // 
            // gb_search
            // 
            this.gb_search.Controls.Add(this.btn_search);
            this.gb_search.Controls.Add(this.txt_searchMemberID);
            this.gb_search.Controls.Add(this.lbl_searchMemberID);
            this.gb_search.Location = new System.Drawing.Point(529, 67);
            this.gb_search.Name = "gb_search";
            this.gb_search.Size = new System.Drawing.Size(222, 149);
            this.gb_search.TabIndex = 28;
            this.gb_search.TabStop = false;
            this.gb_search.Text = "Search";
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(67, 86);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 23;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_searchMemberID
            // 
            this.txt_searchMemberID.Location = new System.Drawing.Point(94, 27);
            this.txt_searchMemberID.Name = "txt_searchMemberID";
            this.txt_searchMemberID.Size = new System.Drawing.Size(100, 20);
            this.txt_searchMemberID.TabIndex = 5;
            // 
            // lbl_searchMemberID
            // 
            this.lbl_searchMemberID.AutoSize = true;
            this.lbl_searchMemberID.Location = new System.Drawing.Point(26, 34);
            this.lbl_searchMemberID.Name = "lbl_searchMemberID";
            this.lbl_searchMemberID.Size = new System.Drawing.Size(56, 13);
            this.lbl_searchMemberID.TabIndex = 1;
            this.lbl_searchMemberID.Text = "MemberID";
            // 
            // Member_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 461);
            this.Controls.Add(this.gb_search);
            this.Controls.Add(this.btn_Newest);
            this.Controls.Add(this.btn_Newer);
            this.Controls.Add(this.btn_order);
            this.Controls.Add(this.btn_oldest);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.txt_Address);
            this.Controls.Add(this.txt_PhoneNumber);
            this.Controls.Add(this.txt_MemberName);
            this.Controls.Add(this.txt_MemberID);
            this.Controls.Add(this.lbl_Address);
            this.Controls.Add(this.lbl_PhoneNumber);
            this.Controls.Add(this.lbl_MemberName);
            this.Controls.Add(this.lbl_MemberID);
            this.Name = "Member_Form";
            this.Text = "Member_Form";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.gb_search.ResumeLayout(false);
            this.gb_search.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_MemberID;
        private System.Windows.Forms.Label lbl_MemberName;
        private System.Windows.Forms.Label lbl_PhoneNumber;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.TextBox txt_MemberID;
        private System.Windows.Forms.TextBox txt_MemberName;
        private System.Windows.Forms.TextBox txt_PhoneNumber;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btn_Newest;
        private System.Windows.Forms.Button btn_Newer;
        private System.Windows.Forms.Button btn_order;
        private System.Windows.Forms.Button btn_oldest;
        private System.Windows.Forms.GroupBox gb_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_searchMemberID;
        private System.Windows.Forms.Label lbl_searchMemberID;
    }
}