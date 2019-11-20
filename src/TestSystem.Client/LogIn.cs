using RestSharp;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using TestSystem.Common;

namespace TestClient
{
    public partial class LogIn : Form
    {
        public bool isAuthentificated = false;
        public string Token { get; private set; } = String.Empty;
        public LogIn()
        {
            InitializeComponent();
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
                Token = response.Content;
                isAuthentificated = true;
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Невірний логін та пароль");
            }
        }
        private string GetMd5Hash(MD5 md5Hash, string input)
        {
            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();
            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            // Return the hexadecimal string.
            return sBuilder.ToString();
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
