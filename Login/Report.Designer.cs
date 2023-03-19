namespace Login
{
    partial class Report
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goAdminHome = new System.Windows.Forms.ToolStripMenuItem();
            this.goBooks = new System.Windows.Forms.ToolStripMenuItem();
            this.goBorrower = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 12;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goAdminHome,
            this.goBooks,
            this.goBorrower});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // goAdminHome
            // 
            this.goAdminHome.Name = "goAdminHome";
            this.goAdminHome.Size = new System.Drawing.Size(180, 22);
            this.goAdminHome.Text = "Home";
            this.goAdminHome.Click += new System.EventHandler(this.goAdminHome_Click);
            // 
            // goBooks
            // 
            this.goBooks.Name = "goBooks";
            this.goBooks.Size = new System.Drawing.Size(180, 22);
            this.goBooks.Text = "Books";
            this.goBooks.Click += new System.EventHandler(this.goBooks_Click);
            // 
            // goBorrower
            // 
            this.goBorrower.Name = "goBorrower";
            this.goBorrower.Size = new System.Drawing.Size(180, 22);
            this.goBorrower.Text = "Borrower";
            this.goBorrower.Click += new System.EventHandler(this.goBorrower_Click);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip2);
            this.Name = "Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goAdminHome;
        private System.Windows.Forms.ToolStripMenuItem goBooks;
        private System.Windows.Forms.ToolStripMenuItem goBorrower;
    }
}