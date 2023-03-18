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
            fillCombo();
        }

        public void fillCombo() {
            string constring = "Data Source=DESKTOP-SKI34QJ\\SQLEXPRESS;Initial Catalog=libsysdb;Integrated Security=True";
            string Query = "Select username from [dbo].[usersTable]";
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlCommand cmd = new SqlCommand(Query, con);
            SqlDataReader myreader = cmd.ExecuteReader();
            while (myreader.Read())
            {
                //string username = myreader.GetString("Select username from[dbo].[usersTable]");
                usernamecombobox.Items.Add(myreader["username"]);


            }

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

            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * from [dbo].[borrowersTable] where [username] = '" + usernamecombobox.Text + "' OR [FirstName] = '" + usersearchfirstname.Text + "' OR [LastName] = '" + usersearchlastname.Text + "'", con);
            DataTable dtbl = new DataTable();
            sqlData.Fill(dtbl);

            borrowergridview.DataSource = dtbl;
        }

        private void addborrowerbutton_Click(object sender, EventArgs e)
        {
            if (usernamecombobox.Text == "" ||
                addborrowerfirstnametext.Text == "" ||
                addborrowerlastnametext.Text == "" ||
                addborrowercontactnumbertext.Text == "")
            {
                MessageBox.Show("Invalid inputs!", "Error");
            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = ("Data Source=DESKTOP-SKI34QJ\\SQLEXPRESS;Initial Catalog=libsysdb;Integrated Security=True");
                con.Open();

                SqlCommand cmd = new SqlCommand("select * from borrowersTable where username='" + usernamecombobox.Text + "'", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 0) //checks if name is already taken
                {

                    try
                    {
                        SqlCommand cmd2 = new SqlCommand("INSERT INTO [dbo].[borrowersTable]([userName],[FirstName],[LastName],[ContactNumber]) VALUES ('" + usernamecombobox.Text + "','" + addborrowerfirstnametext.Text + "','" + addborrowerlastnametext.Text + "', '" + addborrowercontactnumbertext.Text + "');", con);
                        cmd2.ExecuteNonQuery();

                        MessageBox.Show("Information added successfully", "Success");
                        usernamecombobox.Text = "";
                        addborrowerfirstnametext.Clear();
                        addborrowerlastnametext.Clear();
                        addborrowercontactnumbertext.Clear();
                        displayallborrowerbutton_Click(sender, e);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Username does not exist in the Database!", "Invalid User");
                    }
                }
                else
                {
                    string message = "Are you sure you want to update credentials for this username?";
                    string title = "Change Credentials Attempt";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.Yes)
                    {

                        SqlCommand cmd3 = new SqlCommand("UPDATE [dbo].[borrowersTable] SET [FirstName] = '" + addborrowerfirstnametext.Text + "', [LastName] = '" + addborrowerlastnametext.Text + "', [ContactNumber] = " + addborrowercontactnumbertext.Text + " WHERE [username] = '" + usernamecombobox.Text + "';", con);
                        cmd3.ExecuteNonQuery();
                        MessageBox.Show("Credentials successfully updated!", "Success");
                        usernamecombobox.Text = "";
                        addborrowerfirstnametext.Clear();
                        addborrowerlastnametext.Clear();
                        addborrowercontactnumbertext.Clear();
                        displayallborrowerbutton_Click(sender, e);
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
