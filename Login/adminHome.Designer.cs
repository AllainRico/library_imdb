namespace Login
{
    partial class adminHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminHome));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowersbutton = new System.Windows.Forms.Button();
            this.booksbutton = new System.Windows.Forms.Button();
            this.reportbutton = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.gosignout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.gosignout});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(784, 24);
            this.menuStrip2.TabIndex = 9;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.borrowerToolStripMenuItem,
            this.booksToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // borrowerToolStripMenuItem
            // 
            this.borrowerToolStripMenuItem.Name = "borrowerToolStripMenuItem";
            this.borrowerToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.borrowerToolStripMenuItem.Text = "Borrower";
            this.borrowerToolStripMenuItem.Click += new System.EventHandler(this.borrowerToolStripMenuItem_Click);
            // 
            // booksToolStripMenuItem
            // 
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            this.booksToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.booksToolStripMenuItem.Text = "Books";
            this.booksToolStripMenuItem.Click += new System.EventHandler(this.booksToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.reportToolStripMenuItem.Text = "Report";
            this.reportToolStripMenuItem.Click += new System.EventHandler(this.reportToolStripMenuItem_Click);
            // 
            // borrowersbutton
            // 
            this.borrowersbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.borrowersbutton.FlatAppearance.BorderSize = 0;
            this.borrowersbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borrowersbutton.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowersbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(35)))), ((int)(((byte)(43)))));
            this.borrowersbutton.Location = new System.Drawing.Point(412, 356);
            this.borrowersbutton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.borrowersbutton.Name = "borrowersbutton";
            this.borrowersbutton.Size = new System.Drawing.Size(127, 40);
            this.borrowersbutton.TabIndex = 11;
            this.borrowersbutton.Text = "Borrowers";
            this.borrowersbutton.UseVisualStyleBackColor = true;
            this.borrowersbutton.Click += new System.EventHandler(this.borrowersbutton_Click);
            // 
            // booksbutton
            // 
            this.booksbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.booksbutton.FlatAppearance.BorderSize = 0;
            this.booksbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.booksbutton.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booksbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(35)))), ((int)(((byte)(43)))));
            this.booksbutton.Location = new System.Drawing.Point(412, 171);
            this.booksbutton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.booksbutton.Name = "booksbutton";
            this.booksbutton.Size = new System.Drawing.Size(127, 40);
            this.booksbutton.TabIndex = 12;
            this.booksbutton.Text = "Books";
            this.booksbutton.UseVisualStyleBackColor = true;
            this.booksbutton.Click += new System.EventHandler(this.booksbutton_Click);
            // 
            // reportbutton
            // 
            this.reportbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reportbutton.FlatAppearance.BorderSize = 0;
            this.reportbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportbutton.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(35)))), ((int)(((byte)(43)))));
            this.reportbutton.Location = new System.Drawing.Point(412, 259);
            this.reportbutton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.reportbutton.Name = "reportbutton";
            this.reportbutton.Size = new System.Drawing.Size(127, 40);
            this.reportbutton.TabIndex = 13;
            this.reportbutton.Text = "Report";
            this.reportbutton.UseVisualStyleBackColor = true;
            this.reportbutton.Click += new System.EventHandler(this.reportbutton_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Login.Properties.Resources.admin_report;
            this.pictureBox3.Location = new System.Drawing.Point(565, 258);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(55, 49);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Login.Properties.Resources.admin_books;
            this.pictureBox2.Location = new System.Drawing.Point(565, 165);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(55, 49);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Login.Properties.Resources.admin_home_logo__1_;
            this.pictureBox1.Location = new System.Drawing.Point(118, 167);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 234);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Login.Properties.Resources.admin_borrowers;
            this.pictureBox4.Location = new System.Drawing.Point(565, 350);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(55, 49);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            // 
            // gosignout
            // 
            this.gosignout.Name = "gosignout";
            this.gosignout.Size = new System.Drawing.Size(65, 20);
            this.gosignout.Text = "Sign Out";
            this.gosignout.Click += new System.EventHandler(this.gosignout_Click);
            // 
            // adminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.reportbutton);
            this.Controls.Add(this.booksbutton);
            this.Controls.Add(this.borrowersbutton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip2);
            this.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "adminHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrowerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button borrowersbutton;
        private System.Windows.Forms.Button booksbutton;
        private System.Windows.Forms.Button reportbutton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ToolStripMenuItem gosignout;
    }
}