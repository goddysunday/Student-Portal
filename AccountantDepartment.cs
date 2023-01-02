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
    public partial class AccountantDepartment : Form
    {
        public AccountantDepartment()
        {
            InitializeComponent();
        }

        private void AccountantDepartment_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Fees_Table().Show();
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            new Staff_Department().Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            new TextBook_Supliers().Show();
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            new StudentForm().Show();

        }

        private void button12_Click(object sender, EventArgs e)
        {
            new SMS().Show();
            Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            new TakeExamPage().Show();
        }
    }
}
