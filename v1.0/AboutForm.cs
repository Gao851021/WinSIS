using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WinSIS
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void LinkSourceforge_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                ProcessStartInfo sInfo = new ProcessStartInfo("https://sourceforge.net/projects/winsis-project/");
                Process.Start(sInfo);
            }
            catch (Exception) { };
        }

        private void LinkGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                ProcessStartInfo sInfo = new ProcessStartInfo("https://github.com/gavrash/WinSIS");
                Process.Start(sInfo);
            }
            catch (Exception) { };
        }

        private void LinkLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LicenseForm lform = new LicenseForm();
            lform.Show();
        }
    }
}
