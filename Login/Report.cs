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
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

       
        private void goAdminHome_Click(object sender, EventArgs e)
        {
            adminHome home = new adminHome();
            home.Show();
            Visible = false;
        }

        private void goBooks_Click(object sender, EventArgs e)
        {
            Books books = new Books();
            books.Show();
            Visible = false;
        }

        private void goBorrower_Click(object sender, EventArgs e)
        {
            borrower borrower = new borrower();
            borrower.Show();
            Visible = false;
        }

        private void Report_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ("Data Source=DESKTOP-SKI34QJ\\SQLEXPRESS;Initial Catalog=libsysdb;Integrated Security=True");
            con.Open();

            SqlDataAdapter sqlData = new SqlDataAdapter("select borrowTable.Status, borrowTable.username, borrowTable.bookID, borrowTable.borrowDate, returnTable.returnDate from borrowTable INNER join returnTable on borrowTable.bookID = returnTable.bookID  ORDER BY borrowTable.borrowDate ASC", con);
            DataTable dtbl = new DataTable();
            sqlData.Fill(dtbl);

            dataGridView1.DataSource = dtbl;
        }

        private void datefilterbutton_Click(object sender, EventArgs e)
        {
            //String borrowdate = fromdatetimepicker.Value.ToString();
            //String returndate = todatetimepicker.Value.ToString();
            string borrowdate = fromdatetimepicker.Value.ToString("yyyy-MM-dd");
            string returndate = todatetimepicker.Value.ToString("yyyy-MM-dd");

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-SKI34QJ\\SQLEXPRESS;Initial Catalog=libsysdb;Integrated Security=True";
            con.Open();

            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT borrowTable.Status, borrowTable.username, borrowTable.bookID, CONVERT(varchar(10), borrowTable.borrowDate, 103) as borrowDate, returnTable.returnDate FROM borrowTable INNER JOIN returnTable ON borrowTable.bookID = returnTable.bookID WHERE borrowTable.borrowDate BETWEEN '" + borrowdate + "' AND DATEADD(day, 1, '" + returndate + "' ) ORDER BY borrowTable.borrowDate ASC", con);

            DataTable dtbl = new DataTable();
            sqlData.Fill(dtbl);

            dataGridView1.DataSource = dtbl;

        }

        private void displayallbutton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ("Data Source=DESKTOP-SKI34QJ\\SQLEXPRESS;Initial Catalog=libsysdb;Integrated Security=True");
            con.Open();

            SqlDataAdapter sqlData = new SqlDataAdapter("select borrowTable.Status, borrowTable.username, borrowTable.bookID, borrowTable.borrowDate, returnTable.returnDate from borrowTable INNER join returnTable on borrowTable.bookID = returnTable.bookID  ORDER BY borrowTable.borrowDate ASC", con);
            DataTable dtbl = new DataTable();
            sqlData.Fill(dtbl);

            dataGridView1.DataSource = dtbl;
        }
    }
}
