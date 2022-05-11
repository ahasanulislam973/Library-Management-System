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
    public partial class Login : Form
   {

     
        public Login()
        {
            InitializeComponent();
        }
       

        private void btnlogin_Click(object sender, EventArgs e)
        {
 
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-2B4VVTI;Initial Catalog=LMSDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from RegisteredUser where username='"+txtUsername.Text+"' and password='"+txtPassword.Text+"'",con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            String cmbItemValue=comboBox1.SelectedItem.ToString();
            
             if (txtUsername.Text == "" && txtPassword.Text == "")
                MessageBox.Show("Must Have A UserName & Password!!!", "Error");
            else if (txtUsername.Text == "")
                MessageBox.Show("Must Have A UserName!!!", "Error");
            else if (txtPassword.Text == "")
                MessageBox.Show("Must Have A Password!!!", "Error");

           else if (dt.Rows.Count > 0)
            {

                 for (int i = 0; i < dt.Rows.Count; i++)
               {
                  

                

                     if (dt.Rows[i]["usertype"].ToString() == cmbItemValue)
                {


                    MessageBox.Show("You are Login as" + " " + dt.Rows[i]["usertype"] + " " + "Your Id is" + " " + dt.Rows[i]["ID"]);
                 

                         if (comboBox1.SelectedIndex == 0)
                    {
                        AdminHome a = new AdminHome();
                        a.Show();
                        this.Hide();
                        
                    }


                    else if (comboBox1.SelectedIndex == 1)
                    {
                        UserHome  a = new UserHome();
                        a.Show();
                        this.Hide();
                    }

                         else 
                    {
                        LibrarianHome a = new LibrarianHome();
                        a.Show();
                        this.Hide();
                    }
                         
                         


                }
                     else
                     {
                         MessageBox.Show("Choose Your User Type Correctly");
                     }
                     
                 }
              
            }
           
        
            else
            {
                MessageBox.Show("Invalid Login"); 
            }
               

            }
            

        private void label3_Click(object sender, EventArgs e)
        {
            Registration form = new Registration();
            form.Show();
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
