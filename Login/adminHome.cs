using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class adminHome : Form
    {
        public adminHome()
        {
            InitializeComponent();
        }

        private void borrowerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            borrower borrower = new borrower();
            borrower.Show();
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
            Report report= new Report();
            report.Show();
            Visible = false;
        }

        private void borrowersbutton_Click(object sender, EventArgs e)
        {
            borrower borrower = new borrower();
            borrower.Show();
            Visible = false;
        }

        private void booksbutton_Click(object sender, EventArgs e)
        {
            Books books = new Books();
            books.Show();
            Visible = false;
        }

        private void reportbutton_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            report.Show();
            Visible = false;
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
