namespace Test_for_Project
{
    partial class Frm_Search
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
            this.cmb_Search = new System.Windows.Forms.ComboBox();
            this.lbl_SearchBy = new System.Windows.Forms.Label();
            this.lbl_SearchText = new System.Windows.Forms.Label();
            this.txt_SearchText = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.dtg_SearchResults = new System.Windows.Forms.DataGridView();
            this.btn_ClearSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_SearchResults)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_Search
            // 
            this.cmb_Search.FormattingEnabled = true;
            this.cmb_Search.Items.AddRange(new object[] {
            "Book ID",
            "Book Name",
            "Category",
            "Author Name",
            "Status:",
            "Publisher"});
            this.cmb_Search.Location = new System.Drawing.Point(117, 58);
            this.cmb_Search.Name = "cmb_Search";
            this.cmb_Search.Size = new System.Drawing.Size(307, 21);
            this.cmb_Search.TabIndex = 0;
            // 
            // lbl_SearchBy
            // 
            this.lbl_SearchBy.AutoSize = true;
            this.lbl_SearchBy.Location = new System.Drawing.Point(30, 60);
            this.lbl_SearchBy.Name = "lbl_SearchBy";
            this.lbl_SearchBy.Size = new System.Drawing.Size(56, 13);
            this.lbl_SearchBy.TabIndex = 1;
            this.lbl_SearchBy.Text = "Search By";
            // 
            // lbl_SearchText
            // 
            this.lbl_SearchText.AutoSize = true;
            this.lbl_SearchText.Location = new System.Drawing.Point(30, 22);
            this.lbl_SearchText.Name = "lbl_SearchText";
            this.lbl_SearchText.Size = new System.Drawing.Size(65, 13);
            this.lbl_SearchText.TabIndex = 2;
            this.lbl_SearchText.Text = "Search Text";
            // 
            // txt_SearchText
            // 
            this.txt_SearchText.Location = new System.Drawing.Point(117, 18);
            this.txt_SearchText.Name = "txt_SearchText";
            this.txt_SearchText.Size = new System.Drawing.Size(501, 20);
            this.txt_SearchText.TabIndex = 3;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(440, 56);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 4;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // dtg_SearchResults
            // 
            this.dtg_SearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_SearchResults.Location = new System.Drawing.Point(33, 94);
            this.dtg_SearchResults.Name = "dtg_SearchResults";
            this.dtg_SearchResults.Size = new System.Drawing.Size(585, 208);
            this.dtg_SearchResults.TabIndex = 5;
            // 
            // btn_ClearSearch
            // 
            this.btn_ClearSearch.Location = new System.Drawing.Point(545, 56);
            this.btn_ClearSearch.Name = "btn_ClearSearch";
            this.btn_ClearSearch.Size = new System.Drawing.Size(75, 23);
            this.btn_ClearSearch.TabIndex = 6;
            this.btn_ClearSearch.Text = "Clear";
            this.btn_ClearSearch.UseVisualStyleBackColor = true;
            // 
            // Frm_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 314);
            this.Controls.Add(this.btn_ClearSearch);
            this.Controls.Add(this.dtg_SearchResults);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txt_SearchText);
            this.Controls.Add(this.lbl_SearchText);
            this.Controls.Add(this.lbl_SearchBy);
            this.Controls.Add(this.cmb_Search);
            this.Name = "Frm_Search";
            this.Text = "SearchForm";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_SearchResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_Search;
        private System.Windows.Forms.Label lbl_SearchBy;
        private System.Windows.Forms.Label lbl_SearchText;
        private System.Windows.Forms.TextBox txt_SearchText;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.DataGridView dtg_SearchResults;
        private System.Windows.Forms.Button btn_ClearSearch;
    }
}

