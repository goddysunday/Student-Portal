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
using System.IO;
using ishop;

namespace StudentPortal1
{
    public partial class ReportCard : Form
    {
        SqlConnection scn = new SqlConnection();
        SqlDataAdapter data = new SqlDataAdapter();
        MemoryStream ms = new MemoryStream();

        int studentid;
        string firstname;
        string surname;
        int totalscore;
        float average;
        string grade;
        int maths, businessstudies, coding, english, rnv, history;

        private void button2_Click(object sender, EventArgs e)
        {
            txtStudentId.Text = "";
            txtFullName.Text = "";
            txtSurname.Text = "";
            txtTotalScore.Text = "";
            txtAverage.Text = "";
            txtGrade.Text = "";
            txtMaths.Text = "";
            txtBusinessStudies.Text = "";
            txtCoding.Text = "";
            txtEnglish.Text = "";
            txtRNV.Text = "";
            txtHistory.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Add(txtStudentId.Text,txtFullName.Text,
              txtSurname.Text,txtMaths.Text,txtBusinessStudies.Text,txtCoding.Text,
               txtEnglish.Text,txtRNV.Text,txtHistory.Text, txtTotalScore.Text,
               txtAverage.Text,txtGrade.Text);
            //Details.ClearSelected();
            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(txtDetails.Text, new Font("Microsoft Sans Serif", 18, FontStyle.Bold), Brushes.Black, new Point(10, 10));

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new AccountantDepartment().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();

        }

        public ReportCard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                studentid = Convert.ToInt32(txtStudentId.Text);
                firstname = txtFullName.Text;
                surname = txtSurname.Text;
               // totalscore = Convert.ToInt32(txtTotalScore.Text);
               // average = Convert.ToInt32(txtAverage.Text);
               // grade = txtGrade.Text;
                maths = Convert.ToInt32(txtMaths.Text);
                businessstudies = Convert.ToInt32(txtBusinessStudies.Text);
                coding = Convert.ToInt32(txtCoding.Text);
                english = Convert.ToInt32(txtEnglish.Text);
                rnv = Convert.ToInt32(txtRNV.Text);
                history = Convert.ToInt32(txtHistory.Text);

                totalscore = maths + businessstudies + coding + english + rnv + history;
                txtTotalScore.Text = totalscore.ToString();
                txtTotalScore.Show();
                average = totalscore / 5;
                txtAverage.Text = average.ToString();
                if (average >= 75)
                {
                    grade = txtGrade.Text = "You had a Grade A";
                }
                else if (average >= 60)
                {
                    grade = txtGrade.Text = "You had a Grade B";
                }
                else if (average >= 50)
                {
                    grade = txtGrade.Text = "You had a Grade C";
                }
                else if (average >= 45)
                {
                    grade = txtGrade.Text = "You had a Grade D";
                }
                else if (average >= 40)
                {
                    grade = txtGrade.Text = "You Had a Grade E";
                }
                else if (average >= 0)
                {
                    grade = txtGrade.Text = "You Had a Grade  F9";
                }
                else
                {
                    grade = txtGrade.Text = "Check your record, Thanks";
                }
                txtAverage.Show();


                txtDetails.Text += "************************";
                txtDetails.Text += "** REPORT CARD ****";

                txtDetails.Text += "Date " + DateTime.Now + "\n\n";

                txtDetails.Text += "Student ID:" + txtStudentId.Text + "\n\n";
                txtDetails.Text += "Student First Name: " + txtFullName.Text + "\n\n";
                txtDetails.Text += "Surname: " + txtSurname.Text + "\n\n";
                txtDetails.Text += "Maths Score: " + txtMaths.Text + "\n\n";
                txtDetails.Text += "Business Studies: " + txtBusinessStudies.Text + "\n\n";
                txtDetails.Text += "Coding: " + txtCoding.Text + "\n\n";
                txtDetails.Text += "English Lang: " + txtEnglish.Text + "\n\n";
                txtDetails.Text += "RNV: " + txtRNV.Text + "\n\n";
                txtDetails.Text += "History: " + txtHistory.Text + "\n\n";
               // txtDetails.Text += "Total Score: " + txtTotalScore.Text + "\n\n";
               // txtDetails.Text += "Average Score: " + txtAverage.Text + "\n\n";
               // txtDetails.Text += "Grade: " + txtGrade.Text + "\n\n";
                txtDetails.Show();



                SqlConnection con = ConnectionClass.SQLCONNECTION();
                SqlDataAdapter da = new SqlDataAdapter();
                string querry = ("insert into ReportCard values ('" + txtStudentId.Text + "','" + txtFullName.Text + "','" + txtSurname.Text + "','" + txtMaths.Text + "','" + txtBusinessStudies.Text + "','" + txtCoding.Text + "','" + txtEnglish.Text + "','" + txtRNV.Text + "','" + txtHistory.Text + "') ");
                SqlCommand cmdDataBase = new SqlCommand(querry, con);
                da.InsertCommand = new SqlCommand(querry, con);
                con.Open();
                // cmdDataBase.Parameters.Add(new SqlParameter("@images", images));
                int roweffected = da.InsertCommand.ExecuteNonQuery();
                // data.GetFillParameters.add
                con.Close();
                MessageBox.Show("New student inserted successfully");

               // '" + txtTotalScore.Text + "','" + txtAverage.Text + "','" + txtGrade.Text + "',


                
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Check your information and retry ");
            }

        }
    }
}








