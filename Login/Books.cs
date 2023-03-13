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
    public partial class Books : Form
    {
        public Books()
        {
            InitializeComponent();
        }

        private void searchbookbutton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ("Data Source=DESKTOP-SKI34QJ\\SQLEXPRESS;Initial Catalog=booksdb;Integrated Security=True");
            con.Open();

            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * from [booksdb].[dbo].[booksTable] where [Name] = '" + booknametext.Text + "' OR [Author] = '"+ authortext.Text + "'", con);
            DataTable dtbl = new DataTable();
            sqlData.Fill(dtbl);

            dataGridView1.DataSource = dtbl;
        }

        private void displayallbutton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ("Data Source=DESKTOP-SKI34QJ\\SQLEXPRESS;Initial Catalog=booksdb;Integrated Security=True");
            con.Open();

            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * from [booksdb].[dbo].[booksTable]", con);
            DataTable dtbl = new DataTable();
            sqlData.Fill(dtbl);

            dataGridView1.DataSource= dtbl;
        }

        private void booknamelabel_Click(object sender, EventArgs e)
        {

        }

        private void addbookbutton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ("Data Source=DESKTOP-SKI34QJ\\SQLEXPRESS;Initial Catalog=booksdb;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO [booksdb].[dbo].[booksTable] ([BookID],[Name],[Author],[Year],[Genre],[Quantity]) VALUES ('"+addbookidtext.Text +"','"+ addbooknametext.Text +"','" + addbookauthortext.Text + "', '"+ addyeartext.Text +"', '"+ addbookgenretext.Text +"', '"+ addbookquantitytext.Text +"');", con);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Book added successfully", "Success");
        }
    }
}
