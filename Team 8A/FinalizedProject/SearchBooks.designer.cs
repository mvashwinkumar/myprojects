namespace FinalizedProject
{
    partial class SearchBooks
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
            this.label_SearchBy = new System.Windows.Forms.Label();
            this.cb_SearchBy = new System.Windows.Forms.ComboBox();
            this.txt_SearchBy = new System.Windows.Forms.TextBox();
            this.cb_SortBy = new System.Windows.Forms.ComboBox();
            this.label_SortByCategory = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.dg_SearchResults = new System.Windows.Forms.DataGridView();
            this.btn_CheckAvailability = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.HomeToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dg_SearchResults)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_SearchBy
            // 
            this.label_SearchBy.AutoSize = true;
            this.label_SearchBy.Location = new System.Drawing.Point(44, 64);
            this.label_SearchBy.Name = "label_SearchBy";
            this.label_SearchBy.Size = new System.Drawing.Size(55, 13);
            this.label_SearchBy.TabIndex = 0;
            this.label_SearchBy.Text = "Search by";
            // 
            // cb_SearchBy
            // 
            this.cb_SearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_SearchBy.FormattingEnabled = true;
            this.cb_SearchBy.Items.AddRange(new object[] {
            "BookID",
            "BookName",
            "Author",
            "Publisher"});
            this.cb_SearchBy.Location = new System.Drawing.Point(138, 60);
            this.cb_SearchBy.Name = "cb_SearchBy";
            this.cb_SearchBy.Size = new System.Drawing.Size(129, 21);
            this.cb_SearchBy.TabIndex = 1;
            // 
            // txt_SearchBy
            // 
            this.txt_SearchBy.Location = new System.Drawing.Point(283, 61);
            this.txt_SearchBy.Name = "txt_SearchBy";
            this.txt_SearchBy.Size = new System.Drawing.Size(379, 20);
            this.txt_SearchBy.TabIndex = 2;
            // 
            // cb_SortBy
            // 
            this.cb_SortBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_SortBy.FormattingEnabled = true;
            this.cb_SortBy.Location = new System.Drawing.Point(138, 109);
            this.cb_SortBy.Name = "cb_SortBy";
            this.cb_SortBy.Size = new System.Drawing.Size(129, 21);
            this.cb_SortBy.TabIndex = 3;
            this.cb_SortBy.SelectedIndexChanged += new System.EventHandler(this.cb_SortBy_SelectedIndexChanged);
            // 
            // label_SortByCategory
            // 
            this.label_SortByCategory.AutoSize = true;
            this.label_SortByCategory.Location = new System.Drawing.Point(47, 114);
            this.label_SortByCategory.Name = "label_SortByCategory";
            this.label_SortByCategory.Size = new System.Drawing.Size(43, 13);
            this.label_SortByCategory.TabIndex = 4;
            this.label_SortByCategory.Text = "Filter by";
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(497, 109);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 5;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(588, 109);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 23);
            this.btn_Clear.TabIndex = 6;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // dg_SearchResults
            // 
            this.dg_SearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_SearchResults.Location = new System.Drawing.Point(47, 154);
            this.dg_SearchResults.Name = "dg_SearchResults";
            this.dg_SearchResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_SearchResults.Size = new System.Drawing.Size(615, 205);
            this.dg_SearchResults.TabIndex = 9;
            this.dg_SearchResults.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dg_SearchResults_RowHeaderMouseClick);
            // 
            // btn_CheckAvailability
            // 
            this.btn_CheckAvailability.Location = new System.Drawing.Point(365, 109);
            this.btn_CheckAvailability.Name = "btn_CheckAvailability";
            this.btn_CheckAvailability.Size = new System.Drawing.Size(114, 23);
            this.btn_CheckAvailability.TabIndex = 10;
            this.btn_CheckAvailability.Text = "Check Availability";
            this.btn_CheckAvailability.UseVisualStyleBackColor = true;
            this.btn_CheckAvailability.Click += new System.EventHandler(this.btn_CheckAvailability_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HomeToolStripMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(726, 24);
            this.menuStrip1.TabIndex = 30;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // HomeToolStripMenu
            // 
            this.HomeToolStripMenu.Name = "HomeToolStripMenu";
            this.HomeToolStripMenu.Size = new System.Drawing.Size(52, 20);
            this.HomeToolStripMenu.Text = "Home";
            this.HomeToolStripMenu.Click += new System.EventHandler(this.HomeToolStripMenu_Click);
            // 
            // SearchBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 409);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btn_CheckAvailability);
            this.Controls.Add(this.dg_SearchResults);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.label_SortByCategory);
            this.Controls.Add(this.cb_SortBy);
            this.Controls.Add(this.txt_SearchBy);
            this.Controls.Add(this.cb_SearchBy);
            this.Controls.Add(this.label_SearchBy);
            this.Name = "SearchBooks";
            this.Text = "SearchBooks";
            this.Load += new System.EventHandler(this.SearchBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_SearchResults)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_SearchBy;
        private System.Windows.Forms.ComboBox cb_SearchBy;
        private System.Windows.Forms.TextBox txt_SearchBy;
        private System.Windows.Forms.ComboBox cb_SortBy;
        private System.Windows.Forms.Label label_SortByCategory;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.DataGridView dg_SearchResults;
        private System.Windows.Forms.Button btn_CheckAvailability;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem HomeToolStripMenu;
    }
}