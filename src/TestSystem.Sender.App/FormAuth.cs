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

namespace TestSystem.Sender.App
{
    public partial class FormAuth : Form
    {
        public static string Token { get; private set; } = string.Empty;
        public FormAuth()
        {
            InitializeComponent();
        }

        private void button_SignIn_Click(object sender, EventArgs e)
        {
            var client = new RestClient("http://localhost:5000");
            var request = new RestRequest("auth/login", Method.POST);
            request.AddParameter("Login", textBox_Login.Text);
            request.AddParameter("Password", MD5.Create(textBox_Password.Text));
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
