using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestSystem.Common;

namespace TestSystem.Sender.App
{
    public partial class FormAuth : Form
    {
        static string GetMd5Hash(MD5 md5Hash, string input)
        {
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }
        public static string Token { get; private set; } = string.Empty;
        public FormAuth()
        {
            InitializeComponent();
        }

        private void button_SignIn_Click(object sender, EventArgs e)
        {
            var loginr= new LoginRequest();
            var client = new RestClient("http://localhost:32225");
            var request = new RestRequest("auth/login", Method.POST);
            request.RequestFormat = DataFormat.Json;
            using(var md5 = MD5.Create())
            {
                loginr = new LoginRequest() {
                    Login = textBox_Login.Text, 
                    Password = GetMd5Hash(md5, textBox_Password.Text) 
                };
            }
            request.AddBody(loginr);
            request.AddHeader("Content-Type", "application/json");
            var response = client.Execute(request);
            try
            {
                Token = response.Content;
            }
            catch (Exception)
            {
                MessageBox.Show("Incorrect login or password");
            }
            this.Close();
        }
    }
}
