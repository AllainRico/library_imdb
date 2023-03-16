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
    public partial class Borrow : Form
    {
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
            MessageBox.Show("ok");
        }
    }
}
