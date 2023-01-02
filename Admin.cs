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
using SpeechLib;
using System.Media;
using System.Configuration;


namespace StudentPortal1
{
    public partial class Admin : Form
    {
        string username;
        int id;
        string password;
        public Admin()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-QNMJ0BT\\SQLEXPRESS; Initial Catalog=Student2;Integrated Security=True";

        }

        private void Admin_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-QNMJ0BT\\SQLEXPRESS; Initial Catalog=Student2;Integrated Security=True");
            con.Open();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-QNMJ0BT\\SQLEXPRESS; Initial Catalog=student2;Integrated Security=True");
                con.Open();

                //string newcon = "insert into signuptable(Name,ID,Year, Semester, Password) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "', '" + textBox4.Text + "','" + textBox5.Text + "')";

                string newcon = "select username from user1 where username='" + txtusername.Text + "' and password='" + txtpassword.Text + "'";

                SqlDataAdapter adp = new SqlDataAdapter(newcon, con);
                DataSet ds = new DataSet();

                adp.Fill(ds);

                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count >= 1)
                {
                    username = txtusername.Text;
                    //  MessageBox.Show(id);
                    AdminOffice dashboardPage = new AdminOffice();
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

        private void label6_Click_Click(object sender, EventArgs e)
        {
            label6.ForeColor = Color.Red;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            label6.ForeColor = Color.Transparent;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}









