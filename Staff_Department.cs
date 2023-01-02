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
    public partial class Staff_Department : Form
    {
        SqlConnection scn = new SqlConnection();
        SqlDataAdapter data = new SqlDataAdapter();
        MemoryStream ms = new MemoryStream();


        int StaffId;
        string StaffName;
        string Gender1;
        string Gender2;
        string dateofJoining;
        string Designation, Qualification, Address;
        string DOB;
        string mobileNo, email, PreviousSchool, BasicSalary, department;
        string AccountName,accountNo, Bank,Branch, NimcCode;

        private void Browse_Click(object sender, EventArgs e)
        {

            // browse photo from your computer
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Photo(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
                txtPicture.Image = Image.FromFile(opf.FileName);

            openFileDialog1.Filter = "jpeg|*.jpg|bmp|*.bmp|all files|*.*";
            DialogResult res = openFileDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                txtPicture.Image = Image.FromFile(openFileDialog1.FileName);
            }

            // create to strings for the connection and the query
            // string connString = @"Integrated Security = True;DESKTOP-QNMJ0BT\SQLEXPRESS; Initial Catalog=Student2";
            // ; ; Persist Security Info = False

            /*
            using (SqlConnection scn = new SqlConnection(connString))
            {
                string sqlQuery = @"SELECT * from studentportal";
                SqlCommand cmd = new SqlCommand(sqlQuery, scn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                da.Fill(table);
                // table.DataSet=table
                //listView1.DataSource = new BindingSource(table, null);

                //SqlConnection scn = new SqlConnection(connString);
                SqlDataAdapter sqlDa = new SqlDataAdapter("studentportal", scn);
                DataTable dtEmployees = new DataTable();
                da.Fill(dtEmployees);
                //listView1.DataSource = dtEmployees;
            }*/
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtStaffID.Text = "";
            txtStaffName.Text = "";
            rbMale.Text = "";
            rbFemale.Text = "";
            dtpDateOfJoining.Text = "";
            cmbDesignation.Text = "";
            txtQualifications.Text = "";
            txtPermanentAddress.Text = "";
            dtpDOB.Text = "";
            txtMobileNo.Text = "";
            txtEmail.Text = "";
            txtPreviousSchool.Text = "";
            txtBasicSalary.Text = "";
            txtDepartment.Text = "";
            txtAccountName.Text = "";
            txtAccountNo.Text = "";
            txtBank.Text = "";
            txtBranch.Text = "";
            txtIFSCcode.Text = "";
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            new staffGetRecord().Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            new AdminOffice().Show();
            Hide();
        }

        Byte pictures;
        

        private void txtPermanentAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try {
                StaffId = Convert.ToInt32(txtStaffID.Text);StaffName = txtStaffName.Text;
                if(rbMale.Text=="Male")
                {
                    Gender1 = "Male";
                }
                else if (rbFemale.Text == "Female")
                {
                    Gender2 = "Female";
                }
                dateofJoining = dtpDateOfJoining.Text; Designation = cmbDesignation.Text;
                Qualification = txtQualifications.Text;Address = txtPermanentAddress.Text;
                DOB = dtpDOB.Text; mobileNo = txtMobileNo.Text;
                email = txtEmail.Text; PreviousSchool = txtPreviousSchool.Text;
                BasicSalary = txtBasicSalary.Text; department = txtDepartment.Text;
                AccountName = txtAccountName.Text; accountNo = txtAccountNo.Text;
                Bank = txtBank.Text; Branch = txtBranch.Text;NimcCode = txtIFSCcode.Text;
               // pictures = txtPicture.Text;


            SqlConnection con = ConnectionClass.SQLCONNECTION();
            SqlDataAdapter da = new SqlDataAdapter();
            string querry = ("insert into StaffReg values ('" + txtStaffID.Text + "','" + txtStaffName.Text + "','" + rbMale.Text + "','" + rbFemale.Text + "','" + dtpDateOfJoining.Text + "','" + cmbDesignation.Text + "','" + txtQualifications.Text + "','" + txtPermanentAddress.Text + "','" + dtpDOB.Text + "','" + txtMobileNo.Text + "','" + txtEmail.Text + "','" + txtPreviousSchool.Text + "','" + txtBasicSalary.Text + "','" + txtDepartment.Text + "','" + txtAccountName.Text + "','" + txtAccountNo.Text + "','" + txtBank.Text + "','" + txtBranch.Text + "','" + txtIFSCcode.Text + "') ");
            SqlCommand cmdDataBase = new SqlCommand(querry, con);
            da.InsertCommand = new SqlCommand(querry, con);
            con.Open();
            // cmdDataBase.Parameters.Add(new SqlParameter("@images", images));
            int roweffected = da.InsertCommand.ExecuteNonQuery();
            // data.GetFillParameters.add
            con.Close();
            MessageBox.Show("New student inserted successfully");
        }
            catch (FormatException ex)
            {
                MessageBox.Show("Check your information and retry ");
            }
}

        public Staff_Department()
        {
            InitializeComponent();
        }

        private void Staff_Department_Load(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
