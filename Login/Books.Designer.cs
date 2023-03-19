namespace Login
{
    partial class Books
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Books));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.booksdbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.booksdbDataSet = new Login.booksdbDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchbookbutton = new System.Windows.Forms.Button();
            this.authortext = new System.Windows.Forms.TextBox();
            this.booknametext = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.displayallbutton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.addbookbutton = new System.Windows.Forms.Button();
            this.addbookquantitytext = new System.Windows.Forms.TextBox();
            this.bookquantitylabel = new System.Windows.Forms.Label();
            this.addbookgenretext = new System.Windows.Forms.TextBox();
            this.bookgenrelabel = new System.Windows.Forms.Label();
            this.addyeartext = new System.Windows.Forms.TextBox();
            this.bookyeartext = new System.Windows.Forms.Label();
            this.addbookauthortext = new System.Windows.Forms.TextBox();
            this.bookauthorlabel = new System.Windows.Forms.Label();
            this.addbooknametext = new System.Windows.Forms.TextBox();
            this.booknamelabel = new System.Windows.Forms.Label();
            this.addbookidtext = new System.Windows.Forms.TextBox();
            this.bookid = new System.Windows.Forms.Label();
            this.booksdbDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksdbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksdbDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksdbDataSetBindingSource1)).BeginInit();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(638, 500);
            this.dataGridView1.TabIndex = 0;
            // 
            // booksdbDataSetBindingSource
            // 
            this.booksdbDataSetBindingSource.DataSource = this.booksdbDataSet;
            this.booksdbDataSetBindingSource.Position = 0;
            // 
            // booksdbDataSet
            // 
            this.booksdbDataSet.DataSetName = "booksdbDataSet";
            this.booksdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchbookbutton);
            this.groupBox1.Controls.Add(this.authortext);
            this.groupBox1.Controls.Add(this.booknametext);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(35)))), ((int)(((byte)(43)))));
            this.groupBox1.Location = new System.Drawing.Point(656, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 124);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // searchbookbutton
            // 
            this.searchbookbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchbookbutton.Location = new System.Drawing.Point(150, 85);
            this.searchbookbutton.Name = "searchbookbutton";
            this.searchbookbutton.Size = new System.Drawing.Size(87, 24);
            this.searchbookbutton.TabIndex = 4;
            this.searchbookbutton.Text = "Search";
            this.searchbookbutton.UseVisualStyleBackColor = true;
            this.searchbookbutton.Click += new System.EventHandler(this.searchbookbutton_Click);
            // 
            // authortext
            // 
            this.authortext.Location = new System.Drawing.Point(83, 53);
            this.authortext.Name = "authortext";
            this.authortext.Size = new System.Drawing.Size(154, 22);
            this.authortext.TabIndex = 3;
            // 
            // booknametext
            // 
            this.booknametext.Location = new System.Drawing.Point(83, 23);
            this.booknametext.Name = "booknametext";
            this.booknametext.Size = new System.Drawing.Size(154, 22);
            this.booknametext.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 9F);
            this.label2.Location = new System.Drawing.Point(11, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Author:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Name:";
            // 
            // displayallbutton
            // 
            this.displayallbutton.BackColor = System.Drawing.Color.White;
            this.displayallbutton.FlatAppearance.BorderSize = 0;
            this.displayallbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.displayallbutton.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold);
            this.displayallbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(35)))), ((int)(((byte)(43)))));
            this.displayallbutton.Location = new System.Drawing.Point(735, 36);
            this.displayallbutton.Name = "displayallbutton";
            this.displayallbutton.Size = new System.Drawing.Size(152, 31);
            this.displayallbutton.TabIndex = 2;
            this.displayallbutton.Text = "Display All Books";
            this.displayallbutton.UseVisualStyleBackColor = false;
            this.displayallbutton.Click += new System.EventHandler(this.displayallbutton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.addbookbutton);
            this.groupBox2.Controls.Add(this.addbookquantitytext);
            this.groupBox2.Controls.Add(this.bookquantitylabel);
            this.groupBox2.Controls.Add(this.addbookgenretext);
            this.groupBox2.Controls.Add(this.bookgenrelabel);
            this.groupBox2.Controls.Add(this.addyeartext);
            this.groupBox2.Controls.Add(this.bookyeartext);
            this.groupBox2.Controls.Add(this.addbookauthortext);
            this.groupBox2.Controls.Add(this.bookauthorlabel);
            this.groupBox2.Controls.Add(this.addbooknametext);
            this.groupBox2.Controls.Add(this.booknamelabel);
            this.groupBox2.Controls.Add(this.addbookidtext);
            this.groupBox2.Controls.Add(this.bookid);
            this.groupBox2.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(35)))), ((int)(((byte)(43)))));
            this.groupBox2.Location = new System.Drawing.Point(656, 250);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(253, 240);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // addbookbutton
            // 
            this.addbookbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addbookbutton.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F);
            this.addbookbutton.Location = new System.Drawing.Point(147, 208);
            this.addbookbutton.Name = "addbookbutton";
            this.addbookbutton.Size = new System.Drawing.Size(87, 23);
            this.addbookbutton.TabIndex = 12;
            this.addbookbutton.Text = "Add";
            this.addbookbutton.UseVisualStyleBackColor = true;
            this.addbookbutton.Click += new System.EventHandler(this.addbookbutton_Click);
            // 
            // addbookquantitytext
            // 
            this.addbookquantitytext.Location = new System.Drawing.Point(82, 172);
            this.addbookquantitytext.Name = "addbookquantitytext";
            this.addbookquantitytext.Size = new System.Drawing.Size(154, 21);
            this.addbookquantitytext.TabIndex = 11;
            // 
            // bookquantitylabel
            // 
            this.bookquantitylabel.AutoSize = true;
            this.bookquantitylabel.Location = new System.Drawing.Point(10, 173);
            this.bookquantitylabel.Name = "bookquantitylabel";
            this.bookquantitylabel.Size = new System.Drawing.Size(51, 13);
            this.bookquantitylabel.TabIndex = 10;
            this.bookquantitylabel.Text = "Quantity:";
            // 
            // addbookgenretext
            // 
            this.addbookgenretext.Location = new System.Drawing.Point(82, 142);
            this.addbookgenretext.Name = "addbookgenretext";
            this.addbookgenretext.Size = new System.Drawing.Size(154, 21);
            this.addbookgenretext.TabIndex = 9;
            // 
            // bookgenrelabel
            // 
            this.bookgenrelabel.AutoSize = true;
            this.bookgenrelabel.Location = new System.Drawing.Point(8, 143);
            this.bookgenrelabel.Name = "bookgenrelabel";
            this.bookgenrelabel.Size = new System.Drawing.Size(39, 13);
            this.bookgenrelabel.TabIndex = 8;
            this.bookgenrelabel.Text = "Genre:";
            // 
            // addyeartext
            // 
            this.addyeartext.Location = new System.Drawing.Point(82, 114);
            this.addyeartext.Name = "addyeartext";
            this.addyeartext.Size = new System.Drawing.Size(154, 21);
            this.addyeartext.TabIndex = 7;
            // 
            // bookyeartext
            // 
            this.bookyeartext.AutoSize = true;
            this.bookyeartext.Location = new System.Drawing.Point(7, 115);
            this.bookyeartext.Name = "bookyeartext";
            this.bookyeartext.Size = new System.Drawing.Size(33, 13);
            this.bookyeartext.TabIndex = 6;
            this.bookyeartext.Text = "Year:";
            // 
            // addbookauthortext
            // 
            this.addbookauthortext.Location = new System.Drawing.Point(82, 85);
            this.addbookauthortext.Name = "addbookauthortext";
            this.addbookauthortext.Size = new System.Drawing.Size(154, 21);
            this.addbookauthortext.TabIndex = 5;
            // 
            // bookauthorlabel
            // 
            this.bookauthorlabel.AutoSize = true;
            this.bookauthorlabel.Location = new System.Drawing.Point(7, 89);
            this.bookauthorlabel.Name = "bookauthorlabel";
            this.bookauthorlabel.Size = new System.Drawing.Size(73, 13);
            this.bookauthorlabel.TabIndex = 4;
            this.bookauthorlabel.Text = "Book Author:";
            // 
            // addbooknametext
            // 
            this.addbooknametext.Location = new System.Drawing.Point(82, 52);
            this.addbooknametext.Name = "addbooknametext";
            this.addbooknametext.Size = new System.Drawing.Size(154, 21);
            this.addbooknametext.TabIndex = 3;
            // 
            // booknamelabel
            // 
            this.booknamelabel.AutoSize = true;
            this.booknamelabel.Location = new System.Drawing.Point(7, 60);
            this.booknamelabel.Name = "booknamelabel";
            this.booknamelabel.Size = new System.Drawing.Size(67, 13);
            this.booknamelabel.TabIndex = 2;
            this.booknamelabel.Text = "Book Name:";
            this.booknamelabel.Click += new System.EventHandler(this.booknamelabel_Click);
            // 
            // addbookidtext
            // 
            this.addbookidtext.Location = new System.Drawing.Point(83, 20);
            this.addbookidtext.Name = "addbookidtext";
            this.addbookidtext.Size = new System.Drawing.Size(154, 21);
            this.addbookidtext.TabIndex = 1;
            // 
            // bookid
            // 
            this.bookid.AutoSize = true;
            this.bookid.Location = new System.Drawing.Point(7, 28);
            this.bookid.Name = "bookid";
            this.bookid.Size = new System.Drawing.Size(52, 13);
            this.bookid.TabIndex = 0;
            this.bookid.Text = "Book ID:";
            // 
            // booksdbDataSetBindingSource1
            // 
            this.booksdbDataSetBindingSource1.DataSource = this.booksdbDataSet;
            this.booksdbDataSetBindingSource1.Position = 0;
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
            this.borrowerToolStripMenuItem.Text = "Home";
            this.borrowerToolStripMenuItem.Click += new System.EventHandler(this.borrowerToolStripMenuItem_Click);
            // 
            // booksToolStripMenuItem
            // 
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            this.booksToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.booksToolStripMenuItem.Text = "Borrower";
            this.booksToolStripMenuItem.Click += new System.EventHandler(this.booksToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.reportToolStripMenuItem.Text = "Report";
            this.reportToolStripMenuItem.Click += new System.EventHandler(this.reportToolStripMenuItem_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(921, 24);
            this.menuStrip2.TabIndex = 12;
            this.menuStrip2.Text = "menuStrip2";
            this.menuStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Login.Properties.Resources.display_all_books;
            this.pictureBox1.Location = new System.Drawing.Point(663, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(921, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.displayallbutton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Books";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Books";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksdbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksdbDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksdbDataSetBindingSource1)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource booksdbDataSetBindingSource;
        private booksdbDataSet booksdbDataSet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button searchbookbutton;
        private System.Windows.Forms.TextBox authortext;
        private System.Windows.Forms.TextBox booknametext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button displayallbutton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource booksdbDataSetBindingSource1;
        private System.Windows.Forms.TextBox addbooknametext;
        private System.Windows.Forms.Label booknamelabel;
        private System.Windows.Forms.TextBox addbookidtext;
        private System.Windows.Forms.Label bookid;
        private System.Windows.Forms.Button addbookbutton;
        private System.Windows.Forms.TextBox addbookquantitytext;
        private System.Windows.Forms.Label bookquantitylabel;
        private System.Windows.Forms.TextBox addbookgenretext;
        private System.Windows.Forms.Label bookgenrelabel;
        private System.Windows.Forms.TextBox addyeartext;
        private System.Windows.Forms.Label bookyeartext;
        private System.Windows.Forms.TextBox addbookauthortext;
        private System.Windows.Forms.Label bookauthorlabel;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrowerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}