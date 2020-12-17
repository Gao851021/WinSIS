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

        private long ram = 0;
        private bool fClosed = false;
        private List<string> LangValue;

        public void LoadDetails(string detail, string component, List<string> langvalue, byte wsize)
        {
            if (wsize > 7)
            {
                this.Font = new Font("Segoe UI", wsize);
            }
            this.Text = component;
            txtDetail.Text = detail;
            LangValue = langvalue;

            if (component == "Memory" || component == "Memória" || component == "Memorie")
            {
                txtStats.Font = new Font("Segoe UI", 9);
                txtStats.Text = LangValue[112];
                Thread thMemoryStats = new Thread(MemoryStats);
                foreach (ManagementObject obj in new ManagementObjectSearcher("SELECT TotalPhysicalMemory FROM Win32_ComputerSystem").Get())
                {
                    ram = Convert.ToInt64(obj["TotalPhysicalMemory"]) / 1024 / 1024;
                }
                thMemoryStats.Start();
            }
            if (component == "Processor" || component == "Processzor" || component == "Procesor")
            {
                txtStats.Text = LangValue[112];
                Thread thCpuStats = new Thread(ProcessorStats);
                thCpuStats.Start();
            }
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
        private void ProcessorStats()
        {
            fClosed = false;
            PerformanceCounter CPUCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            while (!fClosed)
            {
                try
                {
                    string s = String.Format("{0} {1}:  {2:0.00}%", LangValue[3], LangValue[111], Convert.ToDouble(CPUCounter.NextValue()));
                    this.Invoke(new MethodInvoker(() => txtStats.Text = s));
                }
                catch (Exception) { };
                Thread.Sleep(1000);
            }
        }

        private void DataForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            fClosed = true;
        }
    }
}
