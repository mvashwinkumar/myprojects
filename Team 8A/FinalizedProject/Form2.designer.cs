namespace FinalizedProject
{
    partial class Form2
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
            this.Report_button = new System.Windows.Forms.Button();
            this.Maintance_button = new System.Windows.Forms.Button();
            this.Transaction_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_showData = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Report_button
            // 
            this.Report_button.Font = new System.Drawing.Font("SimSun", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Report_button.Location = new System.Drawing.Point(481, 120);
            this.Report_button.Name = "Report_button";
            this.Report_button.Size = new System.Drawing.Size(193, 157);
            this.Report_button.TabIndex = 5;
            this.Report_button.Text = "Report";
            this.Report_button.UseVisualStyleBackColor = true;
            // 
            // Maintance_button
            // 
            this.Maintance_button.Font = new System.Drawing.Font("SimSun", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Maintance_button.Location = new System.Drawing.Point(244, 111);
            this.Maintance_button.Name = "Maintance_button";
            this.Maintance_button.Size = new System.Drawing.Size(193, 80);
            this.Maintance_button.TabIndex = 4;
            this.Maintance_button.Text = "Maintance Books";
            this.Maintance_button.UseVisualStyleBackColor = true;
            this.Maintance_button.Click += new System.EventHandler(this.Maintance_button_Click);
            // 
            // Transaction_button
            // 
            this.Transaction_button.Font = new System.Drawing.Font("SimSun", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Transaction_button.Location = new System.Drawing.Point(12, 120);
            this.Transaction_button.Name = "Transaction_button";
            this.Transaction_button.Size = new System.Drawing.Size(193, 157);
            this.Transaction_button.TabIndex = 3;
            this.Transaction_button.Text = "Transaction";
            this.Transaction_button.UseVisualStyleBackColor = true;
            this.Transaction_button.Click += new System.EventHandler(this.Transaction_button_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("SimSun", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(244, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 80);
            this.button1.TabIndex = 6;
            this.button1.Text = "Maintance Members";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_showData
            // 
            this.lbl_showData.AutoSize = true;
            this.lbl_showData.Location = new System.Drawing.Point(22, 35);
            this.lbl_showData.Name = "lbl_showData";
            this.lbl_showData.Size = new System.Drawing.Size(137, 13);
            this.lbl_showData.TabIndex = 7;
            this.lbl_showData.Text = "Wellcome to Library System";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(686, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 411);
            this.Controls.Add(this.lbl_showData);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Report_button);
            this.Controls.Add(this.Maintance_button);
            this.Controls.Add(this.Transaction_button);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "MainPage";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Report_button;
        private System.Windows.Forms.Button Maintance_button;
        private System.Windows.Forms.Button Transaction_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_showData;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
    }
}