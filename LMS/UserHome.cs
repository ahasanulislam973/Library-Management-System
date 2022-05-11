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
    public partial class UserHome : Form
    {
        public UserHome()
        {
            InitializeComponent();
        }

        private void searchBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchBook form = new SearchBook();
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login a = new Login();
            a.Show();
            this.Hide();
        }

        private void viewNoticeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewNotice a = new ViewNotice();
            a.Show();
            this.Hide();
        }
    }
}
