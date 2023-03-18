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
            con.ConnectionString = ("Data Source=DESKTOP-SKI34QJ\\SQLEXPRESS;Initial Catalog=libsysdb;Integrated Security=True");
            con.Open();

            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * from [dbo].[booksTable] where [Name] = '" + booknametext.Text + "' OR [Author] = '"+ authortext.Text + "'", con);
            DataTable dtbl = new DataTable();
            sqlData.Fill(dtbl);

            dataGridView1.DataSource = dtbl;
        }

        private void displayallbutton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ("Data Source=DESKTOP-SKI34QJ\\SQLEXPRESS;Initial Catalog=libsysdb;Integrated Security=True");
            con.Open();

            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * from [dbo].[booksTable]", con);
            DataTable dtbl = new DataTable();
            sqlData.Fill(dtbl);

            dataGridView1.DataSource= dtbl;
        }

        private void booknamelabel_Click(object sender, EventArgs e)
        {

        }

        private void addbookbutton_Click(object sender, EventArgs e)
        {
            if (addbookidtext.Text=="" ||
                addbooknametext.Text==""||
                addbookauthortext.Text==""||
                addyeartext.Text==""||
                addbookgenretext.Text==""||
                addbookquantitytext.Text=="")
            {
                MessageBox.Show("Invalid inputs!", "Error");
            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = ("Data Source=DESKTOP-SKI34QJ\\SQLEXPRESS;Initial Catalog=libsysdb;Integrated Security=True");
                con.Open();

                SqlCommand cmd = new SqlCommand("select * from booksTable where bookID= " + addbookidtext.Text + "", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 0) //checks if name is already taken
                {
                    try
                    {
                        SqlCommand cmd2 = new SqlCommand("INSERT INTO [dbo].[booksTable] ([BookID],[Name],[Author],[Year],[Genre],[Quantity]) VALUES ('" + addbookidtext.Text + "','" + addbooknametext.Text + "','" + addbookauthortext.Text + "', '" + addyeartext.Text + "', '" + addbookgenretext.Text + "', '" + addbookquantitytext.Text + "');", con);
                        cmd2.ExecuteNonQuery();
                        MessageBox.Show("Book added successfully", "Success");
                        addbookauthortext.Clear();
                        addbookidtext.Clear();
                        addbooknametext.Clear();
                        addyeartext.Clear();
                        addbookgenretext.Clear();
                        addbookquantitytext.Clear();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Book ID is too long!","Book ID Naming error");
                    }
                    
                }
                else
                {
                    string message = "Are you sure you want to update credentials for this book?";
                    string title = "Change Book Detail Attempt";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.Yes)
                    {

                        SqlCommand cmd3 = new SqlCommand("UPDATE [dbo].[booksTable] SET [Name] = '" + addbooknametext.Text + "', [Author] = '" + addbookauthortext.Text + "', [Year] = " + addyeartext.Text + ", [Genre] = '" + addbookgenretext.Text + "', [Quantity] = " + addbookquantitytext.Text + " WHERE [BookID] = " + addbookidtext.Text + ";", con);
                        cmd3.ExecuteNonQuery();
                        MessageBox.Show("Credentials successfully updated!", "Success");
                        addbookidtext.Clear();
                        addbooknametext.Clear();
                        addbookauthortext.Clear();
                        addyeartext.Clear();
                        addbookgenretext.Clear();
                        addbookquantitytext.Clear();
                    }
                }

                    

                
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
            borrower borrower = new borrower();
            borrower.Show();
            Visible = false;
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            report.Show();
            Visible = false;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
