using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestSystem.Sender.App
{
    public partial class FormSender : Form
    {
        private string filePath;
        public FormSender()
        {
            InitializeComponent();
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
    }
}
