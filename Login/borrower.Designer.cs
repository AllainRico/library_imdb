namespace Login
{
    partial class borrower
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
            this.borrowergridview = new System.Windows.Forms.DataGridView();
            this.displayallborrowerbutton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.addborrowerbutton = new System.Windows.Forms.Button();
            this.borrowerdatetext = new System.Windows.Forms.TextBox();
            this.bookyeartext = new System.Windows.Forms.Label();
            this.borrowerbookidtext = new System.Windows.Forms.TextBox();
            this.bookauthorlabel = new System.Windows.Forms.Label();
            this.borrowernametext = new System.Windows.Forms.TextBox();
            this.booknamelabel = new System.Windows.Forms.Label();
            this.borroweruseridtext = new System.Windows.Forms.TextBox();
            this.bookid = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchbookbutton = new System.Windows.Forms.Button();
            this.borrowsearchusernametext = new System.Windows.Forms.TextBox();
            this.borrowsearchuseridtext = new System.Windows.Forms.TextBox();
            this.borrowerusernametextlabel = new System.Windows.Forms.Label();
            this.borroweruseridtextlabel = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.borrowergridview)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // borrowergridview
            // 
            this.borrowergridview.BackgroundColor = System.Drawing.Color.White;
            this.borrowergridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.borrowergridview.GridColor = System.Drawing.Color.White;
            this.borrowergridview.Location = new System.Drawing.Point(12, 30);
            this.borrowergridview.Name = "borrowergridview";
            this.borrowergridview.Size = new System.Drawing.Size(552, 418);
            this.borrowergridview.TabIndex = 0;
            // 
            // displayallborrowerbutton
            // 
            this.displayallborrowerbutton.Location = new System.Drawing.Point(570, 34);
            this.displayallborrowerbutton.Name = "displayallborrowerbutton";
            this.displayallborrowerbutton.Size = new System.Drawing.Size(223, 31);
            this.displayallborrowerbutton.TabIndex = 1;
            this.displayallborrowerbutton.Text = "Display all Borrower";
            this.displayallborrowerbutton.UseVisualStyleBackColor = true;
            this.displayallborrowerbutton.Click += new System.EventHandler(this.displayallborrowerbutton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.addborrowerbutton);
            this.groupBox2.Controls.Add(this.borrowerdatetext);
            this.groupBox2.Controls.Add(this.bookyeartext);
            this.groupBox2.Controls.Add(this.borrowerbookidtext);
            this.groupBox2.Controls.Add(this.bookauthorlabel);
            this.groupBox2.Controls.Add(this.borrowernametext);
            this.groupBox2.Controls.Add(this.booknamelabel);
            this.groupBox2.Controls.Add(this.borroweruseridtext);
            this.groupBox2.Controls.Add(this.bookid);
            this.groupBox2.Location = new System.Drawing.Point(570, 191);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(223, 179);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // addborrowerbutton
            // 
            this.addborrowerbutton.Location = new System.Drawing.Point(147, 141);
            this.addborrowerbutton.Name = "addborrowerbutton";
            this.addborrowerbutton.Size = new System.Drawing.Size(70, 23);
            this.addborrowerbutton.TabIndex = 12;
            this.addborrowerbutton.Text = "Add";
            this.addborrowerbutton.UseVisualStyleBackColor = true;
            this.addborrowerbutton.Click += new System.EventHandler(this.addborrowerbutton_Click);
            // 
            // borrowerdatetext
            // 
            this.borrowerdatetext.Location = new System.Drawing.Point(80, 115);
            this.borrowerdatetext.Name = "borrowerdatetext";
            this.borrowerdatetext.Size = new System.Drawing.Size(137, 20);
            this.borrowerdatetext.TabIndex = 7;
            // 
            // bookyeartext
            // 
            this.bookyeartext.AutoSize = true;
            this.bookyeartext.Location = new System.Drawing.Point(7, 115);
            this.bookyeartext.Name = "bookyeartext";
            this.bookyeartext.Size = new System.Drawing.Size(33, 13);
            this.bookyeartext.TabIndex = 6;
            this.bookyeartext.Text = "Date:";
            // 
            // borrowerbookidtext
            // 
            this.borrowerbookidtext.Location = new System.Drawing.Point(80, 86);
            this.borrowerbookidtext.Name = "borrowerbookidtext";
            this.borrowerbookidtext.Size = new System.Drawing.Size(137, 20);
            this.borrowerbookidtext.TabIndex = 5;
            // 
            // bookauthorlabel
            // 
            this.bookauthorlabel.AutoSize = true;
            this.bookauthorlabel.Location = new System.Drawing.Point(7, 89);
            this.bookauthorlabel.Name = "bookauthorlabel";
            this.bookauthorlabel.Size = new System.Drawing.Size(49, 13);
            this.bookauthorlabel.TabIndex = 4;
            this.bookauthorlabel.Text = "Book ID:";
            // 
            // borrowernametext
            // 
            this.borrowernametext.Location = new System.Drawing.Point(80, 53);
            this.borrowernametext.Name = "borrowernametext";
            this.borrowernametext.Size = new System.Drawing.Size(137, 20);
            this.borrowernametext.TabIndex = 3;
            // 
            // booknamelabel
            // 
            this.booknamelabel.AutoSize = true;
            this.booknamelabel.Location = new System.Drawing.Point(7, 60);
            this.booknamelabel.Name = "booknamelabel";
            this.booknamelabel.Size = new System.Drawing.Size(38, 13);
            this.booknamelabel.TabIndex = 2;
            this.booknamelabel.Text = "Name:";
            // 
            // borroweruseridtext
            // 
            this.borroweruseridtext.Location = new System.Drawing.Point(81, 21);
            this.borroweruseridtext.Name = "borroweruseridtext";
            this.borroweruseridtext.Size = new System.Drawing.Size(137, 20);
            this.borroweruseridtext.TabIndex = 1;
            // 
            // bookid
            // 
            this.bookid.AutoSize = true;
            this.bookid.Location = new System.Drawing.Point(7, 28);
            this.bookid.Name = "bookid";
            this.bookid.Size = new System.Drawing.Size(46, 13);
            this.bookid.TabIndex = 0;
            this.bookid.Text = "User ID:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchbookbutton);
            this.groupBox1.Controls.Add(this.borrowsearchusernametext);
            this.groupBox1.Controls.Add(this.borrowsearchuseridtext);
            this.groupBox1.Controls.Add(this.borrowerusernametextlabel);
            this.groupBox1.Controls.Add(this.borroweruseridtextlabel);
            this.groupBox1.Location = new System.Drawing.Point(570, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 111);
            this.groupBox1.TabIndex = 4;
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
            this.searchbookbutton.Click += new System.EventHandler(this.searchbookbutton_Click);
            // 
            // borrowsearchusernametext
            // 
            this.borrowsearchusernametext.Location = new System.Drawing.Point(80, 44);
            this.borrowsearchusernametext.Name = "borrowsearchusernametext";
            this.borrowsearchusernametext.Size = new System.Drawing.Size(137, 20);
            this.borrowsearchusernametext.TabIndex = 3;
            // 
            // borrowsearchuseridtext
            // 
            this.borrowsearchuseridtext.Location = new System.Drawing.Point(80, 14);
            this.borrowsearchuseridtext.Name = "borrowsearchuseridtext";
            this.borrowsearchuseridtext.Size = new System.Drawing.Size(137, 20);
            this.borrowsearchuseridtext.TabIndex = 2;
            // 
            // borrowerusernametextlabel
            // 
            this.borrowerusernametextlabel.AutoSize = true;
            this.borrowerusernametextlabel.Location = new System.Drawing.Point(8, 47);
            this.borrowerusernametextlabel.Name = "borrowerusernametextlabel";
            this.borrowerusernametextlabel.Size = new System.Drawing.Size(58, 13);
            this.borrowerusernametextlabel.TabIndex = 1;
            this.borrowerusernametextlabel.Text = "Username:";
            // 
            // borroweruseridtextlabel
            // 
            this.borroweruseridtextlabel.AutoSize = true;
            this.borroweruseridtextlabel.Location = new System.Drawing.Point(7, 18);
            this.borroweruseridtextlabel.Name = "borroweruseridtextlabel";
            this.borroweruseridtextlabel.Size = new System.Drawing.Size(46, 13);
            this.borroweruseridtextlabel.TabIndex = 0;
            this.borroweruseridtextlabel.Text = "User ID:";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 11;
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
            this.borrowerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.borrowerToolStripMenuItem.Text = "Home";
            this.borrowerToolStripMenuItem.Click += new System.EventHandler(this.borrowerToolStripMenuItem_Click);
            // 
            // booksToolStripMenuItem
            // 
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            this.booksToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            // borrower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.displayallborrowerbutton);
            this.Controls.Add(this.borrowergridview);
            this.Name = "borrower";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borrower";
            ((System.ComponentModel.ISupportInitialize)(this.borrowergridview)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView borrowergridview;
        private System.Windows.Forms.Button displayallborrowerbutton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button addborrowerbutton;
        private System.Windows.Forms.TextBox borrowerdatetext;
        private System.Windows.Forms.Label bookyeartext;
        private System.Windows.Forms.TextBox borrowerbookidtext;
        private System.Windows.Forms.Label bookauthorlabel;
        private System.Windows.Forms.TextBox borrowernametext;
        private System.Windows.Forms.Label booknamelabel;
        private System.Windows.Forms.TextBox borroweruseridtext;
        private System.Windows.Forms.Label bookid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button searchbookbutton;
        private System.Windows.Forms.TextBox borrowsearchusernametext;
        private System.Windows.Forms.TextBox borrowsearchuseridtext;
        private System.Windows.Forms.Label borrowerusernametextlabel;
        private System.Windows.Forms.Label borroweruseridtextlabel;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrowerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
    }
}