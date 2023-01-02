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

namespace StudentPortal1
{
    public partial class CBTCENTER : Form
    {

        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;
        int totalscore1;
        int totalscore = 1;

        public CBTCENTER()
        {
            InitializeComponent();
            askQuestion(questionNumber);

            totalQuestions = 8;
        }

        private void CBTCENTER_Load(object sender, EventArgs e)
        {

        }

        private void checkAnswerEvent_Click(object sender, EventArgs e)
        {

            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (buttonTag == correctAnswer)
            {
                score++;
                totalscore++;
            }

            if (questionNumber == totalQuestions)
            {
                // work out the percentage

                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);
                totalscore1 = (int)Math.Round((double)(totalscore * 10));
                MessageBox.Show(
                    "Quiz Ended!" + Environment.NewLine +
                    " You have answered " + score + " questions correctly." + Environment.NewLine +
                    "Your Total Score is: " + totalscore1 + Environment.NewLine + "Your total percentage is " + percentage + "%" + Environment.NewLine +
                    "We wish you success in your examinations"
                    );

                score = 0;
                questionNumber = 0;
                askQuestion(questionNumber);

            }

            questionNumber++;
            askQuestion(questionNumber);

        }

        private void askQuestion(int qnum)
        {

            switch (qnum)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.bg_4;

                    lblQuestion.Text = "What is the colour of the sky?";

                    button1.Text = "Blue";
                    button2.Text = "Yellow";
                    button3.Text = "Orange";
                    button4.Text = "Red";

                    correctAnswer = 0;

                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.bg_3;

                    lblQuestion.Text = "What is the name of the governor of Lagos State?";

                    button1.Text = "Mr. Tony Abudele";
                    button2.Text = "Mr. Fidelis";
                    button3.Text = "Mr. Sanwolu";
                    button4.Text = "Peter Quill";

                    correctAnswer = 2;

                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.bg2;

                    lblQuestion.Text = "What is a noun?";

                    button1.Text = "Call of Duty";
                    button2.Text = "Battlefield";
                    button3.Text = "Fortnite";
                    button4.Text = "A name of any person, animal,place or thing";

                    correctAnswer = 3;

                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.image_5;

                    lblQuestion.Text = "Which Publisher made this game?";

                    button1.Text = "EA";
                    button2.Text = "Activision";
                    button3.Text = "Epic Games";
                    button4.Text = "Equare Enix";

                    correctAnswer = 0;

                    break;

                case 5:
                    pictureBox1.Image = Properties.Resources.course_1;

                    lblQuestion.Text = "Whats the name of this game?";

                    button1.Text = "Gears of War";
                    button2.Text = "Assassins Creed";
                    button3.Text = "Uncharted";
                    button4.Text = "Call of Duty";

                    correctAnswer = 0;

                    break;

                case 6:
                    pictureBox1.Image = Properties.Resources.course_5;

                    lblQuestion.Text = "What is the name of your school?";

                    button1.Text = "Evergreen school";
                    button2.Text = "Lara Croft school";
                    button3.Text = "Master pete school";
                    button4.Text = " Drake school";

                    correctAnswer = 0;

                    break;

                case 7:
                    pictureBox1.Image = Properties.Resources.index4;

                    lblQuestion.Text = "Who is the president of Nigeria?";

                    button1.Text = "President Muhammadu Buari";
                    button2.Text = "President Duke";
                    button3.Text = "President Ciri";
                    button4.Text = " President Yennifer";

                    correctAnswer = 0;

                    break;

                case 8:
                    pictureBox1.Image = Properties.Resources.person_2;

                    lblQuestion.Text = "Which city is the captial city of England?";

                    button1.Text = "London";
                    button2.Text = "Brighton";
                    button3.Text = "Liverpool";
                    button4.Text = "London Bar";

                    correctAnswer = 0;

                    break;


            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Exams_Dashboard().Show();
            Hide();
        }
    }
}




/*

        private void button6_Click(object sender, EventArgs e)
        {
            // Form3 cry = new Form3();
            // cry.Show();
            //this.Hide();
            

            //Resize DataGridView to full height.
            int height = dataGridView1.Height;
            dataGridView1.Height = dataGridView1.RowCount * dataGridView1.RowTemplate.Height;

            //Create a Bitmap and draw the DataGridView on it.
            bitmap = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(bitmap, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));

            //Resize DataGridView back to original height.
            dataGridView1.Height = height;

            //Show the Print Preview Dialog.
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();

        }
        private void PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Print the contents.
            e.Graphics.DrawImage(bitmap, 0, 0);
        }*/
        



