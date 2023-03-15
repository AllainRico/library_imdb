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
            this.usercontactnumbertext = new System.Windows.Forms.TextBox();
            this.contactnumbertext = new System.Windows.Forms.Label();
            this.userlastnametext = new System.Windows.Forms.TextBox();
            this.userlastnamelabel = new System.Windows.Forms.Label();
            this.userfirstnametext = new System.Windows.Forms.TextBox();
            this.userfirstnamelabel = new System.Windows.Forms.Label();
            this.borroweruseridtext = new System.Windows.Forms.TextBox();
            this.userID = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchbookbutton = new System.Windows.Forms.Button();
            this.usersearchfirstname = new System.Windows.Forms.TextBox();
            this.borrowsearchuseridtext = new System.Windows.Forms.TextBox();
            this.userfirstnametextlabel = new System.Windows.Forms.Label();
            this.borroweruseridtextlabel = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.userlastnametextlabel = new System.Windows.Forms.Label();
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
            this.groupBox2.Controls.Add(this.usercontactnumbertext);
            this.groupBox2.Controls.Add(this.contactnumbertext);
            this.groupBox2.Controls.Add(this.userlastnametext);
            this.groupBox2.Controls.Add(this.userlastnamelabel);
            this.groupBox2.Controls.Add(this.userfirstnametext);
            this.groupBox2.Controls.Add(this.userfirstnamelabel);
            this.groupBox2.Controls.Add(this.borroweruseridtext);
            this.groupBox2.Controls.Add(this.userID);
            this.groupBox2.Location = new System.Drawing.Point(570, 228);
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
            // usercontactnumbertext
            // 
            this.usercontactnumbertext.Location = new System.Drawing.Point(100, 115);
            this.usercontactnumbertext.Name = "usercontactnumbertext";
            this.usercontactnumbertext.Size = new System.Drawing.Size(117, 20);
            this.usercontactnumbertext.TabIndex = 7;
            // 
            // contactnumbertext
            // 
            this.contactnumbertext.AutoSize = true;
            this.contactnumbertext.Location = new System.Drawing.Point(7, 115);
            this.contactnumbertext.Name = "contactnumbertext";
            this.contactnumbertext.Size = new System.Drawing.Size(87, 13);
            this.contactnumbertext.TabIndex = 6;
            this.contactnumbertext.Text = "Contact Number:";
            // 
            // userlastnametext
            // 
            this.userlastnametext.Location = new System.Drawing.Point(100, 86);
            this.userlastnametext.Name = "userlastnametext";
            this.userlastnametext.Size = new System.Drawing.Size(117, 20);
            this.userlastnametext.TabIndex = 5;
            // 
            // userlastnamelabel
            // 
            this.userlastnamelabel.AutoSize = true;
            this.userlastnamelabel.Location = new System.Drawing.Point(7, 89);
            this.userlastnamelabel.Name = "userlastnamelabel";
            this.userlastnamelabel.Size = new System.Drawing.Size(61, 13);
            this.userlastnamelabel.TabIndex = 4;
            this.userlastnamelabel.Text = "Last Name:";
            // 
            // userfirstnametext
            // 
            this.userfirstnametext.Location = new System.Drawing.Point(100, 53);
            this.userfirstnametext.Name = "userfirstnametext";
            this.userfirstnametext.Size = new System.Drawing.Size(117, 20);
            this.userfirstnametext.TabIndex = 3;
            // 
            // userfirstnamelabel
            // 
            this.userfirstnamelabel.AutoSize = true;
            this.userfirstnamelabel.Location = new System.Drawing.Point(7, 60);
            this.userfirstnamelabel.Name = "userfirstnamelabel";
            this.userfirstnamelabel.Size = new System.Drawing.Size(60, 13);
            this.userfirstnamelabel.TabIndex = 2;
            this.userfirstnamelabel.Text = "First Name:";
            // 
            // borroweruseridtext
            // 
            this.borroweruseridtext.Location = new System.Drawing.Point(101, 21);
            this.borroweruseridtext.Name = "borroweruseridtext";
            this.borroweruseridtext.Size = new System.Drawing.Size(117, 20);
            this.borroweruseridtext.TabIndex = 1;
            // 
            // userID
            // 
            this.userID.AutoSize = true;
            this.userID.Location = new System.Drawing.Point(7, 28);
            this.userID.Name = "userID";
            this.userID.Size = new System.Drawing.Size(46, 13);
            this.userID.TabIndex = 0;
            this.userID.Text = "User ID:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.userlastnametextlabel);
            this.groupBox1.Controls.Add(this.searchbookbutton);
            this.groupBox1.Controls.Add(this.usersearchfirstname);
            this.groupBox1.Controls.Add(this.borrowsearchuseridtext);
            this.groupBox1.Controls.Add(this.userfirstnametextlabel);
            this.groupBox1.Controls.Add(this.borroweruseridtextlabel);
            this.groupBox1.Location = new System.Drawing.Point(570, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 135);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // searchbookbutton
            // 
            this.searchbookbutton.Location = new System.Drawing.Point(147, 97);
            this.searchbookbutton.Name = "searchbookbutton";
            this.searchbookbutton.Size = new System.Drawing.Size(70, 24);
            this.searchbookbutton.TabIndex = 4;
            this.searchbookbutton.Text = "Search";
            this.searchbookbutton.UseVisualStyleBackColor = true;
            this.searchbookbutton.Click += new System.EventHandler(this.searchbookbutton_Click);
            // 
            // usersearchfirstname
            // 
            this.usersearchfirstname.Location = new System.Drawing.Point(80, 44);
            this.usersearchfirstname.Name = "usersearchfirstname";
            this.usersearchfirstname.Size = new System.Drawing.Size(137, 20);
            this.usersearchfirstname.TabIndex = 3;
            // 
            // borrowsearchuseridtext
            // 
            this.borrowsearchuseridtext.Location = new System.Drawing.Point(80, 14);
            this.borrowsearchuseridtext.Name = "borrowsearchuseridtext";
            this.borrowsearchuseridtext.Size = new System.Drawing.Size(137, 20);
            this.borrowsearchuseridtext.TabIndex = 2;
            // 
            // userfirstnametextlabel
            // 
            this.userfirstnametextlabel.AutoSize = true;
            this.userfirstnametextlabel.Location = new System.Drawing.Point(8, 47);
            this.userfirstnametextlabel.Name = "userfirstnametextlabel";
            this.userfirstnametextlabel.Size = new System.Drawing.Size(58, 13);
            this.userfirstnametextlabel.TabIndex = 1;
            this.userfirstnametextlabel.Text = "First name:";
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
            this.borrowerToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.borrowerToolStripMenuItem.Text = "Home";
            this.borrowerToolStripMenuItem.Click += new System.EventHandler(this.borrowerToolStripMenuItem_Click);
            // 
            // booksToolStripMenuItem
            // 
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            this.booksToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(79, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 20);
            this.textBox1.TabIndex = 6;
            // 
            // userlastnametextlabel
            // 
            this.userlastnametextlabel.AutoSize = true;
            this.userlastnametextlabel.Location = new System.Drawing.Point(7, 75);
            this.userlastnametextlabel.Name = "userlastnametextlabel";
            this.userlastnametextlabel.Size = new System.Drawing.Size(59, 13);
            this.userlastnametextlabel.TabIndex = 5;
            this.userlastnametextlabel.Text = "Last name:";
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
        private System.Windows.Forms.TextBox usercontactnumbertext;
        private System.Windows.Forms.Label contactnumbertext;
        private System.Windows.Forms.TextBox userlastnametext;
        private System.Windows.Forms.Label userlastnamelabel;
        private System.Windows.Forms.TextBox userfirstnametext;
        private System.Windows.Forms.Label userfirstnamelabel;
        private System.Windows.Forms.TextBox borroweruseridtext;
        private System.Windows.Forms.Label userID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button searchbookbutton;
        private System.Windows.Forms.TextBox usersearchfirstname;
        private System.Windows.Forms.TextBox borrowsearchuseridtext;
        private System.Windows.Forms.Label userfirstnametextlabel;
        private System.Windows.Forms.Label borroweruseridtextlabel;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrowerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label userlastnametextlabel;
    }
}