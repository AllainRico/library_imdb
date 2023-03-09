using Aesencdec;
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
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void usernamelabel_Click(object sender, EventArgs e)
        {

        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            signUp reg = new signUp();
            reg.Show();
        }



        private void loginbutton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ("Data Source=DESKTOP-SKI34QJ\\SQLEXPRESS;Initial Catalog=usersdb;Integrated Security=True");
            con.Open();
            string encpass = Aescryp.Encrypt(passwordTextBox.Text);
            SqlCommand cmd = new SqlCommand("select * from usersTable where username='" + usernameTextBox.Text + "' and pass = '" + encpass + "'", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Log in successful", "Welcome");

                this.Hide();
                home home = new home();
                home.Show();
            }
            else
            {
                MessageBox.Show("User does not exist!", "ERROR: 4");
            }
        }
    }
}
