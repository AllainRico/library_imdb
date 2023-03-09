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
    public partial class userHome : Form
    {
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
            Visible= false;
        }
    }
}
