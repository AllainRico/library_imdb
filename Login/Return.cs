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
    }
}
