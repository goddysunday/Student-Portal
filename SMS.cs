using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace StudentPortal1
{
    public partial class SMS : Form
    {
        SqlConnection scn = new SqlConnection();
        SqlDataAdapter data = new SqlDataAdapter();
        MemoryStream ms = new MemoryStream();
        private object cmd;

        public SMS()
        {
            InitializeComponent();
        }
        /*
        public object HttpUtility { get; private set; }

        private async Task btnSubmit_ClickAsync(object sender, EventArgs e)
        {
            try
            {

                WebClient client = new WebClient();
                Stream s = client.OpenRead(string.Format("https://platform.clickatell.com/v1/message", txtPhoneNumber, txtMessage));
                StreamReader reader = new StreamReader(s);
                string result = reader.ReadToEnd();
                MessageBox.Show(result, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        */
        private void btnSubmit_Click(object sender, EventArgs e)
        {

            try
            {
               /* 
                string result;
                using (var wb = new WebClient())
                {
                    byte[] response = wb.UploadValues("https://api.textlocal.in/send/", txtPhoneNumber, txtMessage();
                {
                {"apikey" , ""},
                {"numbers" , "08178066776"},
                {"message" , txtMsg.Text},
                {"sender" , ""}
                });
                    result = System.Text.Encoding.UTF8.GetString(response);
                }
                //MessageBox.Show(numbers.ToString());
                MessageBox.Show(result);*/
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
            }
        }
    }
}

            /*

                var username = "john";
                var password = "Xc3ffs";
                var messagetype = "SMS:TEXT";
                var httpUrl = "https://127.0.0.1:9508/";
                var recipient = HttpUtility.UrlEncode("+2348178066776", Encoding.UTF8);
                var messagedata = HttpUtility.UrlEncode("TestMessage", Encoding.UTF8);
           // HttpUtility.UrlEncode

                var sendString = $"{httpUrl}api?action=sendmessage&username=" +
                                 $"{username}&password={password}" +
                                 $"&recipient={recipient}&messagetype=" +
                                 $"{messagetype}&messagedata={messagedata}";

                Console.WriteLine("Sending request: " + sendString);

                var handler = new HttpClientHandler();
                //handler.ServerCertificateCustomValidationCallback =
                //(sender, cert, chain, sslPolicyErrors) => { return true; };

                var client = new HttpClient(handler);

                try
                {
                    var response = await client.GetStringAsync(sendString);
                    Console.WriteLine("Http response received: ");
                    Console.WriteLine(response);

                }
                catch (Exception ex)
                {
                MessageBox.Show(ex.Message);
                }
            
            }*/
   




               
    

