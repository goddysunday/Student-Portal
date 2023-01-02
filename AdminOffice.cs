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
    public partial class AdminOffice : Form
    {
        public AdminOffice()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            new StudentForm().Show();
            Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            new Exams_Dashboard().Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Fees_Table().Show();
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            new Staff_Department().Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            new Hostel().Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            new TextBook_Supliers().Show();

        }

        private void button16_Click(object sender, EventArgs e)
        {
            new Form1().Show();
        }
    }
}
