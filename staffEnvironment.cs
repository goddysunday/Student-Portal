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
    public partial class staffEnvironment : Form
    {
        public staffEnvironment()
        {
            InitializeComponent();
        }

        private void staffEnvironment_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            new Attendance().Show();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            new Exams_Dashboard().Show();
        }
    }
}
