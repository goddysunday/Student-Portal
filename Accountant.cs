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
using System.Data.Sql;
using System.Data.OleDb;
using SpeechLib;
using ishop;

namespace StudentPortal1
{
    public partial class Accountant : Form
    {
        SqlConnection con = new SqlConnection();
        SqlDataReader rdr = null;
        DataTable dtable = new DataTable();
        //SqlConnection con = null;
        SqlCommand cmd = null;
        DataTable dt = new DataTable();
        //Connectionstring cs = new Connectionstring();
        // clsFunc cf = new clsFunc();
        string st1;
        string st2;
        string textBox_usrname;
        string textBox_password;



        SqlConnection scn = new SqlConnection();
        SqlDataAdapter data = new SqlDataAdapter();
        SpVoice voice = new SpVoice();
        ConnectionClass db = new ConnectionClass();
        DataTable tb;

        int StaffId;
        string StaffName, password;
        DateTime date;

        private int STAFFID;
        private string STAFFNAME;
        private string PASSWORD;

        string uname;
        string pass;
        public Accountant()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-QNMJ0BT\\SQLEXPRESS; Initial Catalog=Student2;Integrated Security=True";

            InitializeComponent();
        }

        private void Accountant_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'sTUDENTDataSet.login' table. You can move, or remove it, as needed.  
            //this.loginTableAdapter.Fill(this.sTUDENTDataSet.login);  
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-QNMJ0BT\\SQLEXPRESS; Initial Catalog=Student2;Integrated Security=True");
            con.Open();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Accountant_Register().Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-QNMJ0BT\\SQLEXPRESS; Initial Catalog=Student2;Integrated Security=True";
            con.Open();
            string userid = txtusername.Text;
            string password = textBoxpassword.Text;
            SqlCommand cmd = new SqlCommand("select username,password from accountantLogin where username='" + txtusername.Text + "'and password='" + textBoxpassword.Text + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Login sucess Welcome to Homepage ");
                new AccountantDepartment().Show();
                Hide();

            }
            else
            {
                MessageBox.Show("Invalid Login please check username and password");
            }
            con.Close();
        }
    }
}




