using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SauceCracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenLinkIncog("https://nhentai.net/g/"+textBox2.Text);
        }

        private void OpenLinkIncog(string url)
        {
            var process = new Process
            {
                StartInfo = new ProcessStartInfo{ 
                    FileName = @"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", 
                    Arguments = url + " --new-window --incognito "
                }
            };
            process.Start();
        }
    }
}