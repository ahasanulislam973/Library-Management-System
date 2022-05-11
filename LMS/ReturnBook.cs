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
    public partial class ReturnBook : Form
    {
        public ReturnBook()
        {
            InitializeComponent();
        }

        private void ReturnBook_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-2B4VVTI;Initial Catalog=LMSDB;Integrated Security=True");
            conn.Open();
            string query = "select * from BorrowBook";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            conn.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                MessageBox.Show(id + " ");
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-2B4VVTI;Initial Catalog=LMSDB;Integrated Security=True");
                conn.Open();
                string query = "select * from BorrowBook where ID=" + id;
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                txtBookID.Text = dt.Rows[0]["ID"].ToString();
                txtBookName.Text = dt.Rows[0]["BookName"].ToString();
                txtBookType.Text = dt.Rows[0]["BookType"].ToString();
                txtAuthorName.Text = dt.Rows[0]["AuthorName"].ToString();
                txtID.Text = dt.Rows[0]["UserID"].ToString();
                txtName.Text = dt.Rows[0]["UserName"].ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-2B4VVTI;Initial Catalog=LMSDB;Integrated Security=True");
            conn.Open();
            string query = "Delete from BorrowBook where ID=" + txtBookID.Text;
            SqlCommand cmd = new SqlCommand(query, conn);
            int row = cmd.ExecuteNonQuery();
            if (row > 0)
                MessageBox.Show("Successsfully Return");
            query = "select * from BorrowBook";
            cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            txtBookID.Text = " ";
            txtBookName.Text = " ";
            txtBookType.Text = " ";
            txtAuthorName.Text = " ";
            txtName.Text = " ";
            txtID.Text = " ";
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LibrarianHome form = new LibrarianHome();
            form.Show();
            this.Hide();
        }
    }
}