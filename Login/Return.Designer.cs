namespace Login
{
    partial class Return
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.returntransactionid = new System.Windows.Forms.TextBox();
            this.transactionlabel = new System.Windows.Forms.Label();
            this.returnbookbutton = new System.Windows.Forms.Button();
            this.returnbookauthortext = new System.Windows.Forms.TextBox();
            this.bookauthorlabel = new System.Windows.Forms.Label();
            this.returnbooknametext = new System.Windows.Forms.TextBox();
            this.booknamelabel = new System.Windows.Forms.Label();
            this.returnbookidtext = new System.Windows.Forms.TextBox();
            this.returnbookidlabel = new System.Windows.Forms.Label();
            this.displayallborrowbutton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchbookbutton = new System.Windows.Forms.Button();
            this.searchauthortext = new System.Windows.Forms.TextBox();
            this.searchbooknametext = new System.Windows.Forms.TextBox();
            this.searchbookauthorlabel = new System.Windows.Forms.Label();
            this.searchbooknamelabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goHome = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowgridview = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.borrowgridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.returntransactionid);
            this.groupBox2.Controls.Add(this.transactionlabel);
            this.groupBox2.Controls.Add(this.returnbookbutton);
            this.groupBox2.Controls.Add(this.returnbookauthortext);
            this.groupBox2.Controls.Add(this.bookauthorlabel);
            this.groupBox2.Controls.Add(this.returnbooknametext);
            this.groupBox2.Controls.Add(this.booknamelabel);
            this.groupBox2.Controls.Add(this.returnbookidtext);
            this.groupBox2.Controls.Add(this.returnbookidlabel);
            this.groupBox2.Font = new System.Drawing.Font("Mongolian Baiti", 9F);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(35)))), ((int)(((byte)(43)))));
            this.groupBox2.Location = new System.Drawing.Point(656, 275);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 205);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            // 
            // returntransactionid
            // 
            this.returntransactionid.BackColor = System.Drawing.Color.White;
            this.returntransactionid.Location = new System.Drawing.Point(81, 28);
            this.returntransactionid.Name = "returntransactionid";
            this.returntransactionid.ReadOnly = true;
            this.returntransactionid.Size = new System.Drawing.Size(153, 21);
            this.returntransactionid.TabIndex = 14;
            // 
            // transactionlabel
            // 
            this.transactionlabel.AutoSize = true;
            this.transactionlabel.Location = new System.Drawing.Point(7, 35);
            this.transactionlabel.Name = "transactionlabel";
            this.transactionlabel.Size = new System.Drawing.Size(52, 13);
            this.transactionlabel.TabIndex = 13;
            this.transactionlabel.Text = "Book ID:";
            // 
            // returnbookbutton
            // 
            this.returnbookbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnbookbutton.Location = new System.Drawing.Point(147, 154);
            this.returnbookbutton.Name = "returnbookbutton";
            this.returnbookbutton.Size = new System.Drawing.Size(86, 23);
            this.returnbookbutton.TabIndex = 12;
            this.returnbookbutton.Text = "Return";
            this.returnbookbutton.UseVisualStyleBackColor = true;
            this.returnbookbutton.Click += new System.EventHandler(this.returnbookbutton_Click);
            // 
            // returnbookauthortext
            // 
            this.returnbookauthortext.BackColor = System.Drawing.Color.White;
            this.returnbookauthortext.Location = new System.Drawing.Point(80, 126);
            this.returnbookauthortext.Name = "returnbookauthortext";
            this.returnbookauthortext.ReadOnly = true;
            this.returnbookauthortext.Size = new System.Drawing.Size(153, 21);
            this.returnbookauthortext.TabIndex = 5;
            // 
            // bookauthorlabel
            // 
            this.bookauthorlabel.AutoSize = true;
            this.bookauthorlabel.Location = new System.Drawing.Point(7, 129);
            this.bookauthorlabel.Name = "bookauthorlabel";
            this.bookauthorlabel.Size = new System.Drawing.Size(73, 13);
            this.bookauthorlabel.TabIndex = 4;
            this.bookauthorlabel.Text = "Book Author:";
            // 
            // returnbooknametext
            // 
            this.returnbooknametext.BackColor = System.Drawing.Color.White;
            this.returnbooknametext.Location = new System.Drawing.Point(80, 93);
            this.returnbooknametext.Name = "returnbooknametext";
            this.returnbooknametext.ReadOnly = true;
            this.returnbooknametext.Size = new System.Drawing.Size(153, 21);
            this.returnbooknametext.TabIndex = 3;
            // 
            // booknamelabel
            // 
            this.booknamelabel.AutoSize = true;
            this.booknamelabel.Location = new System.Drawing.Point(7, 100);
            this.booknamelabel.Name = "booknamelabel";
            this.booknamelabel.Size = new System.Drawing.Size(67, 13);
            this.booknamelabel.TabIndex = 2;
            this.booknamelabel.Text = "Book Name:";
            // 
            // returnbookidtext
            // 
            this.returnbookidtext.BackColor = System.Drawing.Color.White;
            this.returnbookidtext.Location = new System.Drawing.Point(81, 61);
            this.returnbookidtext.Name = "returnbookidtext";
            this.returnbookidtext.ReadOnly = true;
            this.returnbookidtext.Size = new System.Drawing.Size(153, 21);
            this.returnbookidtext.TabIndex = 1;
            // 
            // returnbookidlabel
            // 
            this.returnbookidlabel.AutoSize = true;
            this.returnbookidlabel.Location = new System.Drawing.Point(7, 68);
            this.returnbookidlabel.Name = "returnbookidlabel";
            this.returnbookidlabel.Size = new System.Drawing.Size(52, 13);
            this.returnbookidlabel.TabIndex = 0;
            this.returnbookidlabel.Text = "Book ID:";
            // 
            // displayallborrowbutton
            // 
            this.displayallborrowbutton.BackColor = System.Drawing.Color.White;
            this.displayallborrowbutton.FlatAppearance.BorderSize = 0;
            this.displayallborrowbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.displayallborrowbutton.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold);
            this.displayallborrowbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(35)))), ((int)(((byte)(43)))));
            this.displayallborrowbutton.Location = new System.Drawing.Point(736, 48);
            this.displayallborrowbutton.Name = "displayallborrowbutton";
            this.displayallborrowbutton.Size = new System.Drawing.Size(165, 31);
            this.displayallborrowbutton.TabIndex = 21;
            this.displayallborrowbutton.Text = "All Borrowed Books";
            this.displayallborrowbutton.UseVisualStyleBackColor = false;
            this.displayallborrowbutton.Click += new System.EventHandler(this.displayallborrowbutton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchbookbutton);
            this.groupBox1.Controls.Add(this.searchauthortext);
            this.groupBox1.Controls.Add(this.searchbooknametext);
            this.groupBox1.Controls.Add(this.searchbookauthorlabel);
            this.groupBox1.Controls.Add(this.searchbooknamelabel);
            this.groupBox1.Font = new System.Drawing.Font("Mongolian Baiti", 9F);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(35)))), ((int)(((byte)(43)))));
            this.groupBox1.Location = new System.Drawing.Point(656, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 133);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // searchbookbutton
            // 
            this.searchbookbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchbookbutton.Location = new System.Drawing.Point(147, 88);
            this.searchbookbutton.Name = "searchbookbutton";
            this.searchbookbutton.Size = new System.Drawing.Size(86, 24);
            this.searchbookbutton.TabIndex = 4;
            this.searchbookbutton.Text = "Search";
            this.searchbookbutton.UseVisualStyleBackColor = true;
            // 
            // searchauthortext
            // 
            this.searchauthortext.Location = new System.Drawing.Point(80, 56);
            this.searchauthortext.Name = "searchauthortext";
            this.searchauthortext.Size = new System.Drawing.Size(153, 21);
            this.searchauthortext.TabIndex = 3;
            // 
            // searchbooknametext
            // 
            this.searchbooknametext.Location = new System.Drawing.Point(80, 26);
            this.searchbooknametext.Name = "searchbooknametext";
            this.searchbooknametext.Size = new System.Drawing.Size(153, 21);
            this.searchbooknametext.TabIndex = 2;
            // 
            // searchbookauthorlabel
            // 
            this.searchbookauthorlabel.AutoSize = true;
            this.searchbookauthorlabel.Location = new System.Drawing.Point(8, 59);
            this.searchbookauthorlabel.Name = "searchbookauthorlabel";
            this.searchbookauthorlabel.Size = new System.Drawing.Size(44, 13);
            this.searchbookauthorlabel.TabIndex = 1;
            this.searchbookauthorlabel.Text = "Author:";
            // 
            // searchbooknamelabel
            // 
            this.searchbooknamelabel.AutoSize = true;
            this.searchbooknamelabel.Location = new System.Drawing.Point(7, 30);
            this.searchbooknamelabel.Name = "searchbooknamelabel";
            this.searchbooknamelabel.Size = new System.Drawing.Size(67, 13);
            this.searchbooknamelabel.TabIndex = 0;
            this.searchbooknamelabel.Text = "Book Name:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transactionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(921, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goHome});
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.transactionToolStripMenuItem.Text = "Transaction";
            // 
            // goHome
            // 
            this.goHome.Name = "goHome";
            this.goHome.Size = new System.Drawing.Size(107, 22);
            this.goHome.Text = "Home";
            this.goHome.Click += new System.EventHandler(this.goHome_Click);
            // 
            // borrowgridview
            // 
            this.borrowgridview.AllowUserToAddRows = false;
            this.borrowgridview.AllowUserToDeleteRows = false;
            this.borrowgridview.BackgroundColor = System.Drawing.Color.White;
            this.borrowgridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.borrowgridview.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.borrowgridview.Location = new System.Drawing.Point(12, 29);
            this.borrowgridview.Name = "borrowgridview";
            this.borrowgridview.ReadOnly = true;
            this.borrowgridview.Size = new System.Drawing.Size(638, 500);
            this.borrowgridview.TabIndex = 18;
            this.borrowgridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.borrowgridview_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Login.Properties.Resources.all_borrowed_books;
            this.pictureBox1.Location = new System.Drawing.Point(671, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // Return
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(921, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.displayallborrowbutton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.borrowgridview);
            this.Name = "Return";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Return";
            this.Load += new System.EventHandler(this.Return_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.borrowgridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button returnbookbutton;
        private System.Windows.Forms.TextBox returnbookauthortext;
        private System.Windows.Forms.Label bookauthorlabel;
        private System.Windows.Forms.TextBox returnbooknametext;
        private System.Windows.Forms.Label booknamelabel;
        private System.Windows.Forms.TextBox returnbookidtext;
        private System.Windows.Forms.Label returnbookidlabel;
        private System.Windows.Forms.Button displayallborrowbutton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button searchbookbutton;
        private System.Windows.Forms.TextBox searchauthortext;
        private System.Windows.Forms.TextBox searchbooknametext;
        private System.Windows.Forms.Label searchbookauthorlabel;
        private System.Windows.Forms.Label searchbooknamelabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goHome;
        private System.Windows.Forms.DataGridView borrowgridview;
        private System.Windows.Forms.TextBox returntransactionid;
        private System.Windows.Forms.Label transactionlabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}