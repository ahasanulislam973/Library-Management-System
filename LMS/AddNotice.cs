using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace LMS
{
    public partial class AddNotice : Form
    {
        public AddNotice()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Notice;
            Notice = txtNotice.Text;
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-2B4VVTI;Initial Catalog=LMSDB;Integrated Security=True");
            conn.Open();
            string query = "insert into Notice (Notice) values('" + Notice + "')";
            SqlCommand cmd = new SqlCommand(query, conn);
            int row = cmd.ExecuteNonQuery();
            if (row > 0)
                MessageBox.Show("Successsfully Add Notice");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LibrarianHome a = new LibrarianHome();
            a.Show();
            this.Hide();
        }
    }
}
