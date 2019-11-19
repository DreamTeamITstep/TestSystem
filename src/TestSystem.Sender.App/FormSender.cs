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
    public partial class FormSender : Form
    {
        private string token;
        private string filePath;
        public FormSender()
        {
            InitializeComponent();
        }
        public FormSender(string token)
        {
            InitializeComponent();
            this.token = token;
        }

        private void button_SearchFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog() { Filter = "XML files (*.xml)|*.xml" };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                filePath = dialog.FileName;
                textBox_FilePath.Text = filePath;
            }
        }

        private void button_SendOnServer_Click(object sender, EventArgs e)
        {
            var client = new RestClient("http://localhost:5000/Test");
            var request = new RestRequest("auth / login", Method.POST);
            request.AddHeader("Authentication", $"Bearer {token}");
            request.AddHeader("Content - Type", "application / json");
            //var response = client.Execute<Test>(request);
        }
    }
}
