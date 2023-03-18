namespace Login
{
    partial class userHome
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.updateinfobutton = new System.Windows.Forms.Button();
            this.booksreturnedtext = new System.Windows.Forms.TextBox();
            this.booksborrowedtext = new System.Windows.Forms.TextBox();
            this.contactnumbertext = new System.Windows.Forms.TextBox();
            this.lastnametext = new System.Windows.Forms.TextBox();
            this.firstnametext = new System.Windows.Forms.TextBox();
            this.usernametext = new System.Windows.Forms.TextBox();
            this.borrowerIDtext = new System.Windows.Forms.TextBox();
            this.booksreturnedlabel = new System.Windows.Forms.Label();
            this.booksborrowedlabel = new System.Windows.Forms.Label();
            this.contactnumberlabel = new System.Windows.Forms.Label();
            this.lastnamelabel = new System.Windows.Forms.Label();
            this.firstnamelabel = new System.Windows.Forms.Label();
            this.usernamelabel = new System.Windows.Forms.Label();
            this.borrowerIDlabel = new System.Windows.Forms.Label();
            this.borrowbutton = new System.Windows.Forms.Button();
            this.returnbookbutton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transactionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(747, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.borrowToolStripMenuItem,
            this.returnToolStripMenuItem});
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.transactionToolStripMenuItem.Text = "Transaction";
            // 
            // borrowToolStripMenuItem
            // 
            this.borrowToolStripMenuItem.Name = "borrowToolStripMenuItem";
            this.borrowToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.borrowToolStripMenuItem.Text = "Borrow";
            this.borrowToolStripMenuItem.Click += new System.EventHandler(this.borrowToolStripMenuItem_Click);
            // 
            // returnToolStripMenuItem
            // 
            this.returnToolStripMenuItem.Name = "returnToolStripMenuItem";
            this.returnToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.returnToolStripMenuItem.Text = "Return";
            this.returnToolStripMenuItem.Click += new System.EventHandler(this.returnToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.updateinfobutton);
            this.groupBox1.Controls.Add(this.booksreturnedtext);
            this.groupBox1.Controls.Add(this.booksborrowedtext);
            this.groupBox1.Controls.Add(this.contactnumbertext);
            this.groupBox1.Controls.Add(this.lastnametext);
            this.groupBox1.Controls.Add(this.firstnametext);
            this.groupBox1.Controls.Add(this.usernametext);
            this.groupBox1.Controls.Add(this.borrowerIDtext);
            this.groupBox1.Controls.Add(this.booksreturnedlabel);
            this.groupBox1.Controls.Add(this.booksborrowedlabel);
            this.groupBox1.Controls.Add(this.contactnumberlabel);
            this.groupBox1.Controls.Add(this.lastnamelabel);
            this.groupBox1.Controls.Add(this.firstnamelabel);
            this.groupBox1.Controls.Add(this.usernamelabel);
            this.groupBox1.Controls.Add(this.borrowerIDlabel);
            this.groupBox1.Location = new System.Drawing.Point(26, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 336);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // updateinfobutton
            // 
            this.updateinfobutton.Location = new System.Drawing.Point(258, 304);
            this.updateinfobutton.Name = "updateinfobutton";
            this.updateinfobutton.Size = new System.Drawing.Size(108, 23);
            this.updateinfobutton.TabIndex = 17;
            this.updateinfobutton.Text = "Update Information";
            this.updateinfobutton.UseVisualStyleBackColor = true;
            this.updateinfobutton.Visible = false;
            // 
            // booksreturnedtext
            // 
            this.booksreturnedtext.Location = new System.Drawing.Point(160, 268);
            this.booksreturnedtext.Name = "booksreturnedtext";
            this.booksreturnedtext.Size = new System.Drawing.Size(206, 20);
            this.booksreturnedtext.TabIndex = 16;
            // 
            // booksborrowedtext
            // 
            this.booksborrowedtext.Location = new System.Drawing.Point(160, 226);
            this.booksborrowedtext.Name = "booksborrowedtext";
            this.booksborrowedtext.Size = new System.Drawing.Size(206, 20);
            this.booksborrowedtext.TabIndex = 15;
            // 
            // contactnumbertext
            // 
            this.contactnumbertext.Location = new System.Drawing.Point(160, 186);
            this.contactnumbertext.Name = "contactnumbertext";
            this.contactnumbertext.Size = new System.Drawing.Size(206, 20);
            this.contactnumbertext.TabIndex = 14;
            // 
            // lastnametext
            // 
            this.lastnametext.Location = new System.Drawing.Point(160, 146);
            this.lastnametext.Name = "lastnametext";
            this.lastnametext.Size = new System.Drawing.Size(206, 20);
            this.lastnametext.TabIndex = 13;
            // 
            // firstnametext
            // 
            this.firstnametext.Location = new System.Drawing.Point(160, 106);
            this.firstnametext.Name = "firstnametext";
            this.firstnametext.Size = new System.Drawing.Size(206, 20);
            this.firstnametext.TabIndex = 12;
            // 
            // usernametext
            // 
            this.usernametext.Location = new System.Drawing.Point(160, 66);
            this.usernametext.Name = "usernametext";
            this.usernametext.Size = new System.Drawing.Size(206, 20);
            this.usernametext.TabIndex = 11;
            this.usernametext.TextChanged += new System.EventHandler(this.usernametext_TextChanged);
            // 
            // borrowerIDtext
            // 
            this.borrowerIDtext.Location = new System.Drawing.Point(160, 26);
            this.borrowerIDtext.Name = "borrowerIDtext";
            this.borrowerIDtext.Size = new System.Drawing.Size(206, 20);
            this.borrowerIDtext.TabIndex = 10;
            this.borrowerIDtext.TextChanged += new System.EventHandler(this.borrowerIDtext_TextChanged);
            // 
            // booksreturnedlabel
            // 
            this.booksreturnedlabel.AutoSize = true;
            this.booksreturnedlabel.Location = new System.Drawing.Point(32, 269);
            this.booksreturnedlabel.Name = "booksreturnedlabel";
            this.booksreturnedlabel.Size = new System.Drawing.Size(82, 13);
            this.booksreturnedlabel.TabIndex = 9;
            this.booksreturnedlabel.Text = "Book Returned:";
            // 
            // booksborrowedlabel
            // 
            this.booksborrowedlabel.AutoSize = true;
            this.booksborrowedlabel.Location = new System.Drawing.Point(29, 229);
            this.booksborrowedlabel.Name = "booksborrowedlabel";
            this.booksborrowedlabel.Size = new System.Drawing.Size(88, 13);
            this.booksborrowedlabel.TabIndex = 8;
            this.booksborrowedlabel.Text = "Books Borrowed:";
            // 
            // contactnumberlabel
            // 
            this.contactnumberlabel.AutoSize = true;
            this.contactnumberlabel.Location = new System.Drawing.Point(29, 189);
            this.contactnumberlabel.Name = "contactnumberlabel";
            this.contactnumberlabel.Size = new System.Drawing.Size(87, 13);
            this.contactnumberlabel.TabIndex = 7;
            this.contactnumberlabel.Text = "Contact Number:";
            // 
            // lastnamelabel
            // 
            this.lastnamelabel.AutoSize = true;
            this.lastnamelabel.Location = new System.Drawing.Point(29, 149);
            this.lastnamelabel.Name = "lastnamelabel";
            this.lastnamelabel.Size = new System.Drawing.Size(61, 13);
            this.lastnamelabel.TabIndex = 6;
            this.lastnamelabel.Text = "Last Name:";
            // 
            // firstnamelabel
            // 
            this.firstnamelabel.AutoSize = true;
            this.firstnamelabel.Location = new System.Drawing.Point(29, 109);
            this.firstnamelabel.Name = "firstnamelabel";
            this.firstnamelabel.Size = new System.Drawing.Size(58, 13);
            this.firstnamelabel.TabIndex = 5;
            this.firstnamelabel.Text = "First name:";
            // 
            // usernamelabel
            // 
            this.usernamelabel.AutoSize = true;
            this.usernamelabel.Location = new System.Drawing.Point(29, 69);
            this.usernamelabel.Name = "usernamelabel";
            this.usernamelabel.Size = new System.Drawing.Size(58, 13);
            this.usernamelabel.TabIndex = 4;
            this.usernamelabel.Text = "Username:";
            // 
            // borrowerIDlabel
            // 
            this.borrowerIDlabel.AutoSize = true;
            this.borrowerIDlabel.Location = new System.Drawing.Point(29, 29);
            this.borrowerIDlabel.Name = "borrowerIDlabel";
            this.borrowerIDlabel.Size = new System.Drawing.Size(66, 13);
            this.borrowerIDlabel.TabIndex = 3;
            this.borrowerIDlabel.Text = "Borrower ID:";
            // 
            // borrowbutton
            // 
            this.borrowbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.borrowbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.borrowbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowbutton.Location = new System.Drawing.Point(487, 87);
            this.borrowbutton.Name = "borrowbutton";
            this.borrowbutton.Size = new System.Drawing.Size(228, 80);
            this.borrowbutton.TabIndex = 3;
            this.borrowbutton.Text = "Borrow book";
            this.borrowbutton.UseVisualStyleBackColor = false;
            this.borrowbutton.Click += new System.EventHandler(this.borrowbutton_Click);
            // 
            // returnbookbutton
            // 
            this.returnbookbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.returnbookbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.returnbookbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnbookbutton.Location = new System.Drawing.Point(487, 236);
            this.returnbookbutton.Name = "returnbookbutton";
            this.returnbookbutton.Size = new System.Drawing.Size(228, 80);
            this.returnbookbutton.TabIndex = 4;
            this.returnbookbutton.Text = "Return book";
            this.returnbookbutton.UseVisualStyleBackColor = false;
            this.returnbookbutton.Click += new System.EventHandler(this.returnbookbutton_Click);
            // 
            // userHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 406);
            this.Controls.Add(this.returnbookbutton);
            this.Controls.Add(this.borrowbutton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "userHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.userHome_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button updateinfobutton;
        private System.Windows.Forms.TextBox booksreturnedtext;
        private System.Windows.Forms.TextBox booksborrowedtext;
        private System.Windows.Forms.TextBox contactnumbertext;
        private System.Windows.Forms.TextBox lastnametext;
        private System.Windows.Forms.TextBox firstnametext;
        private System.Windows.Forms.TextBox borrowerIDtext;
        private System.Windows.Forms.Label booksreturnedlabel;
        private System.Windows.Forms.Label booksborrowedlabel;
        private System.Windows.Forms.Label contactnumberlabel;
        private System.Windows.Forms.Label lastnamelabel;
        private System.Windows.Forms.Label firstnamelabel;
        private System.Windows.Forms.Label usernamelabel;
        private System.Windows.Forms.Label borrowerIDlabel;
        private System.Windows.Forms.Button borrowbutton;
        private System.Windows.Forms.Button returnbookbutton;
        public System.Windows.Forms.TextBox usernametext;
    }
}