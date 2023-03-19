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
            this.gosignout = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.updatebutton = new System.Windows.Forms.Button();
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transactionToolStripMenuItem,
            this.gosignout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
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
            // gosignout
            // 
            this.gosignout.Name = "gosignout";
            this.gosignout.Size = new System.Drawing.Size(65, 20);
            this.gosignout.Text = "Sign Out";
            this.gosignout.Click += new System.EventHandler(this.gosignout_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.updatebutton);
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
            this.groupBox1.Location = new System.Drawing.Point(12, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 484);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // updatebutton
            // 
            this.updatebutton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.updatebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updatebutton.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(35)))), ((int)(((byte)(43)))));
            this.updatebutton.Location = new System.Drawing.Point(242, 399);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(136, 31);
            this.updatebutton.TabIndex = 17;
            this.updatebutton.Text = "Update Credentials";
            this.updatebutton.UseVisualStyleBackColor = true;
            this.updatebutton.Visible = false;
            this.updatebutton.Click += new System.EventHandler(this.updatebutton_Click);
            // 
            // booksreturnedtext
            // 
            this.booksreturnedtext.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.booksreturnedtext.Enabled = false;
            this.booksreturnedtext.Location = new System.Drawing.Point(178, 362);
            this.booksreturnedtext.Name = "booksreturnedtext";
            this.booksreturnedtext.ReadOnly = true;
            this.booksreturnedtext.Size = new System.Drawing.Size(200, 20);
            this.booksreturnedtext.TabIndex = 16;
            // 
            // booksborrowedtext
            // 
            this.booksborrowedtext.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.booksborrowedtext.Enabled = false;
            this.booksborrowedtext.Location = new System.Drawing.Point(178, 320);
            this.booksborrowedtext.Name = "booksborrowedtext";
            this.booksborrowedtext.ReadOnly = true;
            this.booksborrowedtext.Size = new System.Drawing.Size(200, 20);
            this.booksborrowedtext.TabIndex = 15;
            // 
            // contactnumbertext
            // 
            this.contactnumbertext.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contactnumbertext.Enabled = false;
            this.contactnumbertext.Location = new System.Drawing.Point(178, 280);
            this.contactnumbertext.Name = "contactnumbertext";
            this.contactnumbertext.ReadOnly = true;
            this.contactnumbertext.Size = new System.Drawing.Size(200, 20);
            this.contactnumbertext.TabIndex = 14;
            // 
            // lastnametext
            // 
            this.lastnametext.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lastnametext.Enabled = false;
            this.lastnametext.Location = new System.Drawing.Point(178, 240);
            this.lastnametext.Name = "lastnametext";
            this.lastnametext.ReadOnly = true;
            this.lastnametext.Size = new System.Drawing.Size(200, 20);
            this.lastnametext.TabIndex = 13;
            // 
            // firstnametext
            // 
            this.firstnametext.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.firstnametext.Enabled = false;
            this.firstnametext.Location = new System.Drawing.Point(178, 200);
            this.firstnametext.Name = "firstnametext";
            this.firstnametext.ReadOnly = true;
            this.firstnametext.Size = new System.Drawing.Size(200, 20);
            this.firstnametext.TabIndex = 12;
            // 
            // usernametext
            // 
            this.usernametext.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usernametext.Enabled = false;
            this.usernametext.Location = new System.Drawing.Point(178, 160);
            this.usernametext.Name = "usernametext";
            this.usernametext.ReadOnly = true;
            this.usernametext.Size = new System.Drawing.Size(200, 20);
            this.usernametext.TabIndex = 11;
            this.usernametext.TextChanged += new System.EventHandler(this.usernametext_TextChanged);
            // 
            // borrowerIDtext
            // 
            this.borrowerIDtext.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.borrowerIDtext.Enabled = false;
            this.borrowerIDtext.Location = new System.Drawing.Point(178, 120);
            this.borrowerIDtext.Name = "borrowerIDtext";
            this.borrowerIDtext.ReadOnly = true;
            this.borrowerIDtext.Size = new System.Drawing.Size(200, 20);
            this.borrowerIDtext.TabIndex = 10;
            this.borrowerIDtext.TextChanged += new System.EventHandler(this.borrowerIDtext_TextChanged);
            // 
            // booksreturnedlabel
            // 
            this.booksreturnedlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.booksreturnedlabel.AutoSize = true;
            this.booksreturnedlabel.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booksreturnedlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(35)))), ((int)(((byte)(43)))));
            this.booksreturnedlabel.Location = new System.Drawing.Point(27, 359);
            this.booksreturnedlabel.Name = "booksreturnedlabel";
            this.booksreturnedlabel.Size = new System.Drawing.Size(106, 16);
            this.booksreturnedlabel.TabIndex = 9;
            this.booksreturnedlabel.Text = "Book Returned:";
            // 
            // booksborrowedlabel
            // 
            this.booksborrowedlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.booksborrowedlabel.AutoSize = true;
            this.booksborrowedlabel.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booksborrowedlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(35)))), ((int)(((byte)(43)))));
            this.booksborrowedlabel.Location = new System.Drawing.Point(24, 319);
            this.booksborrowedlabel.Name = "booksborrowedlabel";
            this.booksborrowedlabel.Size = new System.Drawing.Size(117, 16);
            this.booksborrowedlabel.TabIndex = 8;
            this.booksborrowedlabel.Text = "Books Borrowed:";
            // 
            // contactnumberlabel
            // 
            this.contactnumberlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contactnumberlabel.AutoSize = true;
            this.contactnumberlabel.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactnumberlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(35)))), ((int)(((byte)(43)))));
            this.contactnumberlabel.Location = new System.Drawing.Point(24, 279);
            this.contactnumberlabel.Name = "contactnumberlabel";
            this.contactnumberlabel.Size = new System.Drawing.Size(114, 16);
            this.contactnumberlabel.TabIndex = 7;
            this.contactnumberlabel.Text = "Contact Number:";
            // 
            // lastnamelabel
            // 
            this.lastnamelabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lastnamelabel.AutoSize = true;
            this.lastnamelabel.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastnamelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(35)))), ((int)(((byte)(43)))));
            this.lastnamelabel.Location = new System.Drawing.Point(24, 239);
            this.lastnamelabel.Name = "lastnamelabel";
            this.lastnamelabel.Size = new System.Drawing.Size(78, 16);
            this.lastnamelabel.TabIndex = 6;
            this.lastnamelabel.Text = "Last Name:";
            // 
            // firstnamelabel
            // 
            this.firstnamelabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.firstnamelabel.AutoSize = true;
            this.firstnamelabel.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstnamelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(35)))), ((int)(((byte)(43)))));
            this.firstnamelabel.Location = new System.Drawing.Point(24, 199);
            this.firstnamelabel.Name = "firstnamelabel";
            this.firstnamelabel.Size = new System.Drawing.Size(76, 16);
            this.firstnamelabel.TabIndex = 5;
            this.firstnamelabel.Text = "First name:";
            // 
            // usernamelabel
            // 
            this.usernamelabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usernamelabel.AutoSize = true;
            this.usernamelabel.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(35)))), ((int)(((byte)(43)))));
            this.usernamelabel.Location = new System.Drawing.Point(24, 159);
            this.usernamelabel.Name = "usernamelabel";
            this.usernamelabel.Size = new System.Drawing.Size(74, 16);
            this.usernamelabel.TabIndex = 4;
            this.usernamelabel.Text = "Username:";
            // 
            // borrowerIDlabel
            // 
            this.borrowerIDlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.borrowerIDlabel.AutoSize = true;
            this.borrowerIDlabel.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowerIDlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(35)))), ((int)(((byte)(43)))));
            this.borrowerIDlabel.Location = new System.Drawing.Point(24, 119);
            this.borrowerIDlabel.Name = "borrowerIDlabel";
            this.borrowerIDlabel.Size = new System.Drawing.Size(90, 16);
            this.borrowerIDlabel.TabIndex = 3;
            this.borrowerIDlabel.Text = "Borrower ID:";
            // 
            // borrowbutton
            // 
            this.borrowbutton.BackColor = System.Drawing.Color.White;
            this.borrowbutton.FlatAppearance.BorderSize = 0;
            this.borrowbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borrowbutton.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold);
            this.borrowbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(35)))), ((int)(((byte)(43)))));
            this.borrowbutton.Location = new System.Drawing.Point(535, 162);
            this.borrowbutton.Name = "borrowbutton";
            this.borrowbutton.Size = new System.Drawing.Size(228, 80);
            this.borrowbutton.TabIndex = 3;
            this.borrowbutton.Text = "Borrow book";
            this.borrowbutton.UseVisualStyleBackColor = false;
            this.borrowbutton.Click += new System.EventHandler(this.borrowbutton_Click);
            // 
            // returnbookbutton
            // 
            this.returnbookbutton.BackColor = System.Drawing.Color.White;
            this.returnbookbutton.FlatAppearance.BorderSize = 0;
            this.returnbookbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnbookbutton.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold);
            this.returnbookbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(35)))), ((int)(((byte)(43)))));
            this.returnbookbutton.Location = new System.Drawing.Point(535, 263);
            this.returnbookbutton.Name = "returnbookbutton";
            this.returnbookbutton.Size = new System.Drawing.Size(228, 80);
            this.returnbookbutton.TabIndex = 4;
            this.returnbookbutton.Text = "Return book";
            this.returnbookbutton.UseVisualStyleBackColor = false;
            this.returnbookbutton.Click += new System.EventHandler(this.returnbookbutton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(145, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "User Personal Information";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Login.Properties.Resources.return_books;
            this.pictureBox2.Location = new System.Drawing.Point(478, 255);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(94, 89);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Login.Properties.Resources.borrow_book;
            this.pictureBox1.Location = new System.Drawing.Point(478, 160);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Login.Properties.Resources.user_creds_design;
            this.pictureBox3.Location = new System.Drawing.Point(30, 17);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(94, 88);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // userHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.returnbookbutton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.borrowbutton);
            this.Name = "userHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.userHome_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.Button updatebutton;
        private System.Windows.Forms.ToolStripMenuItem gosignout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}