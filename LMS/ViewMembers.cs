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
    public partial class ViewMembers : Form
    {
        public ViewMembers()
        {
            InitializeComponent();
        }

        private void ViewMembers_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-2B4VVTI;Initial Catalog=LMSDB;Integrated Security=True");
            conn.Open();
            string query = "select * from RegisteredUser";
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
                string query = "select * from RegisteredUser where ID=" + id;
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                txtId.Text = dt.Rows[0]["ID"].ToString();
                txtName.Text = dt.Rows[0]["name"].ToString();
                txtEmail.Text = dt.Rows[0]["Email"].ToString();
                txtUsername.Text = dt.Rows[0]["username"].ToString();
                txtUsertype.Text = dt.Rows[0]["usertype"].ToString();
                txtGender.Text = dt.Rows[0]["gender"].ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtId.Text = " ";
            txtName.Text = " ";
            txtEmail.Text = " ";
            txtUsername.Text = " ";
            txtUsertype.Text = " ";
            txtGender.Text = " ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminHome a = new AdminHome();
            a.Show();
            this.Hide();
        }
    }
}