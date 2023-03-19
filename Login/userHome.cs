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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Login
{
    public partial class userHome : Form
    {
        public string TextToPass { get; set; }
        public String username
        {
            get
            {
                return usernametext.Text;
            }
        }
        public userHome()
        {
            InitializeComponent();

        }


        private void borrowToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Borrow borrow = new Borrow();
            borrow.Show();
            Visible = false;
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Return balik = new Return();
            balik.Show();
            balik.TextToPass = username;
            Visible = false;
        }

        private void borrowbutton_Click(object sender, EventArgs e)
        {
            Borrow borrow = new Borrow();
            borrow.TextToPass = username;
            borrow.Show();
            Visible = false;
        }

        private void borrowerIDtext_TextChanged(object sender, EventArgs e)
        {


        }

        private void usernametext_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-SKI34QJ\\SQLEXPRESS;Initial Catalog=libsysdb;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("select [borrowerID], [FirstName], [LastName], [ContactNumber], [booksBorrowed], [booksreturned] from borrowersTable where username = '" + usernametext.Text + "';", con);
            SqlDataReader da = cmd.ExecuteReader();
            while (da.Read())
            {
                borrowerIDtext.Text = da.GetValue(0).ToString();
                firstnametext.Text = da.GetValue(1).ToString();
                lastnametext.Text = da.GetValue(2).ToString();
                contactnumbertext.Text = da.GetValue(3).ToString();
                booksborrowedtext.Text = da.GetValue(4).ToString();
                booksreturnedtext.Text = da.GetValue(5).ToString();
            }
        }

        private void userHome_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(borrowerIDtext.Text))
            {
                borrowerIDtext.ReadOnly = false;
                borrowerIDtext.Enabled = true;
            }
            if (string.IsNullOrEmpty(usernametext.Text))
            {
                usernametext.ReadOnly = false;
                usernametext.Enabled = true;
            }
            if (string.IsNullOrEmpty(firstnametext.Text))
            {
                firstnametext.ReadOnly = false;
                firstnametext.Enabled = true;
            }
            if (string.IsNullOrEmpty(lastnametext.Text))
            {
                lastnametext.ReadOnly = false;
                lastnametext.Enabled = true;
            }
            if (string.IsNullOrEmpty(contactnumbertext.Text))
            {
                contactnumbertext.ReadOnly = false;
                contactnumbertext.Enabled = true;
            }

            if (string.IsNullOrEmpty(borrowerIDtext.Text) ||
                string.IsNullOrEmpty(usernametext.Text) ||
                string.IsNullOrEmpty(firstnametext.Text) ||
                string.IsNullOrEmpty(lastnametext.Text) ||
                string.IsNullOrEmpty(contactnumbertext.Text)
            )
            {
                updatebutton.Visible = true;
            }

            booksborrowedtext.ReadOnly = true;
            booksborrowedtext.Enabled = false;
            booksreturnedtext.ReadOnly = true;
            booksreturnedtext.Enabled = false;
        }

            private void returnbookbutton_Click(object sender, EventArgs e)
        {
            Return balik = new Return();
            balik.TextToPass = username;
            balik.Show();
            Visible = false;
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ("Data Source=DESKTOP-SKI34QJ\\SQLEXPRESS;Initial Catalog=libsysdb;Integrated Security=True");
            con.Open();

            SqlCommand cmd2 = new SqlCommand("UPDATE borrowersTable SET firstname = '" + firstnametext.Text + "', lastname = '" + lastnametext.Text + "', contactnumber = " + contactnumbertext.Text + " where username = '"+ usernametext.Text+"';", con);
            cmd2.ExecuteNonQuery();

            MessageBox.Show("Information added successfully", "Success");

            firstnametext.Enabled = false;
            lastnametext.Enabled = false;
            contactnumbertext.Enabled = false;
            updatebutton.Visible = false;

        }

        private void gosignout_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to sign out?";
            string title = "Sign Out Attempt";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Sign out Succesful!", "Sign out");
                loginForm signout = new loginForm();
                signout.Show();
                Visible = false;

            }
        }
    }
}