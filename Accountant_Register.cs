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
using ishop;

namespace StudentPortal1
{
    public partial class Accountant_Register : Form
    {
        string name, phone, address, email, qualification;

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtname.Text = "";
            txtphone.Text = "";
            txtaddress.Text = "";
            txtemail.Text = "";
            txtqualification.Text = "";
        }

        public Accountant_Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                name = txtname.Text;
                address = txtaddress.Text;
                phone = txtphone.Text;
                email = txtemail.Text;
                qualification = txtqualification.Text;
                SqlConnection con = ConnectionClass.SQLCONNECTION();
                SqlDataAdapter da = new SqlDataAdapter();
                string querry = ("insert into accountRegister values ('" + txtname.Text + "','" + txtaddress.Text + "','" + txtphone.Text + "','" + txtemail.Text + "','" + txtqualification.Text + "')");
                da.InsertCommand = new SqlCommand(querry, con);
                con.Open();
                int roweffected = da.InsertCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("New Accountant inserted successfully");
                new Accountant().Show();
                Hide();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Check your information and retry ");
            }

        }
    }
}






      