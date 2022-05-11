using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS
{
    public partial class BookList : Form
    {
       private bool isNew = false;
        public BookList()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BookList_Load(object sender, EventArgs e)
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
                textBox1.Text = dt.Rows[0]["ID"].ToString();
                textBox2.Text = dt.Rows[0]["BookName"].ToString();
                textBox3.Text = dt.Rows[0]["BookType"].ToString();
                textBox5.Text = dt.Rows[0]["AuthorName"].ToString();
                textBox6.Text = dt.Rows[0]["Quantity"].ToString();
                textBox7.Text = dt.Rows[0]["Borrowable"].ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-2B4VVTI;Initial Catalog=LMSDB;Integrated Security=True");
            conn.Open();
            string query;
            if (isNew == false)
            {
                query = "update BookList set BookType='" + textBox3.Text + "', BookName='" + textBox2.Text + "', AuthorName='" + textBox5.Text + "',Quantity='" + textBox6.Text + "',Borrowable='" + textBox7.Text + "'  where ID=" + textBox1.Text;
            }
            else
            {
                query = "insert into BookList (BookName,BookType,AuthorName,Quantity,Borrowable) values('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "')";
                isNew = false;
            }
            SqlCommand cmd = new SqlCommand(query, conn);
            int row = cmd.ExecuteNonQuery();
            if (row > 0)
                MessageBox.Show("Successsfully Updated");

            query = "select * from BookList";
            cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //textBox1.Text = " ";
            //textBox2.Text = " ";
            //textBox3.Text = " ";
            //textBox5.Text = " ";
            //textBox6.Text = " ";
            //textBox7.Text = " ";
            //isNew = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-2B4VVTI;Initial Catalog=LMSDB;Integrated Security=True");
            conn.Open();
            string query = "Delete from BookList where ID=" + textBox1.Text;
            SqlCommand cmd = new SqlCommand(query, conn);
            int row = cmd.ExecuteNonQuery();
            if (row > 0)
                MessageBox.Show("Successsfully deleted");
            query = "select * from BookList";
            cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox5.Text = " ";
            textBox6.Text = " ";
            textBox7.Text = " ";
            conn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            //if(textBox4.Text=="")
            //{
            //    MessageBox.Show("Please Write someting to search");

            //}
            //else
            //{
            //    SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-2B4VVTI;Initial Catalog=LMSDB;Integrated Security=True");
            //    conn.Open();
            //    string query = "select * from BookList where BookName like '% " + textBox4.Text + "%'";
            //    SqlCommand cmd = new SqlCommand(query, conn);
            //    cmd.ExecuteNonQuery();
            //    SqlDataAdapter adp = new SqlDataAdapter(cmd);
            //    DataSet ds = new DataSet();
            //    adp.Fill(ds);
            //    DataTable dt = ds.Tables[0];
            //    dataGridView1.AutoGenerateColumns = false;
            //    dataGridView1.DataSource = dt;
            //    dataGridView1.Refresh();
            //    textBox1.Text = dt.Rows[0]["ID"].ToString();
            //    textBox2.Text = dt.Rows[0]["BookName"].ToString();
            //    textBox3.Text = dt.Rows[0]["BookType"].ToString();
            //    conn.Close();
            //}
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            LibrarianHome form = new LibrarianHome();
            form.Show();
            this.Hide();
        }
    }
}
