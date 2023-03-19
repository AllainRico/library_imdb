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


        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Display the title string
            StringFormat titleFormat = new StringFormat();
            titleFormat.Alignment = StringAlignment.Center;
            e.Graphics.DrawString("Library Transactions Report", new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Black, new Point(400, 20), titleFormat);

            // Display the DataGridView values
            StringFormat cellFormat = new StringFormat();
            cellFormat.Alignment = StringAlignment.Near;
            cellFormat.LineAlignment = StringAlignment.Center;

            int x = 120;    // starting x position
            int y = 100;    // starting y position
            int rowHeight = dataGridView1.Rows[0].Height;
            int colWidth = 0;

            // Draw column headers
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                e.Graphics.DrawString(col.HeaderText, dataGridView1.Font, Brushes.Black, new RectangleF(x, y, col.Width, rowHeight), cellFormat);
                x += col.Width;
                colWidth += col.Width;
            }

            // Draw rows
            y += rowHeight;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                x = 120;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    e.Graphics.DrawString(cell.Value.ToString(), dataGridView1.Font, Brushes.Black, new RectangleF(x, y, dataGridView1.Columns[cell.ColumnIndex].Width, rowHeight), cellFormat);
                    x += dataGridView1.Columns[cell.ColumnIndex].Width;
                }
                y += rowHeight;
            }

            // Add page number
            StringFormat pageNumberFormat = new StringFormat();
            pageNumberFormat.Alignment = StringAlignment.Far;
            e.Graphics.DrawString("Page " + (printDocument1.PrinterSettings.FromPage + e.PageSettings.PrinterSettings.Copies * e.PageSettings.PrinterSettings.ToPage - 1).ToString(), dataGridView1.Font, Brushes.Black, new RectangleF(e.PageBounds.Left, e.PageBounds.Bottom - dataGridView1.Font.Height, e.PageBounds.Width, dataGridView1.Font.Height), pageNumberFormat);
        }




        private void printbutton_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.WindowState = FormWindowState.Maximized;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();

        }
    }
}
