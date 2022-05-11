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
    public partial class AddBooks : Form
    {
        public AddBooks()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string BookName,AuthorName,BookType = " ",Quantity,Borrowable;
          
            BookName = txtBookName.Text;
            AuthorName = txtAuthorname.Text;
            Quantity = txtQuantity.Text;
            Borrowable = txtBorrowable.Text;
            if (radioButton1.Checked)
                BookType += "Science";
            if (radioButton2.Checked)
                BookType += "Law";
            if (radioButton3.Checked)
                BookType += "Mathematics";
            if (radioButton4.Checked)
                BookType += "Novels & Stories";
            if (radioButton5.Checked)
                BookType += "Biography";

            
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-2B4VVTI;Initial Catalog=LMSDB;Integrated Security=True");
            conn.Open();
            string query = "insert into BookList (BookName,AuthorName,BookType,Quantity,Borrowable) values('" + BookName + "','" + AuthorName + "','" + BookType + "','" + Quantity + "','" + Borrowable + "')";
            SqlCommand cmd = new SqlCommand(query, conn);
            int row = cmd.ExecuteNonQuery();
            if (row > 0)
                MessageBox.Show("Successsfully Add Books");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LibrarianHome form = new LibrarianHome();
            form.Show();
            this.Hide();
        }
    }
}
