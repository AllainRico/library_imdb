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
    public partial class signUp : Form
    {
        public signUp()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm login = new loginForm();
            login.Show();
        }

        private void signupbutton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ("Data Source=DESKTOP-SKI34QJ\\SQLEXPRESS;Initial Catalog=usersdb;Integrated Security=True");
            //change connection string kay ma error
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from usersTable where username='" + usernameTextBox.Text + "'", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            //requirements for password!!!
            //1>must be > 8
            //2>must have uppercase

            if (dt.Rows.Count == 0) //checks if name is already taken
            {
                if (usernameTextBox.Text == "" || passwordTextBox.Text == "") //if fields are empty
                {
                    MessageBox.Show("Fields are empty!", "ERROR: 1");
                }
                else
                {
                    if (passwordTextBox.TextLength < 7)
                    {
                        MessageBox.Show("Password length is lesser than 8", "ERROR: 2");
                    }
                    else
                    {
                        if (confirmPasswordTextBox.Text != passwordTextBox.Text)
                        {
                            MessageBox.Show("password does not match", "ERROR: 3");
                        }
                        else
                        {
                            bool hasUpperCase = false;
                            bool hasLowerCase = false;

                            foreach (char c in passwordTextBox.Text)
                            {
                                if (char.IsUpper(c))
                                {
                                    hasUpperCase = true;
                                }
                                else if (char.IsLower(c))
                                {
                                    hasLowerCase = true;
                                }
                            }
                            if (hasUpperCase && hasLowerCase)
                            {
                                string encpass = Aescryp.Encrypt(passwordTextBox.Text);

                                String st = "INSERT INTO usersTable(username,pass) values (@username, @pass)";
                                SqlCommand cmd1 = new SqlCommand(st, con);
                                cmd1.Parameters.AddWithValue("@username", usernameTextBox.Text);
                                cmd1.Parameters.AddWithValue("@pass", encpass);
                                cmd1.ExecuteNonQuery();
                                con.Close();

                                MessageBox.Show("Account created successfully! - Please input credentials in the Login Form", "Successful!");

                                this.Hide();
                                loginForm login = new loginForm();
                                login.Show();
                            }
                            else
                            {
                                MessageBox.Show("Password does not have an uppercase", "ERROR: 4");
                            }

                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Username already taken!", "ERROR: 0");
            }
        }
        private void signUp_Load(object sender, EventArgs e)
        {

        }
    }
}
