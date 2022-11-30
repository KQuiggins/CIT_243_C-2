using System.Diagnostics;
using System.IO;
using System.Text;
namespace RecentlyVisitedSites
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo psInfo = new ProcessStartInfo
            {
                FileName = "https://www.w3schools.com/",
                UseShellExecute = true
            };
            Process.Start(psInfo);
            flowLayoutPanel1.Controls.SetChildIndex(linkLabel1, 0);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo psInfo = new ProcessStartInfo
            {
                FileName = "https://learn.microsoft.com/en-us/",
                UseShellExecute = true
            };
            Process.Start(psInfo);
            flowLayoutPanel1.Controls.SetChildIndex(linkLabel2, 0);
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo psInfo = new ProcessStartInfo
            {
                FileName = "https://developer.mozilla.org/en-US/",
                UseShellExecute = true
            };
            Process.Start(psInfo);
            flowLayoutPanel1.Controls.SetChildIndex(linkLabel3, 0);
        }
    }
}