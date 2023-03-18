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

namespace Login
{
    public partial class Return : Form
    {
        public string TextToPass { get; set; }

        public Return()
        {
            InitializeComponent();
        }

        private void Return_Load(object sender, EventArgs e)
        {

        }

        private void borrowgridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.borrowgridview.Rows[e.RowIndex];

                returnbookidtext.Text = row.Cells["bookID"].Value.ToString();
                returnbooknametext.Text = row.Cells["Name"].Value.ToString();
                returnbookauthortext.Text = row.Cells["Author"].Value.ToString();
            }
        }

        private void displayallborrowbutton_Click(object sender, EventArgs e)
        {
            userHome hm = new userHome();
            
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ("Data Source=DESKTOP-SKI34QJ\\SQLEXPRESS;Initial Catalog=libsysdb;Integrated Security=True");
            con.Open();

            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT booksTable.BookID, booksTable.Name,booksTable.Author FROM booksTable INNER JOIN borrowTable ON booksTable.bookid = borrowTable.bookid where borrowTable.username = '" + TextToPass + "';", con);
            DataTable dtbl = new DataTable();
            sqlData.Fill(dtbl);

            borrowgridview.DataSource = dtbl;
        }

        private void goHome_Click(object sender, EventArgs e)
        {
            userHome uh = new userHome();
            uh.usernametext.Text = TextToPass;
            //uh.TextToPass = usernameni;
            uh.Show();
            Visible = false;
        }

        private void goBorrow_Click(object sender, EventArgs e)
        {
            Borrow borrow = new Borrow();
            borrow.Show();
            Visible = false;
        }

        private void returnbookbutton_Click(object sender, EventArgs e)
        {
            String username = TextToPass;
            String msg1 = "Return this book under this username: " + username + "?";
            String msg2 = "Book ID: " + returnbookidtext.Text + "";
            String msg3 = "Book Name: " + returnbooknametext.Text + "";
            String msg4 = "Book Author: " + returnbookauthortext.Text + "";

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(msg2 + "\n" + msg3 + "\n" + msg4 + "\n" + "\n" + msg1, "Return Book", buttons);
            if (result == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = ("Data Source=DESKTOP-SKI34QJ\\SQLEXPRESS;Initial Catalog=libsysdb;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[returnTable] ([username] ,[bookID])VALUES ('" + username + "', " + returnbookidtext.Text + ");", con);
                cmd.ExecuteNonQuery();
                SqlCommand updateQuantity = new SqlCommand("UPDATE booksTable SET Quantity = Quantity + 1 WHERE BookID = " + returnbookidtext.Text + ";", con);
                updateQuantity.ExecuteNonQuery();
                SqlCommand updateBooksReturned = new SqlCommand("UPDATE borrowersTable SET booksReturned = ISNULL(booksReturned, 0) + 1 where username = '" + TextToPass + "';", con);
                updateBooksReturned.ExecuteNonQuery();
            }
        }
    }
}
