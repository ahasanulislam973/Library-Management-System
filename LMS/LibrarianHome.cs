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
    public partial class LibrarianHome : Form
    {
        public LibrarianHome()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBooks form = new AddBooks();
            form.Show();
            this.Hide();
        }

        private void deleteBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void updateBookListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void bookListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookList form = new BookList();
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            form.Show();
            this.Hide();
        }

        private void addNoticeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void addNoticeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddNotice form = new AddNotice();
            form.Show();
            this.Hide();
        }

        private void updateDeleteNoticeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateAndDeleteNotice form = new UpdateAndDeleteNotice();
            form.Show();
            this.Hide();
        }

        private void returnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnBook form = new ReturnBook();
            form.Show();
            this.Hide();
        }
    }
}
