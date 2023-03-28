using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
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

            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT borrowTable.Status, borrowTable.username, borrowTable.bookID, borrowTable.borrowDate, returnTable.returnDate FROM borrowTable LEFT JOIN returnTable ON borrowTable.bookID = returnTable.bookID ORDER BY borrowTable.borrowDate ASC", con);
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

            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT borrowTable.Status, borrowTable.username, borrowTable.bookID, borrowTable.borrowDate, returnTable.returnDate FROM borrowTable LEFT JOIN returnTable ON borrowTable.bookID = returnTable.bookID ORDER BY borrowTable.borrowDate ASC\r\n", con);
            DataTable dtbl = new DataTable();
            sqlData.Fill(dtbl);

            dataGridView1.DataSource = dtbl;
        }




        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font titleFont = new Font("Arial", 21, FontStyle.Bold);
            Font headerFont = new Font("Arial", 16, FontStyle.Bold);
            Font printFont = new Font("Arial", 12);
            SolidBrush printBrush = new SolidBrush(Color.Black);

            float yPosition = 20;
            float xPosition = 10;

            string title = "Library Transaction Report";
            SizeF titleSize = e.Graphics.MeasureString(title, titleFont);
            RectangleF titleRect = new RectangleF(0, yPosition, e.PageBounds.Width, titleSize.Height);
            StringFormat titleFormat = new StringFormat();
            titleFormat.Alignment = StringAlignment.Center;
            e.Graphics.DrawString(title, titleFont, printBrush, titleRect, titleFormat);

            yPosition += titleRect.Height + 10;

            // Create a table to hold the data
            float tableWidth = dataGridView1.Columns.Cast<DataGridViewColumn>().Sum(x => x.Width) + 150;
            float tableHeight = dataGridView1.Rows.Count * printFont.GetHeight() + headerFont.GetHeight() + 90;
            float tableX = (e.PageBounds.Width - tableWidth) / 2;
            RectangleF tableRect = new RectangleF(tableX, yPosition, tableWidth, tableHeight);

            // Print headers
            xPosition = tableRect.X;
            for (int j = 0; j < dataGridView1.Columns.Count; j++)
            {
                string headerValue = dataGridView1.Columns[j].HeaderText.ToString();
                SizeF headerSize = e.Graphics.MeasureString(headerValue, headerFont);
                RectangleF headerRect = new RectangleF(xPosition, yPosition, dataGridView1.Columns[j].Width + 30, headerSize.Height);
                StringFormat headerFormat = new StringFormat();
                headerFormat.Alignment = StringAlignment.Center;
                e.Graphics.DrawString(headerValue, headerFont, printBrush, headerRect, headerFormat);
                xPosition += dataGridView1.Columns[j].Width + 30 ;
            }

            yPosition += headerFont.GetHeight();

            // Print rows
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                xPosition = tableRect.X;
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    string cellValue = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    SizeF cellSize = e.Graphics.MeasureString(cellValue, printFont);
                    RectangleF cellRect = new RectangleF(xPosition, yPosition, dataGridView1.Columns[j].Width, cellSize.Height);
                    StringFormat cellFormat = new StringFormat();
                    cellFormat.Alignment = StringAlignment.Center;
                    e.Graphics.DrawString(cellValue, printFont, printBrush, cellRect, cellFormat);
                    xPosition += dataGridView1.Columns[j].Width + 30;
                }
                yPosition += printFont.GetHeight();
            }
        }


        private void printbutton_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();

            pd.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);

            PrintPreviewDialog ppd = new PrintPreviewDialog();
            ppd.Document = pd;
            ppd.ShowDialog();
        }

    }
}
