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
        public String username {
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
            Visible= false;
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Return balik= new Return();
            balik.Show();
            balik.TextToPass = username;
            Visible= false;
        }

        private void borrowbutton_Click(object sender, EventArgs e)
        {
            Borrow borrow = new Borrow();
            borrow.TextToPass = username;
            borrow.ShowDialog();
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
            if (borrowerIDtext.Text != "")
            {
                borrowerIDtext.ReadOnly = true;
                borrowerIDtext.Enabled = false;
            }
            if (usernametext.Text != "")
            {
                usernametext.ReadOnly = true;
                usernametext.Enabled = false;
            }
            if (firstnametext.Text != "")
            {
                firstnametext.ReadOnly = true;
                firstnametext.Enabled = false;
            }
            if (lastnametext.Text != "")
            {
                lastnametext.ReadOnly = true;
                lastnametext.Enabled = false;
            }
            if (contactnumbertext.Text != "")
            {
                contactnumbertext.ReadOnly = true;
                contactnumbertext.Enabled = false;
            }

            if (borrowerIDtext.Text != "" ||
                usernametext.Text != "" ||
                firstnametext.Text != "" ||
                lastnametext.Text != "" ||
                contactnumbertext.Text != ""
                )
            {
                updateinfobutton.Visible = false;
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
    }
}
