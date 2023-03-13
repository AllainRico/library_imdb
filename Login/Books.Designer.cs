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
            this.borrowbutton = new System.Windows.Forms.Button();
            this.booksdbDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksdbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksdbDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksdbDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(552, 426);
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
            this.groupBox1.Controls.Add(this.borrowbutton);
            this.groupBox1.Controls.Add(this.searchbookbutton);
            this.groupBox1.Controls.Add(this.authortext);
            this.groupBox1.Controls.Add(this.booknametext);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(570, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 118);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // searchbookbutton
            // 
            this.searchbookbutton.Location = new System.Drawing.Point(84, 79);
            this.searchbookbutton.Name = "searchbookbutton";
            this.searchbookbutton.Size = new System.Drawing.Size(55, 24);
            this.searchbookbutton.TabIndex = 4;
            this.searchbookbutton.Text = "Search";
            this.searchbookbutton.UseVisualStyleBackColor = true;
            this.searchbookbutton.Click += new System.EventHandler(this.searchbookbutton_Click);
            // 
            // authortext
            // 
            this.authortext.Location = new System.Drawing.Point(80, 50);
            this.authortext.Name = "authortext";
            this.authortext.Size = new System.Drawing.Size(137, 20);
            this.authortext.TabIndex = 3;
            // 
            // booknametext
            // 
            this.booknametext.Location = new System.Drawing.Point(80, 20);
            this.booknametext.Name = "booknametext";
            this.booknametext.Size = new System.Drawing.Size(137, 20);
            this.booknametext.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Author:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Name:";
            // 
            // displayallbutton
            // 
            this.displayallbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.displayallbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.displayallbutton.Location = new System.Drawing.Point(570, 29);
            this.displayallbutton.Name = "displayallbutton";
            this.displayallbutton.Size = new System.Drawing.Size(223, 31);
            this.displayallbutton.TabIndex = 2;
            this.displayallbutton.Text = "Display All Books";
            this.displayallbutton.UseVisualStyleBackColor = false;
            this.displayallbutton.Click += new System.EventHandler(this.displayallbutton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(570, 267);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(223, 140);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // borrowbutton
            // 
            this.borrowbutton.Location = new System.Drawing.Point(156, 79);
            this.borrowbutton.Name = "borrowbutton";
            this.borrowbutton.Size = new System.Drawing.Size(58, 24);
            this.borrowbutton.TabIndex = 5;
            this.borrowbutton.Text = "Borrow";
            this.borrowbutton.UseVisualStyleBackColor = true;
            // 
            // booksdbDataSetBindingSource1
            // 
            this.booksdbDataSetBindingSource1.DataSource = this.booksdbDataSet;
            this.booksdbDataSetBindingSource1.Position = 0;
            // 
            // Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.displayallbutton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Books";
            this.Text = "Books";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksdbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksdbDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksdbDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button borrowbutton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource booksdbDataSetBindingSource1;
    }
}