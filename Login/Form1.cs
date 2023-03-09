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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

                if (usernameTextBox.Text == "admin")
                {
                    MessageBox.Show("Welcome admin");
                    adminHome home = new adminHome();
                    home.Show();
                    Visible = false;
                }
                else
                {
                    MessageBox.Show("Welcome user");
                    userHome home = new userHome();
                    home.Show();
                    Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Incorrect credentials!", "ERROR: login_error");
            }
        }
    }
}
