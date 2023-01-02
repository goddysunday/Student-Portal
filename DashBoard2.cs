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

namespace StudentPortal1
{
    public partial class DashBoard2 : Form
    {
        public static string Id = "";

        public DashBoard2(string id)
        {
            Id = id;
            InitializeComponent();
        }
        public DashBoard2()
        {
        }


        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            student homePage = new student();
            homePage.Show();
        }

        private void DashBoard2_Load(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditProfilePage editProfilePage = new EditProfilePage(Id);
            editProfilePage.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ExamsPage1 takeExamPage = new ExamsPage1(Id);
            takeExamPage.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-QNMJ0BT\\SQLEXPRESS; Initial Catalog=Student2;Integrated Security=True");
                con.Open();

                string newcon = "select  * from signuptable1 where ID='" + Id + "'";

                SqlCommand cmd = new SqlCommand(newcon, con);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    label8.Text = (dr["Name"].ToString());
                    label9.Text = (dr["ID"].ToString());
                    label10.Text = (dr["Year"].ToString());
                    label11.Text = (dr["Semester"].ToString());
                    label12.Text = (dr["Totalmark"].ToString());
                    label13.Text = (dr["Examno"].ToString());
                    label15.Text = (dr["Rating"].ToString());
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}







        
       

        











