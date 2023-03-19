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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goAdminHome = new System.Windows.Forms.ToolStripMenuItem();
            this.goBooks = new System.Windows.Forms.ToolStripMenuItem();
            this.goBorrower = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.displayallbutton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.datefilterbutton = new System.Windows.Forms.Button();
            this.todatetimepicker = new System.Windows.Forms.DateTimePicker();
            this.tolabel = new System.Windows.Forms.Label();
            this.fromdatetimepicker = new System.Windows.Forms.DateTimePicker();
            this.fromlabel = new System.Windows.Forms.Label();
            this.printbutton = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(921, 24);
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
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.fileToolStripMenuItem.Text = "Navigate";
            // 
            // goAdminHome
            // 
            this.goAdminHome.Name = "goAdminHome";
            this.goAdminHome.Size = new System.Drawing.Size(122, 22);
            this.goAdminHome.Text = "Home";
            this.goAdminHome.Click += new System.EventHandler(this.goAdminHome_Click);
            // 
            // goBooks
            // 
            this.goBooks.Name = "goBooks";
            this.goBooks.Size = new System.Drawing.Size(122, 22);
            this.goBooks.Text = "Books";
            this.goBooks.Click += new System.EventHandler(this.goBooks_Click);
            // 
            // goBorrower
            // 
            this.goBorrower.Name = "goBorrower";
            this.goBorrower.Size = new System.Drawing.Size(122, 22);
            this.goBorrower.Text = "Borrower";
            this.goBorrower.Click += new System.EventHandler(this.goBorrower_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.Location = new System.Drawing.Point(10, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(667, 500);
            this.dataGridView1.TabIndex = 13;
            // 
            // displayallbutton
            // 
            this.displayallbutton.BackColor = System.Drawing.Color.White;
            this.displayallbutton.FlatAppearance.BorderSize = 0;
            this.displayallbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.displayallbutton.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold);
            this.displayallbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(35)))), ((int)(((byte)(43)))));
            this.displayallbutton.Location = new System.Drawing.Point(751, 96);
            this.displayallbutton.Name = "displayallbutton";
            this.displayallbutton.Size = new System.Drawing.Size(151, 25);
            this.displayallbutton.TabIndex = 19;
            this.displayallbutton.Text = "Display";
            this.displayallbutton.UseVisualStyleBackColor = false;
            this.displayallbutton.Click += new System.EventHandler(this.displayallbutton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.datefilterbutton);
            this.groupBox1.Controls.Add(this.todatetimepicker);
            this.groupBox1.Controls.Add(this.tolabel);
            this.groupBox1.Controls.Add(this.fromdatetimepicker);
            this.groupBox1.Controls.Add(this.fromlabel);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(35)))), ((int)(((byte)(43)))));
            this.groupBox1.Location = new System.Drawing.Point(683, 306);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 123);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // datefilterbutton
            // 
            this.datefilterbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.datefilterbutton.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F);
            this.datefilterbutton.Location = new System.Drawing.Point(121, 83);
            this.datefilterbutton.Name = "datefilterbutton";
            this.datefilterbutton.Size = new System.Drawing.Size(88, 24);
            this.datefilterbutton.TabIndex = 22;
            this.datefilterbutton.Text = "Apply";
            this.datefilterbutton.UseVisualStyleBackColor = true;
            this.datefilterbutton.Click += new System.EventHandler(this.datefilterbutton_Click);
            // 
            // todatetimepicker
            // 
            this.todatetimepicker.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F);
            this.todatetimepicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.todatetimepicker.Location = new System.Drawing.Point(70, 56);
            this.todatetimepicker.Name = "todatetimepicker";
            this.todatetimepicker.Size = new System.Drawing.Size(139, 22);
            this.todatetimepicker.TabIndex = 21;
            // 
            // tolabel
            // 
            this.tolabel.AutoSize = true;
            this.tolabel.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tolabel.Location = new System.Drawing.Point(13, 56);
            this.tolabel.Name = "tolabel";
            this.tolabel.Size = new System.Drawing.Size(28, 16);
            this.tolabel.TabIndex = 20;
            this.tolabel.Text = "To:";
            // 
            // fromdatetimepicker
            // 
            this.fromdatetimepicker.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F);
            this.fromdatetimepicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fromdatetimepicker.Location = new System.Drawing.Point(70, 24);
            this.fromdatetimepicker.Name = "fromdatetimepicker";
            this.fromdatetimepicker.Size = new System.Drawing.Size(139, 22);
            this.fromdatetimepicker.TabIndex = 19;
            // 
            // fromlabel
            // 
            this.fromlabel.AutoSize = true;
            this.fromlabel.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromlabel.Location = new System.Drawing.Point(13, 27);
            this.fromlabel.Name = "fromlabel";
            this.fromlabel.Size = new System.Drawing.Size(44, 16);
            this.fromlabel.TabIndex = 18;
            this.fromlabel.Text = "From:";
            // 
            // printbutton
            // 
            this.printbutton.BackColor = System.Drawing.Color.White;
            this.printbutton.FlatAppearance.BorderSize = 0;
            this.printbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printbutton.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold);
            this.printbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(35)))), ((int)(((byte)(43)))));
            this.printbutton.Location = new System.Drawing.Point(751, 202);
            this.printbutton.Name = "printbutton";
            this.printbutton.Size = new System.Drawing.Size(151, 25);
            this.printbutton.TabIndex = 21;
            this.printbutton.Text = "Print";
            this.printbutton.UseVisualStyleBackColor = false;
            this.printbutton.Click += new System.EventHandler(this.printbutton_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Login.Properties.Resources.admin_display_report;
            this.pictureBox1.Location = new System.Drawing.Point(714, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Login.Properties.Resources.admin_print_report;
            this.pictureBox2.Location = new System.Drawing.Point(714, 182);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(71, 66);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(921, 561);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.printbutton);
            this.Controls.Add(this.displayallbutton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goAdminHome;
        private System.Windows.Forms.ToolStripMenuItem goBooks;
        private System.Windows.Forms.ToolStripMenuItem goBorrower;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button displayallbutton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker todatetimepicker;
        private System.Windows.Forms.Label tolabel;
        private System.Windows.Forms.DateTimePicker fromdatetimepicker;
        private System.Windows.Forms.Label fromlabel;
        private System.Windows.Forms.Button datefilterbutton;
        private System.Windows.Forms.Button printbutton;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}