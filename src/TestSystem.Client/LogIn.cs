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

namespace TestClient
{
    public partial class LogIn : Form
    {
        public bool isAuthentificated = false;
        public string token = String.Empty;
        public LogIn()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            GetAcces();
        }
        private void GetAcces()
        {
            var loginr = new LoginRequest();
            var client = new RestClient("http://localhost:32225");
            var request = new RestRequest("auth/login", Method.POST);
            request.RequestFormat = DataFormat.Json;
            using (var md5 = MD5.Create())
            {
                loginr = new LoginRequest()
                {
                    Login = textBoxLogin.Text,
                    Password = GetMd5Hash(md5, textBoxPassword.Text)
                };
            }
            request.AddBody(loginr);
            request.AddHeader("Content-Type", "application/json");
            try
            {
                var response = client.Execute(request);
                token = response.Content;
                isAuthentificated = true;
                this.Close();              
            }
            catch(Exception ex)
            {
                MessageBox.Show("Невірний логін та пароль");
            }
        }

        private string GetHash(string input)
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));
            MessageBox.Show(Convert.ToBase64String(hash));
            return Convert.ToBase64String(hash);
        }

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
    }
}
