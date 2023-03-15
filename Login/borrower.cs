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
    public partial class borrower : Form
    {
        public borrower()
        {
            InitializeComponent();
        }

        private void displayallborrowerbutton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ("Data Source=DESKTOP-SKI34QJ\\SQLEXPRESS;Initial Catalog=libsysdb;Integrated Security=True");
            con.Open();

            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * FROM [dbo].[borrowersTable]", con);
            DataTable dtbl = new DataTable();
            sqlData.Fill(dtbl);

            borrowergridview.DataSource = dtbl;
        }

        private void searchbookbutton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ("Data Source=DESKTOP-SKI34QJ\\SQLEXPRESS;Initial Catalog=libsysdb;Integrated Security=True");
            con.Open();

            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * from [dbo].[borrowersTable] where [userID] = '" + borrowsearchuseridtext.Text + "' OR [FirstName] = '" + usersearchfirstname.Text + "'", con);
            DataTable dtbl = new DataTable();
            sqlData.Fill(dtbl);

            borrowergridview.DataSource = dtbl;
        }

        private void addborrowerbutton_Click(object sender, EventArgs e)
        {
            if (borroweruseridtext.Text == "" ||
                userfirstnametext.Text == "" ||
                userlastnametext.Text == "" ||
                usercontactnumbertext.Text == "")
            {
                MessageBox.Show("Invalid inputs!", "Error");
            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = ("Data Source=DESKTOP-SKI34QJ\\SQLEXPRESS;Initial Catalog=libsysdb;Integrated Security=True");
                con.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[borrowersTable]([userID],[FirstName],[LastName],[ContactNumber]) VALUES ('" + borroweruseridtext.Text + "','" + userfirstnametext.Text + "','" + userlastnametext.Text + "', '" + usercontactnumbertext.Text +"');", con);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Information added successfully", "Success");
            }
        }

        private void borrowerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adminHome home = new adminHome();
            home.Show();
            Visible = false;
        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Books books = new Books();
            books.Show();
            Visible = false;
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            report.Show();
            Visible = false;
        }
    }
}
