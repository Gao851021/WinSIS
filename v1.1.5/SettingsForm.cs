using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WinSIS
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        public void LoadTexts(string lang, string button, string window)
        {
            labelLanguage.Text = lang;
            labelWindowSize.Text = window;
            btnSettings.Text = button;
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter sw = new StreamWriter("Data/SETTINGS.txt");
                switch (cboxLanguage.Text)
                {
                    case "English": sw.WriteLine("CurrentLanguage | English"); break;
                    case "Hungarian": sw.WriteLine("CurrentLanguage | Hungarian"); break;
                    case "Romanian": sw.WriteLine("CurrentLanguage | Romanian"); break;
                    default: sw.WriteLine("CurrentLanguage | English"); break;
                }
                switch (cboxWindowSize.Text)
                {
                    case "Small": sw.WriteLine("WindowSize | Small"); break;
                    case "Normal": sw.WriteLine("WindowSize | Normal"); break;
                    case "Large": sw.WriteLine("WindowSize | Large"); break;
                    default: sw.WriteLine("WindowSize | Normal"); break;
                }
                sw.Close();
                Application.Restart();
            }
            catch (Exception)
            {
                this.Close();
            }
        }
    }
}
