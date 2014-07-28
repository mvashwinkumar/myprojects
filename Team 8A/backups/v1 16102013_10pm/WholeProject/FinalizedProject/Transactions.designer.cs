namespace FinalizedProject
{
    partial class Form_Transactions
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
            this.label_MemberID = new System.Windows.Forms.Label();
            this.txt_MemberID = new System.Windows.Forms.TextBox();
            this.btn_ShowStatus = new System.Windows.Forms.Button();
            this.grpbox_memberID = new System.Windows.Forms.GroupBox();
            this.btn_MemberInfo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dg_PersonalLoanStatus = new System.Windows.Forms.DataGridView();
            this.grpBox_PersonalLoanStatus = new System.Windows.Forms.GroupBox();
            this.btn_Loan = new System.Windows.Forms.Button();
            this.label_BookID = new System.Windows.Forms.Label();
            this.txt_BookID = new System.Windows.Forms.TextBox();
            this.btn_retrieve = new System.Windows.Forms.Button();
            this.dg_BookInfo = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_Return = new System.Windows.Forms.Button();
            this.label_Profile = new System.Windows.Forms.Label();
            this.dg_MemberInfo = new System.Windows.Forms.DataGridView();
            this.grpBox_MemberInfo = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.membersProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booksCatalogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editBookInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpbox_memberID.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_PersonalLoanStatus)).BeginInit();
            this.grpBox_PersonalLoanStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_BookInfo)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_MemberInfo)).BeginInit();
            this.grpBox_MemberInfo.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_MemberID
            // 
            this.label_MemberID.AutoSize = true;
            this.label_MemberID.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_MemberID.Location = new System.Drawing.Point(40, 47);
            this.label_MemberID.Name = "label_MemberID";
            this.label_MemberID.Size = new System.Drawing.Size(80, 16);
            this.label_MemberID.TabIndex = 0;
            this.label_MemberID.Text = "MemberID:";
            // 
            // txt_MemberID
            // 
            this.txt_MemberID.Location = new System.Drawing.Point(169, 47);
            this.txt_MemberID.Name = "txt_MemberID";
            this.txt_MemberID.Size = new System.Drawing.Size(220, 26);
            this.txt_MemberID.TabIndex = 1;
            // 
            // btn_ShowStatus
            // 
            this.btn_ShowStatus.Location = new System.Drawing.Point(414, 37);
            this.btn_ShowStatus.Name = "btn_ShowStatus";
            this.btn_ShowStatus.Size = new System.Drawing.Size(133, 40);
            this.btn_ShowStatus.TabIndex = 2;
            this.btn_ShowStatus.Text = "Show Status";
            this.btn_ShowStatus.UseVisualStyleBackColor = true;
            this.btn_ShowStatus.Click += new System.EventHandler(this.btn_ShowStatus_Click);
            // 
            // grpbox_memberID
            // 
            this.grpbox_memberID.Controls.Add(this.btn_MemberInfo);
            this.grpbox_memberID.Controls.Add(this.btn_ShowStatus);
            this.grpbox_memberID.Controls.Add(this.txt_MemberID);
            this.grpbox_memberID.Controls.Add(this.label_MemberID);
            this.grpbox_memberID.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grpbox_memberID.Location = new System.Drawing.Point(12, 27);
            this.grpbox_memberID.Name = "grpbox_memberID";
            this.grpbox_memberID.Size = new System.Drawing.Size(762, 95);
            this.grpbox_memberID.TabIndex = 3;
            this.grpbox_memberID.TabStop = false;
            this.grpbox_memberID.Text = "MemberID";
            // 
            // btn_MemberInfo
            // 
            this.btn_MemberInfo.Location = new System.Drawing.Point(591, 37);
            this.btn_MemberInfo.Name = "btn_MemberInfo";
            this.btn_MemberInfo.Size = new System.Drawing.Size(133, 40);
            this.btn_MemberInfo.TabIndex = 3;
            this.btn_MemberInfo.Text = "Member Info";
            this.btn_MemberInfo.UseVisualStyleBackColor = true;
            this.btn_MemberInfo.Click += new System.EventHandler(this.btn_MemberInfo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(27, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Status:";
            // 
            // dg_PersonalLoanStatus
            // 
            this.dg_PersonalLoanStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_PersonalLoanStatus.Location = new System.Drawing.Point(103, 37);
            this.dg_PersonalLoanStatus.Name = "dg_PersonalLoanStatus";
            this.dg_PersonalLoanStatus.RowTemplate.Height = 23;
            this.dg_PersonalLoanStatus.Size = new System.Drawing.Size(349, 173);
            this.dg_PersonalLoanStatus.TabIndex = 8;
            // 
            // grpBox_PersonalLoanStatus
            // 
            this.grpBox_PersonalLoanStatus.Controls.Add(this.dg_PersonalLoanStatus);
            this.grpBox_PersonalLoanStatus.Controls.Add(this.label2);
            this.grpBox_PersonalLoanStatus.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grpBox_PersonalLoanStatus.Location = new System.Drawing.Point(16, 127);
            this.grpBox_PersonalLoanStatus.Name = "grpBox_PersonalLoanStatus";
            this.grpBox_PersonalLoanStatus.Size = new System.Drawing.Size(486, 229);
            this.grpBox_PersonalLoanStatus.TabIndex = 9;
            this.grpBox_PersonalLoanStatus.TabStop = false;
            this.grpBox_PersonalLoanStatus.Text = "Personal Loan Status";
            // 
            // btn_Loan
            // 
            this.btn_Loan.Location = new System.Drawing.Point(815, 56);
            this.btn_Loan.Name = "btn_Loan";
            this.btn_Loan.Size = new System.Drawing.Size(131, 32);
            this.btn_Loan.TabIndex = 2;
            this.btn_Loan.Text = "Loan";
            this.btn_Loan.UseVisualStyleBackColor = true;
            this.btn_Loan.Click += new System.EventHandler(this.btn_Loan_Click);
            // 
            // label_BookID
            // 
            this.label_BookID.AutoSize = true;
            this.label_BookID.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_BookID.Location = new System.Drawing.Point(30, 44);
            this.label_BookID.Name = "label_BookID";
            this.label_BookID.Size = new System.Drawing.Size(64, 16);
            this.label_BookID.TabIndex = 12;
            this.label_BookID.Text = "Book ID";
            // 
            // txt_BookID
            // 
            this.txt_BookID.Location = new System.Drawing.Point(128, 41);
            this.txt_BookID.Name = "txt_BookID";
            this.txt_BookID.Size = new System.Drawing.Size(358, 26);
            this.txt_BookID.TabIndex = 5;
            // 
            // btn_retrieve
            // 
            this.btn_retrieve.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_retrieve.Location = new System.Drawing.Point(609, 41);
            this.btn_retrieve.Name = "btn_retrieve";
            this.btn_retrieve.Size = new System.Drawing.Size(111, 27);
            this.btn_retrieve.TabIndex = 5;
            this.btn_retrieve.Text = "retrieve";
            this.btn_retrieve.UseVisualStyleBackColor = true;
            this.btn_retrieve.Click += new System.EventHandler(this.btn_retrieve_Click);
            // 
            // dg_BookInfo
            // 
            this.dg_BookInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_BookInfo.Location = new System.Drawing.Point(34, 104);
            this.dg_BookInfo.Name = "dg_BookInfo";
            this.dg_BookInfo.RowTemplate.Height = 23;
            this.dg_BookInfo.Size = new System.Drawing.Size(686, 76);
            this.dg_BookInfo.TabIndex = 5;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_Return);
            this.groupBox4.Controls.Add(this.dg_BookInfo);
            this.groupBox4.Controls.Add(this.btn_Loan);
            this.groupBox4.Controls.Add(this.btn_retrieve);
            this.groupBox4.Controls.Add(this.txt_BookID);
            this.groupBox4.Controls.Add(this.label_BookID);
            this.groupBox4.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox4.Location = new System.Drawing.Point(16, 377);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1021, 221);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Loan / Return Book";
            // 
            // btn_Return
            // 
            this.btn_Return.Location = new System.Drawing.Point(815, 144);
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.Size = new System.Drawing.Size(131, 36);
            this.btn_Return.TabIndex = 5;
            this.btn_Return.Text = "Return";
            this.btn_Return.UseVisualStyleBackColor = true;
            this.btn_Return.Click += new System.EventHandler(this.btn_Return_Click);
            // 
            // label_Profile
            // 
            this.label_Profile.AutoSize = true;
            this.label_Profile.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Profile.Location = new System.Drawing.Point(22, 22);
            this.label_Profile.Name = "label_Profile";
            this.label_Profile.Size = new System.Drawing.Size(72, 16);
            this.label_Profile.TabIndex = 9;
            this.label_Profile.Text = "Profile:";
            // 
            // dg_MemberInfo
            // 
            this.dg_MemberInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_MemberInfo.Location = new System.Drawing.Point(115, 37);
            this.dg_MemberInfo.Name = "dg_MemberInfo";
            this.dg_MemberInfo.RowTemplate.Height = 23;
            this.dg_MemberInfo.Size = new System.Drawing.Size(349, 173);
            this.dg_MemberInfo.TabIndex = 9;
            // 
            // grpBox_MemberInfo
            // 
            this.grpBox_MemberInfo.Controls.Add(this.dg_MemberInfo);
            this.grpBox_MemberInfo.Controls.Add(this.label_Profile);
            this.grpBox_MemberInfo.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grpBox_MemberInfo.Location = new System.Drawing.Point(531, 127);
            this.grpBox_MemberInfo.Name = "grpBox_MemberInfo";
            this.grpBox_MemberInfo.Size = new System.Drawing.Size(506, 229);
            this.grpBox_MemberInfo.TabIndex = 14;
            this.grpBox_MemberInfo.TabStop = false;
            this.grpBox_MemberInfo.Text = "Member Info";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.membersProfileToolStripMenuItem,
            this.booksCatalogToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1110, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.loginToolStripMenuItem.Text = "Login";
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
            // 
            // editProfileToolStripMenuItem
            // 
            this.editProfileToolStripMenuItem.Name = "editProfileToolStripMenuItem";
            this.editProfileToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.editProfileToolStripMenuItem.Text = "Edit Profile";
            // 
            // booksCatalogToolStripMenuItem
            // 
            this.booksCatalogToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchBooksToolStripMenuItem,
            this.createNewInfoToolStripMenuItem,
            this.editBookInfoToolStripMenuItem});
            this.booksCatalogToolStripMenuItem.Name = "booksCatalogToolStripMenuItem";
            this.booksCatalogToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.booksCatalogToolStripMenuItem.Text = "Books Catalog";
            // 
            // searchBooksToolStripMenuItem
            // 
            this.searchBooksToolStripMenuItem.Name = "searchBooksToolStripMenuItem";
            this.searchBooksToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.searchBooksToolStripMenuItem.Text = "Search Books";
            // 
            // createNewInfoToolStripMenuItem
            // 
            this.createNewInfoToolStripMenuItem.Name = "createNewInfoToolStripMenuItem";
            this.createNewInfoToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.createNewInfoToolStripMenuItem.Text = "Create New Info";
            // 
            // editBookInfoToolStripMenuItem
            // 
            this.editBookInfoToolStripMenuItem.Name = "editBookInfoToolStripMenuItem";
            this.editBookInfoToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.editBookInfoToolStripMenuItem.Text = "Edit Book Info";
            // 
            // Form_Transactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 674);
            this.Controls.Add(this.grpBox_MemberInfo);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.grpbox_memberID);
            this.Controls.Add(this.grpBox_PersonalLoanStatus);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Transactions";
            this.Text = "Transactions";
            this.Load += new System.EventHandler(this.Form_Transactions_Load);
            this.grpbox_memberID.ResumeLayout(false);
            this.grpbox_memberID.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_PersonalLoanStatus)).EndInit();
            this.grpBox_PersonalLoanStatus.ResumeLayout(false);
            this.grpBox_PersonalLoanStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_BookInfo)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_MemberInfo)).EndInit();
            this.grpBox_MemberInfo.ResumeLayout(false);
            this.grpBox_MemberInfo.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_MemberID;
        private System.Windows.Forms.TextBox txt_MemberID;
        private System.Windows.Forms.Button btn_ShowStatus;
        private System.Windows.Forms.GroupBox grpbox_memberID;
        private System.Windows.Forms.Button btn_MemberInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dg_PersonalLoanStatus;
        private System.Windows.Forms.GroupBox grpBox_PersonalLoanStatus;
        private System.Windows.Forms.Button btn_Loan;
        private System.Windows.Forms.Label label_BookID;
        private System.Windows.Forms.TextBox txt_BookID;
        private System.Windows.Forms.Button btn_retrieve;
        private System.Windows.Forms.DataGridView dg_BookInfo;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_Return;
        private System.Windows.Forms.Label label_Profile;
        private System.Windows.Forms.DataGridView dg_MemberInfo;
        private System.Windows.Forms.GroupBox grpBox_MemberInfo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem membersProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem booksCatalogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editBookInfoToolStripMenuItem;
    }
}

