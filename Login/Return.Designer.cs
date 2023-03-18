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
            this.returntransactionid = new System.Windows.Forms.TextBox();
            this.transactionlabel = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.borrowgridview)).BeginInit();
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
            this.groupBox2.Location = new System.Drawing.Point(570, 202);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(223, 188);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            // 
            // returnbookbutton
            // 
            this.returnbookbutton.Location = new System.Drawing.Point(147, 142);
            this.returnbookbutton.Name = "returnbookbutton";
            this.returnbookbutton.Size = new System.Drawing.Size(70, 23);
            this.returnbookbutton.TabIndex = 12;
            this.returnbookbutton.Text = "Return";
            this.returnbookbutton.UseVisualStyleBackColor = true;
            this.returnbookbutton.Click += new System.EventHandler(this.returnbookbutton_Click);
            // 
            // returnbookauthortext
            // 
            this.returnbookauthortext.Location = new System.Drawing.Point(80, 114);
            this.returnbookauthortext.Name = "returnbookauthortext";
            this.returnbookauthortext.ReadOnly = true;
            this.returnbookauthortext.Size = new System.Drawing.Size(137, 20);
            this.returnbookauthortext.TabIndex = 5;
            // 
            // bookauthorlabel
            // 
            this.bookauthorlabel.AutoSize = true;
            this.bookauthorlabel.Location = new System.Drawing.Point(7, 117);
            this.bookauthorlabel.Name = "bookauthorlabel";
            this.bookauthorlabel.Size = new System.Drawing.Size(69, 13);
            this.bookauthorlabel.TabIndex = 4;
            this.bookauthorlabel.Text = "Book Author:";
            // 
            // returnbooknametext
            // 
            this.returnbooknametext.Location = new System.Drawing.Point(80, 81);
            this.returnbooknametext.Name = "returnbooknametext";
            this.returnbooknametext.ReadOnly = true;
            this.returnbooknametext.Size = new System.Drawing.Size(137, 20);
            this.returnbooknametext.TabIndex = 3;
            // 
            // booknamelabel
            // 
            this.booknamelabel.AutoSize = true;
            this.booknamelabel.Location = new System.Drawing.Point(7, 88);
            this.booknamelabel.Name = "booknamelabel";
            this.booknamelabel.Size = new System.Drawing.Size(66, 13);
            this.booknamelabel.TabIndex = 2;
            this.booknamelabel.Text = "Book Name:";
            // 
            // returnbookidtext
            // 
            this.returnbookidtext.Location = new System.Drawing.Point(81, 49);
            this.returnbookidtext.Name = "returnbookidtext";
            this.returnbookidtext.ReadOnly = true;
            this.returnbookidtext.Size = new System.Drawing.Size(137, 20);
            this.returnbookidtext.TabIndex = 1;
            // 
            // returnbookidlabel
            // 
            this.returnbookidlabel.AutoSize = true;
            this.returnbookidlabel.Location = new System.Drawing.Point(7, 56);
            this.returnbookidlabel.Name = "returnbookidlabel";
            this.returnbookidlabel.Size = new System.Drawing.Size(49, 13);
            this.returnbookidlabel.TabIndex = 0;
            this.returnbookidlabel.Text = "Book ID:";
            // 
            // displayallborrowbutton
            // 
            this.displayallborrowbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.displayallborrowbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.displayallborrowbutton.Location = new System.Drawing.Point(570, 45);
            this.displayallborrowbutton.Name = "displayallborrowbutton";
            this.displayallborrowbutton.Size = new System.Drawing.Size(223, 31);
            this.displayallborrowbutton.TabIndex = 21;
            this.displayallborrowbutton.Text = "Display All Borrowed Books";
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
            this.groupBox1.Location = new System.Drawing.Point(570, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 111);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // searchbookbutton
            // 
            this.searchbookbutton.Location = new System.Drawing.Point(147, 76);
            this.searchbookbutton.Name = "searchbookbutton";
            this.searchbookbutton.Size = new System.Drawing.Size(70, 24);
            this.searchbookbutton.TabIndex = 4;
            this.searchbookbutton.Text = "Search";
            this.searchbookbutton.UseVisualStyleBackColor = true;
            // 
            // searchauthortext
            // 
            this.searchauthortext.Location = new System.Drawing.Point(80, 44);
            this.searchauthortext.Name = "searchauthortext";
            this.searchauthortext.Size = new System.Drawing.Size(137, 20);
            this.searchauthortext.TabIndex = 3;
            // 
            // searchbooknametext
            // 
            this.searchbooknametext.Location = new System.Drawing.Point(80, 14);
            this.searchbooknametext.Name = "searchbooknametext";
            this.searchbooknametext.Size = new System.Drawing.Size(137, 20);
            this.searchbooknametext.TabIndex = 2;
            // 
            // searchbookauthorlabel
            // 
            this.searchbookauthorlabel.AutoSize = true;
            this.searchbookauthorlabel.Location = new System.Drawing.Point(8, 47);
            this.searchbookauthorlabel.Name = "searchbookauthorlabel";
            this.searchbookauthorlabel.Size = new System.Drawing.Size(41, 13);
            this.searchbookauthorlabel.TabIndex = 1;
            this.searchbookauthorlabel.Text = "Author:";
            // 
            // searchbooknamelabel
            // 
            this.searchbooknamelabel.AutoSize = true;
            this.searchbooknamelabel.Location = new System.Drawing.Point(7, 18);
            this.searchbooknamelabel.Name = "searchbooknamelabel";
            this.searchbooknamelabel.Size = new System.Drawing.Size(66, 13);
            this.searchbooknamelabel.TabIndex = 0;
            this.searchbooknamelabel.Text = "Book Name:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transactionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
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
            this.borrowgridview.Size = new System.Drawing.Size(552, 421);
            this.borrowgridview.TabIndex = 18;
            this.borrowgridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.borrowgridview_CellContentClick);
            // 
            // returntransactionid
            // 
            this.returntransactionid.Location = new System.Drawing.Point(81, 16);
            this.returntransactionid.Name = "returntransactionid";
            this.returntransactionid.ReadOnly = true;
            this.returntransactionid.Size = new System.Drawing.Size(137, 20);
            this.returntransactionid.TabIndex = 14;
            // 
            // transactionlabel
            // 
            this.transactionlabel.AutoSize = true;
            this.transactionlabel.Location = new System.Drawing.Point(7, 23);
            this.transactionlabel.Name = "transactionlabel";
            this.transactionlabel.Size = new System.Drawing.Size(49, 13);
            this.transactionlabel.TabIndex = 13;
            this.transactionlabel.Text = "Book ID:";
            // 
            // Return
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}