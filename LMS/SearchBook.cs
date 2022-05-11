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
    public partial class SearchBook : Form
    {
        public SearchBook()
        {
            InitializeComponent();
        }

        private void SearchBook_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-2B4VVTI;Initial Catalog=LMSDB;Integrated Security=True");
            conn.Open();
            string query = "select * from BookList";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            dataGridView1.AutoGenerateColumns = false;
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
                string query = "select * from BookList where ID=" + id;
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
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                MessageBox.Show("Please Write someting to search");

            }
            else
            {
               
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-2B4VVTI;Initial Catalog=LMSDB;Integrated Security=True");
                conn.Open();
                string query = "select * from BookList where BookName like '%" + textBox4.Text + "%'";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
           
                conn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            txtBookID.Text = " ";
            txtBookName.Text = " ";
            txtBookType.Text = " ";
            txtAuthorName.Text = " ";
            txtName.Text = " ";
            txtID.Text = " ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UserHome form = new UserHome();
            form.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string name, userid, bookname, authorname, booktype = " ";
            // string username, password, usertype = " ";
            //DateTime dob = Convert.ToDateTime(dateTimePicker2.Text);
            name = txtName.Text;
            userid = txtID.Text;
            booktype = txtBookType.Text;
            authorname = txtAuthorName.Text;
            bookname = txtBookName.Text;


            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-2B4VVTI;Initial Catalog=LMSDB;Integrated Security=True");
            conn.Open();
            string query = "insert into BorrowBook (UserName,BookName,BookType,AuthorName,UserID) values('" + name + "','" + bookname + "','" + booktype + "','" + authorname + "','" + userid + "')"; 
            SqlCommand cmd = new SqlCommand(query, conn);
            int row = cmd.ExecuteNonQuery();
            if (txtName.Text == "" || txtID.Text == "" || txtBookType.Text == "" || txtAuthorName.Text == "" || txtBookID.Text == "")
            {
                MessageBox.Show("Please FillUp All the Fields");

            }
           
            //if (row > 0)
            else
                MessageBox.Show("Successsfully Borrowed");
        }
    }
}
