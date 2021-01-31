using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Management;
using System.Diagnostics;

namespace WinSIS
{
    public partial class DataForm : Form
    {
        public DataForm()
        {
            InitializeComponent();
        }

        Thread thMemoryStats, thBatteryStats;
        private long ram = 0;
        private bool fClosed = false;
        private string component;
        private List<string> LangValue;

        public void LoadDetails(string detail, string component, List<string> langvalue, byte wsize)
        {
            this.component = component;
            if (wsize > 7)
            {
                this.Font = new Font("Segoe UI", wsize);
            }
            this.Text = component;
            txtDetail.Text = detail;
            LangValue = langvalue;

            try
            {
                if (component == "Operating System" || component == "Operációs rendszer" || component == "Sistem de operare")
                {
                    this.Icon = new Icon("Data/RES/ICO/WINDOWS.ico");
                }

                if (component == "Motherboard" || component == "Alaplap" || component == "Placă de bază")
                {
                    this.Icon = new Icon("Data/RES/ICO/MOTHERBOARD.ico");
                }
                if (component == "Processor" || component == "Processzor" || component == "Procesor")
                {
                    this.Icon = new Icon("Data/RES/ICO/PROCESSOR.ico");
                }

                if (component == "Memory" || component == "Memória" || component == "Memorie")
                {
                    this.Icon = new Icon("Data/RES/ICO/MEMORY.ico");
                    txtStats.Font = new Font("Segoe UI", 9);
                    txtStats.Text = LangValue[112];
                    thMemoryStats = new Thread(MemoryStats);
                    foreach (ManagementObject obj in new ManagementObjectSearcher("SELECT TotalPhysicalMemory FROM Win32_ComputerSystem").Get())
                    {
                        ram = Convert.ToInt64(obj["TotalPhysicalMemory"]) / 1024 / 1024;
                    }
                    thMemoryStats.Start();
                }

                if (component == "Graphics" || component == "Grafika" || component == "Grafică")
                {
                    this.Icon = new Icon("Data/RES/ICO/GRAPHICS.ico");
                }

                if (component == "Storage" || component == "Tárhely" || component == "Depozitare")
                {
                    this.Icon = new Icon("Data/RES/ICO/STORAGE.ico");
                }

                if (component == "Network" || component == "Hálózat" || component == "Reţea")
                {
                    this.Icon = new Icon("Data/RES/ICO/NETWORK.ico");
                }

                if (component == "Peripherals" || component == "Perifériák" || component == "Periferice")
                {
                    this.Icon = new Icon("Data/RES/ICO/PERIPHERALS.ico");
                }

                if (component == "Printers" || component == "Nyomtatók" || component == "Imprimante")
                {
                    this.Icon = new Icon("Data/RES/ICO/PRINTERS.ico");
                }

                if (component == "Battery" || component == "Akkumulátor" || component == "Baterie")
                {
                    this.Icon = new Icon("Data/RES/ICO/BATTERY.ico");
                    txtStats.Font = new Font("Segoe UI", 9);
                    txtStats.Text = LangValue[112];
                    thBatteryStats = new Thread(BatteryStats);
                    thBatteryStats.Start();
                }
            }
            catch (Exception) { MessageBox.Show("ERROR: MISSING FILES"); this.Close(); };
        }
        private void MemoryStats()
        {
            fClosed = false;
            while (!fClosed)
            {
                foreach (ManagementObject obj in new ManagementObjectSearcher("SELECT FreePhysicalMemory, TotalVirtualMemorySize ,FreeVirtualMemory FROM Win32_OperatingSystem").Get())
                {
                    string s = String.Format("[{0}]\t\t\t\t    [{1}]\n", LangValue[123], LangValue[124]);
                    s += String.Format("{0}: {1}MB ({2:0.00}GB)  {3:0.00}%\t    {4}: {5}MB ({6:0.00}GB)  {7:0.00}%\n", LangValue[125], ram - (Convert.ToInt64(obj["FreePhysicalMemory"]) / 1024), (Convert.ToDouble(ram) / 1024) - (Convert.ToDouble(obj["FreePhysicalMemory"]) / 1024 / 1024), ((ram - (Convert.ToDouble(obj["FreePhysicalMemory"]) / 1024)) / ram) * 100, LangValue[125], (Convert.ToInt64(obj["TotalVirtualMemorySize"]) / 1024) - (Convert.ToInt64(obj["FreeVirtualMemory"]) / 1024), ((Convert.ToDouble(Convert.ToInt64(obj["TotalVirtualMemorySize"]) / 1024)) / 1024) - (Convert.ToDouble(obj["FreeVirtualMemory"]) / 1024 / 1024), (((Convert.ToInt64(obj["TotalVirtualMemorySize"]) / 1024) - (Convert.ToDouble(obj["FreeVirtualMemory"]) / 1024)) / (Convert.ToInt64(obj["TotalVirtualMemorySize"]) / 1024)) * 100);
                    s += String.Format("{0}: {1}MB ({2:0.00}GB)  {3:0.00}%\t    {4}: {5}MB ({6:0.00}GB)  {7:0.00}%", LangValue[126], Convert.ToInt64(obj["FreePhysicalMemory"]) / 1024, Convert.ToDouble(obj["FreePhysicalMemory"]) / 1024 / 1024, ((Convert.ToDouble(obj["FreePhysicalMemory"]) / 1024) / ram) * 100, LangValue[126], Convert.ToInt64(obj["FreeVirtualMemory"]) / 1024, Convert.ToDouble(obj["FreeVirtualMemory"]) / 1024 / 1024, ((Convert.ToDouble(obj["FreeVirtualMemory"]) / 1024) / (Convert.ToInt64(obj["TotalVirtualMemorySize"]) / 1024)) * 100);
                    try
                    {
                        this.Invoke(new MethodInvoker(() => txtStats.Text = s));
                    }
                    catch (Exception) { };
                }
                Thread.Sleep(1000);
            }
        }

        private void BatteryStats()
        {
            fClosed = false;
            while (!fClosed)
            {
                foreach (ManagementObject obj in new ManagementObjectSearcher("SELECT EstimatedChargeRemaining, DesignVoltage, EstimatedRunTime FROM Win32_Battery").Get())
                {
                    string s = String.Format("{0}: {1}%\n", LangValue[165], obj["EstimatedChargeRemaining"]); // Charge remaining
                    s += String.Format("{0}:  {1:0.00}V\n", LangValue[166], Convert.ToDouble(obj["DesignVoltage"]) / 1000); // Current voltage
                    s += String.Format("{0}:  {1:0.00} {2}", LangValue[168], Convert.ToDouble(obj["EstimatedRunTime"]) / 60, LangValue[167]); // Time remaining
                    try
                    {
                        this.Invoke(new MethodInvoker(() => txtStats.Text = s));
                    }
                    catch (Exception) { };
                }
                Thread.Sleep(1000);
            }
        }

        private void DataForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (component == "Memory" || component == "Memória" || component == "Memorie") { thMemoryStats.Abort(); };
            if (component == "Battery" || component == "Akkumulátor" || component == "Baterie") { thBatteryStats.Abort(); };
            fClosed = true;
        }
    }
}
