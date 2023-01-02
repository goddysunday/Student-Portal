
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
    public partial class Fees_Table : Form
    {
        public Fees_Table()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtresult.Clear();
            txtresult.Text += "************************";
            txtresult.Text += "** FEES RECEIPT ****";

            txtresult.Text += "Date " + DateTime.Now + "\n\n";

            txtresult.Text += "Student Name:" + txtName.Text + "\n\n";
            txtresult.Text += "Class: " + txtClass.Text + "\n\n";
            txtresult.Text += "Amount: " + txtamountinword.Text + "\n\n";
            txtresult.Text += "Payment for" + txtpaymentfor.Text + "\n\n";
            txtresult.Text += "Amount: " + txtamount.Text + "\n\n";

            txtresult.Text += "\n         Signature ";
        }

        private void button2_Click(object sender, EventArgs e)
        {

            txtName.Text = "";
            txtClass.Text = "";
            txtamountinword.Text = "";
            txtpaymentfor.Text = "";
            txtamount.Text = "";
            txtresult.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(txtresult.Text, new Font("Microsoft Sans Serif", 18, FontStyle.Bold), Brushes.Black, new Point(10, 10));
        
    }

        private void button4_Click(object sender, EventArgs e)
        {
            new AdminOffice().Show();
            Hide();
        }
    }
}




      