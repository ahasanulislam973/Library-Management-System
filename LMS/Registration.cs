using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient; 
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS
{
   
    public partial class Registration : Form
    {
       
        public Registration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             string name, username, password, email, gender = " ", usertype = " ";
           // string username, password, usertype = " ";
            //DateTime dob = Convert.ToDateTime(dateTimePicker2.Text);
            name = txtName.Text;
            username = txtUsername.Text;
            email = txtEmail.Text;
            password = txtPassword.Text;
            
              
                 if (radioButton3.Checked)
                usertype = "admin";
            if (radioButton4.Checked)
                usertype = "Librarian";
            if (radioButton5.Checked)
                usertype = "user";
            
           
            
                if (radioButton1.Checked)
                {
                    gender = "Male";
                   
                }
                else if (radioButton2.Checked)
                {
                    gender = "Female";
                    
                }
            

            
            
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-2B4VVTI;Initial Catalog=LMSDB;Integrated Security=True");
            conn.Open();
            string query = "insert into RegisteredUser (name,username,password,Email,gender,usertype) values('" + name + "','" + username + "','" + password + "','" + email + "','" + gender + "','" + usertype + "')";
            SqlCommand cmd = new SqlCommand(query, conn);
            int row = cmd.ExecuteNonQuery();
            if (txtName.Text == "" || txtEmail.Text == "" || txtPassword.Text == "" || txtUsername.Text == "")
            {
                MessageBox.Show("Enter all the details");

            }
            else if(gender ==" ")
            {
                MessageBox.Show(" Select any gender");
            }
            else if ( usertype == " ")
            {
                MessageBox.Show(" Select any User");
            }
            //if (row > 0)
            else
                MessageBox.Show("Successsfully Registered");

            
            
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            form.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            form.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
