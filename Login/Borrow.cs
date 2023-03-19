using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Login
{
    public partial class Borrow : Form
    {
        private string usernameni;

        
        public string TextToPass { get; set; } //gets the inputted username text from login form

        public Borrow()
        {
            InitializeComponent();
            
        }

        private void displayallbooksbutton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ("Data Source=DESKTOP-SKI34QJ\\SQLEXPRESS;Initial Catalog=libsysdb;Integrated Security=True");
            con.Open();

            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * from [dbo].[booksTable] where [Quantity] >0", con);
            DataTable dtbl = new DataTable();
            sqlData.Fill(dtbl);

            booksgridview.DataSource = dtbl;
        }

        private void searchbookbutton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ("Data Source=DESKTOP-SKI34QJ\\SQLEXPRESS;Initial Catalog=libsysdb;Integrated Security=True");
            con.Open();

            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * from [dbo].[booksTable] where [Name] = '" + booknametext.Text + "' OR [Author] = '" + authortext.Text + "'", con);
            DataTable dtbl = new DataTable();
            sqlData.Fill(dtbl);

            booksgridview.DataSource = dtbl;

            booknametext.Clear();
            authortext.Clear();
        }

        private void booksgridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >=0)
            {
                DataGridViewRow row = this.booksgridview.Rows[e.RowIndex];

                borrowbookidtext.Text = row.Cells["bookID"].Value.ToString();
                borrowbooknametext.Text = row.Cells["Name"].Value.ToString();
                borrowbookauthortext.Text = row.Cells["Author"].Value.ToString();
            }
        }

        private void Borrow_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libsysdbDataSet.booksTable' table. You can move, or remove it, as needed.
            this.booksTableTableAdapter.Fill(this.libsysdbDataSet.booksTable);

        }

        private void borrowbookbutton_Click(object sender, EventArgs e)
        {
            String username = TextToPass;
            String msg1 = "Borrow this book under this username: "+ username + "?";
            String msg2 = "Book ID: " + borrowbookidtext.Text+"";
            String msg3 = "Book Name: " + borrowbooknametext.Text + "";
            String msg4 = "Book Author: " + borrowbookauthortext.Text + "";

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(msg2 + "\n" + msg3 + "\n" + msg4 + "\n" + "\n" + msg1, "Borrow Book", buttons);
            if (result == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = ("Data Source=DESKTOP-SKI34QJ\\SQLEXPRESS;Initial Catalog=libsysdb;Integrated Security=True");
                con.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[borrowTable] ([username] ,[bookID], [borrowDate])VALUES ('" + username + "', "+ borrowbookidtext.Text + ", GETDATE());", con);
                cmd.ExecuteNonQuery();
                SqlCommand updateQuantity = new SqlCommand("UPDATE booksTable SET Quantity = Quantity - 1 WHERE BookID = "+ borrowbookidtext.Text + ";", con);
                updateQuantity.ExecuteNonQuery();
                SqlCommand updateBooksBorrowed = new SqlCommand("UPDATE borrowersTable SET booksBorrowed = ISNULL(booksborrowed, 0) + 1 where username = '" + TextToPass + "';", con);
                updateBooksBorrowed.ExecuteNonQuery();

                borrowbookidtext.Clear();
                borrowbooknametext.Clear();
                borrowbookauthortext.Clear();
                MessageBox.Show("Book borrowed successfully", "Success");
                displayallbooksbutton_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Borrow transaction canceled", "Notice");
                borrowbookidtext.Clear();
                borrowbooknametext.Clear();
                borrowbookauthortext.Clear();
                displayallbooksbutton_Click(sender, e);
            }
        }

        private void gouserhome_Click(object sender, EventArgs e)
        {
            userHome uh = new userHome();
            uh.usernametext.Text = TextToPass;
            //uh.TextToPass = usernameni;
            uh.Show();
            Visible = false;
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Return balik = new Return();
            balik.Show();
            balik.TextToPass = TextToPass;
            Visible = false;
        }
    }
}
