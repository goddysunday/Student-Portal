using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentPortal1
{
    public partial class Exams_Dashboard : Form
    {
        public Exams_Dashboard()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            new CBTCENTER().Show();
            Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            new Basic8Exams().Show();
            Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            new Basic7Exams().Show();
            Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            new Basic6_Exams().Show();
            Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new Basic5_Exams().Show();
            Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            new Basic4_Exams().Show();
            Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            new Basic3_Exams().Show();
            Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            new Basic2_exams().Show();
            Hide();

        }

        private void label10_Click(object sender, EventArgs e)
        {
            new Basic1_Exams().Show();
            Hide();
            
        }

        private void label11_Click(object sender, EventArgs e)
        {
            new Nursery_Exams().Show();
            Hide();
        }

        private void Exams_Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {
            new AdminOffice().Show();
            Hide();
        }
    }
}
