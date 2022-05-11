using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS
{
    public partial class AdminHome : Form
    {
        public AdminHome()
        {
            InitializeComponent();
        }

        private void viewMembersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Members a = new Members();
            a.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            form.Show();
            this.Hide();
        }

        private void updateMembersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void deleteMembersToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
    }
}
