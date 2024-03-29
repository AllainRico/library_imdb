﻿namespace Login
{
    partial class Borrow
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
            this.components = new System.ComponentModel.Container();
            this.booksgridview = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.borrowbookbutton = new System.Windows.Forms.Button();
            this.borrowbookauthortext = new System.Windows.Forms.TextBox();
            this.bookauthorlabel = new System.Windows.Forms.Label();
            this.borrowbooknametext = new System.Windows.Forms.TextBox();
            this.booknamelabel = new System.Windows.Forms.Label();
            this.borrowbookidtext = new System.Windows.Forms.TextBox();
            this.bookid = new System.Windows.Forms.Label();
            this.displayallbooksbutton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchbookbutton = new System.Windows.Forms.Button();
            this.authortext = new System.Windows.Forms.TextBox();
            this.booknametext = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.libsysdbDataSet = new Login.libsysdbDataSet();
            this.booksTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.booksTableTableAdapter = new Login.libsysdbDataSetTableAdapters.booksTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.booksgridview)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.libsysdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // booksgridview
            // 
            this.booksgridview.AllowUserToAddRows = false;
            this.booksgridview.AllowUserToDeleteRows = false;
            this.booksgridview.BackgroundColor = System.Drawing.Color.White;
            this.booksgridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksgridview.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.booksgridview.Location = new System.Drawing.Point(12, 28);
            this.booksgridview.Name = "booksgridview";
            this.booksgridview.ReadOnly = true;
            this.booksgridview.Size = new System.Drawing.Size(552, 421);
            this.booksgridview.TabIndex = 13;
            this.booksgridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.booksgridview_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transactionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 14;
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
            this.borrowToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.borrowToolStripMenuItem.Text = "Home";
            // 
            // returnToolStripMenuItem
            // 
            this.returnToolStripMenuItem.Name = "returnToolStripMenuItem";
            this.returnToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.returnToolStripMenuItem.Text = "Return";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.borrowbookbutton);
            this.groupBox2.Controls.Add(this.borrowbookauthortext);
            this.groupBox2.Controls.Add(this.bookauthorlabel);
            this.groupBox2.Controls.Add(this.borrowbooknametext);
            this.groupBox2.Controls.Add(this.booknamelabel);
            this.groupBox2.Controls.Add(this.borrowbookidtext);
            this.groupBox2.Controls.Add(this.bookid);
            this.groupBox2.Location = new System.Drawing.Point(570, 201);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(223, 154);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            // 
            // borrowbookbutton
            // 
            this.borrowbookbutton.Location = new System.Drawing.Point(147, 114);
            this.borrowbookbutton.Name = "borrowbookbutton";
            this.borrowbookbutton.Size = new System.Drawing.Size(70, 23);
            this.borrowbookbutton.TabIndex = 12;
            this.borrowbookbutton.Text = "Borrow";
            this.borrowbookbutton.UseVisualStyleBackColor = true;
            this.borrowbookbutton.Click += new System.EventHandler(this.borrowbookbutton_Click);
            // 
            // borrowbookauthortext
            // 
            this.borrowbookauthortext.Location = new System.Drawing.Point(80, 86);
            this.borrowbookauthortext.Name = "borrowbookauthortext";
            this.borrowbookauthortext.ReadOnly = true;
            this.borrowbookauthortext.Size = new System.Drawing.Size(137, 20);
            this.borrowbookauthortext.TabIndex = 5;
            // 
            // bookauthorlabel
            // 
            this.bookauthorlabel.AutoSize = true;
            this.bookauthorlabel.Location = new System.Drawing.Point(7, 89);
            this.bookauthorlabel.Name = "bookauthorlabel";
            this.bookauthorlabel.Size = new System.Drawing.Size(69, 13);
            this.bookauthorlabel.TabIndex = 4;
            this.bookauthorlabel.Text = "Book Author:";
            // 
            // borrowbooknametext
            // 
            this.borrowbooknametext.Location = new System.Drawing.Point(80, 53);
            this.borrowbooknametext.Name = "borrowbooknametext";
            this.borrowbooknametext.ReadOnly = true;
            this.borrowbooknametext.Size = new System.Drawing.Size(137, 20);
            this.borrowbooknametext.TabIndex = 3;
            // 
            // booknamelabel
            // 
            this.booknamelabel.AutoSize = true;
            this.booknamelabel.Location = new System.Drawing.Point(7, 60);
            this.booknamelabel.Name = "booknamelabel";
            this.booknamelabel.Size = new System.Drawing.Size(66, 13);
            this.booknamelabel.TabIndex = 2;
            this.booknamelabel.Text = "Book Name:";
            // 
            // borrowbookidtext
            // 
            this.borrowbookidtext.Location = new System.Drawing.Point(81, 21);
            this.borrowbookidtext.Name = "borrowbookidtext";
            this.borrowbookidtext.ReadOnly = true;
            this.borrowbookidtext.Size = new System.Drawing.Size(137, 20);
            this.borrowbookidtext.TabIndex = 1;
            // 
            // bookid
            // 
            this.bookid.AutoSize = true;
            this.bookid.Location = new System.Drawing.Point(7, 28);
            this.bookid.Name = "bookid";
            this.bookid.Size = new System.Drawing.Size(49, 13);
            this.bookid.TabIndex = 0;
            this.bookid.Text = "Book ID:";
            // 
            // displayallbooksbutton
            // 
            this.displayallbooksbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.displayallbooksbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.displayallbooksbutton.Location = new System.Drawing.Point(570, 44);
            this.displayallbooksbutton.Name = "displayallbooksbutton";
            this.displayallbooksbutton.Size = new System.Drawing.Size(223, 31);
            this.displayallbooksbutton.TabIndex = 16;
            this.displayallbooksbutton.Text = "Display All Books";
            this.displayallbooksbutton.UseVisualStyleBackColor = false;
            this.displayallbooksbutton.Click += new System.EventHandler(this.displayallbooksbutton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchbookbutton);
            this.groupBox1.Controls.Add(this.authortext);
            this.groupBox1.Controls.Add(this.booknametext);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(570, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 111);
            this.groupBox1.TabIndex = 15;
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
            // authortext
            // 
            this.authortext.Location = new System.Drawing.Point(80, 44);
            this.authortext.Name = "authortext";
            this.authortext.Size = new System.Drawing.Size(137, 20);
            this.authortext.TabIndex = 3;
            // 
            // booknametext
            // 
            this.booknametext.Location = new System.Drawing.Point(80, 14);
            this.booknametext.Name = "booknametext";
            this.booknametext.Size = new System.Drawing.Size(137, 20);
            this.booknametext.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Author:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Name:";
            // 
            // libsysdbDataSet
            // 
            this.libsysdbDataSet.DataSetName = "libsysdbDataSet";
            this.libsysdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // booksTableBindingSource
            // 
            this.booksTableBindingSource.DataMember = "booksTable";
            this.booksTableBindingSource.DataSource = this.libsysdbDataSet;
            // 
            // booksTableTableAdapter
            // 
            this.booksTableTableAdapter.ClearBeforeFill = true;
            // 
            // Borrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.displayallbooksbutton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.booksgridview);
            this.Name = "Borrow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borrow";
            this.Load += new System.EventHandler(this.Borrow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.booksgridview)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.libsysdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView booksgridview;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button borrowbookbutton;
        private System.Windows.Forms.TextBox borrowbookauthortext;
        private System.Windows.Forms.Label bookauthorlabel;
        private System.Windows.Forms.TextBox borrowbooknametext;
        private System.Windows.Forms.Label booknamelabel;
        private System.Windows.Forms.TextBox borrowbookidtext;
        private System.Windows.Forms.Label bookid;
        private System.Windows.Forms.Button displayallbooksbutton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button searchbookbutton;
        private System.Windows.Forms.TextBox authortext;
        private System.Windows.Forms.TextBox booknametext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private libsysdbDataSet libsysdbDataSet;
        private System.Windows.Forms.BindingSource booksTableBindingSource;
        private libsysdbDataSetTableAdapters.booksTableTableAdapter booksTableTableAdapter;
    }
}