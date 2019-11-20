using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using TestSystem.Common;

namespace TestSystem.Sender.App
{
    public partial class FormSender : Form
    {
        private string token;
        private string filePath;

        int groupID;
        int studentID;
        int studentInGroupID;

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
            XmlSerializer formatter = new XmlSerializer(typeof(Test));
            var client = new RestClient("http://localhost:5000");
            var request = new RestRequest("test", Method.POST);
            request.AddHeader("Authentication", $"Bearer {token}");
            request.AddHeader("Content-Type", "application/json");
            request.RequestFormat = DataFormat.Json;
            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            {
                request.AddBody((Test)formatter.Deserialize(fs));
            };
            var response = client.Execute<Test>(request);
        }

        private void FormSender_Load(object sender, EventArgs e)
        {
            var client = new RestClient("http://localhost:5000/Group");
            var request = new RestRequest("",Method.GET);
            request.AddHeader("Authentication", $"Bearer {token}");
            var response1 = client.Execute<List<Group>>(request);
            listBox_Groups.Items.AddRange(response1.Data.ToArray());
            client = new RestClient("http://localhost:5000/Student");
            request = new RestRequest(Method.GET);
            request.AddHeader("Authentication", $"Bearer {token}");
            var response2 = client.Execute<List<Student>>(request);
            listBox_AllStudents.Items.AddRange(response2.Data.ToArray());
        }

        private void listBox_Groups_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupID = ((Group)((ListBox)sender).SelectedItem).Id;
            foreach(Student student in listBox_AllStudents.Items)
            {
                if(student.GroupId.Contains(groupID))
                {
                    listBox_GroupStudents.Items.Add(student);
                    listBox_AllStudents.Items.Remove(student);
                }
            }
            foreach (Student student in listBox_GroupStudents.Items)
            {
                if (!student.GroupId.Contains(groupID))
                {
                    listBox_AllStudents.Items.Add(student);
                    listBox_GroupStudents.Items.Remove(student);
                }
            }
        }

        private void button_AddGroup_Click(object sender, EventArgs e)
        {
            var client = new RestClient("http://localhost:5000");
            var request = new RestRequest("group", Method.POST);
            request.AddHeader("Authentication", $"Bearer {token}");
            request.AddHeader("Content-Type", "application/json");
            request.RequestFormat = DataFormat.Json;
            request.AddBody(new Group() { Name = textBox_GroupName.Text });
            var response = client.Execute<Group>(request);
        }

        private void button_ModifyGroup_Click(object sender, EventArgs e)
        {
            var client = new RestClient("http://localhost:5000");
            var request = new RestRequest("group", Method.PUT);
            request.AddHeader("Authentication", $"Bearer {token}");
            request.AddHeader("Content-Type", "application/json");
            request.RequestFormat = DataFormat.Json;
            request.AddBody(new Group() { Id = groupID, Name = textBox_GroupName.Text });
            var response = client.Execute<Group>(request);
        }

        private void button_DeleteGroup_Click(object sender, EventArgs e)
        {
            var client = new RestClient("http://localhost:5000");
            var request = new RestRequest($"group/{groupID}", Method.DELETE);
            request.AddHeader("Authentication", $"Bearer {token}");
            var response = client.Execute<Group>(request);
        }

        private void button_AddToGroup_Click(object sender, EventArgs e)
        {
            var client = new RestClient("http://localhost:5000");
            var request = new RestRequest("student", Method.PUT);
            request.AddHeader("Authentication", $"Bearer {token}");
            request.AddHeader("Content-Type", "application/json");
            request.RequestFormat = DataFormat.Json;
            Student tmp = new Student() { Id = studentID };
            tmp.GroupId.Add(groupID);
            request.AddBody(tmp);
            var response = client.Execute<Student>(request);
        }

        private void listBox_AllStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            studentID = ((Student)((ListBox)sender).SelectedItem).Id;
        }

        private void listBox_GroupStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            studentInGroupID = ((Student)((ListBox)sender).SelectedItem).Id;
        }

        private void button_RemoveFromGroup_Click(object sender, EventArgs e)
        {
            var client = new RestClient("http://localhost:5000");
            var request = new RestRequest("student", Method.PUT);
            request.AddHeader("Authentication", $"Bearer {token}");
            request.AddHeader("Content-Type", "application/json");
            request.RequestFormat = DataFormat.Json;
            Student tmp = new Student() { Id = studentID };
            tmp.GroupId.Remove(groupID);
            request.AddBody(tmp);
            var response = client.Execute<Student>(request);
        }

    }
}
