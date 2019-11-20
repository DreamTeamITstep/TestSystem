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
            var client = new RestClient("http://localhost:5000");
            var request = new RestRequest("auth / login", Method.POST);
            request.AddParameter("Login", textBoxLogin.Text);
            request.AddParameter("Password", GetHash(textBoxPassword.Text));
            //request.AddHeader(“Authentication”, $“Bearer {token}”);
            request.AddHeader("Content - Type", "application / json");
            try
            {
                var response = client.Execute(request);
                token = response.Content;
                isAuthentificated = true;
                this.Close();              
            }
            catch(Exception ex)
            {
                MessageBox.Show("Не вірний логін та пароль");
            }
        }

        private string GetHash(string input)
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));
            MessageBox.Show(Convert.ToBase64String(hash));
            return Convert.ToBase64String(hash);
        }
    }
}
