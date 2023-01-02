
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
using System.Configuration;

namespace StudentPortal1
{
    public partial class Staff : Form
    {
        string username;
        int id;
        string password;

        public Staff()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-QNMJ0BT\\SQLEXPRESS; Initial Catalog=student2;Integrated Security=True");
                con.Open();

                //string newcon = "insert into signuptable(Name,ID,Year, Semester, Password) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "', '" + textBox4.Text + "','" + textBox5.Text + "')";

                string newcon = "select username from staffsignup where username='" + txtusername.Text + "' and Pas1='" + txtpassword.Text + "'";

                SqlDataAdapter adp = new SqlDataAdapter(newcon, con);
                DataSet ds = new DataSet();

                adp.Fill(ds);

                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count >= 1)
                {
                    username = txtusername.Text;
                    //  MessageBox.Show(id);
                    staffEnvironment dashboardPage = new staffEnvironment();
                    dashboardPage.Show();
                    this.Hide();
                }
                else
                {
                    label4.Text = "Wrong ID or Password";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtusername.Text = "";
            txtpassword.Text = "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}





