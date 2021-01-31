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
using System.Threading;
using System.Management;
using System.Net.NetworkInformation;
using System.Net;
using System.IO;

namespace WinSIS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        Thread[] thDetail = new Thread[10];
        Thread thProgCPU, thProgRAM, thProgSpace;
        private bool fclosed = false;
        private byte WindowSizeValue = 0;
        private byte CurrentLanguageValue = 1;
        private string[] info = new string[10];
        private string[] detail = new string[10];
        private string[] componentName = new string[10];
        private List<string> LangValue = new List<string>();
        public string shortbreak = "\r\n----------------------------\r\n";
        public string linebreak = "\r\n------------------------------------------------------\r\n";

        private void MainForm_Shown(object sender, EventArgs e)
        {
            FileStream fs;
            StreamReader sr;
            try
            {
                fs = new FileStream("Data/SETTINGS.txt", FileMode.Open);
                sr = new StreamReader(fs);

                switch (sr.ReadLine())
                {
                    case "CurrentLanguage | English": CurrentLanguageValue = 1; break;
                    case "CurrentLanguage | Hungarian": CurrentLanguageValue = 2; break;
                    case "CurrentLanguage | Romanian": CurrentLanguageValue = 3; break;
                    default: CurrentLanguageValue = 1; break;
                }

                switch (sr.ReadLine())
                {
                    case "WindowSize | Small":
                        this.Font = new Font("Segoe UI", 7);
                        WindowSizeValue = 7;
                        break;
                    case "WindowSize | Normal":
                        WindowSizeValue = 0;
                        break;
                    case "WindowSize | Large":
                        this.Font = new Font("Segoe UI", 10);
                        WindowSizeValue = 10;
                        break;
                    default:
                        WindowSizeValue = 0;
                        break;
                }

                fs = new FileStream("Data/LANG/LANG.csv", FileMode.Open);
                sr = new StreamReader(fs);

                string s;
                while (!sr.EndOfStream)
                {
                    s = sr.ReadLine();
                    string[] p = s.Split(';');
                    LangValue.Add(p[CurrentLanguageValue]);
                }
                fs.Close();
                sr.Close();

                txtOpSystem.Text = LangValue[112];
                txtMotherboard.Text = LangValue[112];
                txtProcessor.Text = LangValue[112];
                txtMemory.Text = LangValue[112];
                txtGraphics.Text = LangValue[112];
                txtStorage.Text = LangValue[112];
                txtNetwork.Text = LangValue[112];
                linkOpSystem.Text = LangValue[1]; // Operating System
                linkMotherboard.Text = LangValue[2]; // Motherboard
                linkProcessor.Text = LangValue[3]; // Processor
                linkMemory.Text = LangValue[4]; // Memory
                linkGraphics.Text = LangValue[5]; // Graphics
                linkStorage.Text = LangValue[6]; // Storage
                linkNetwork.Text = LangValue[7]; // Network
                btnPrinters.Text = LangValue[57]; // Printers
                btnBattery.Text = LangValue[161]; // Battery
                btnPeripherals.Text = LangValue[120]; // Peripherals
                lbl_progCPU.Text = LangValue[112]; // CPU progress
                lbl_progRAM.Text = LangValue[112]; // RAM progress
                lbl_progSpace.Text = LangValue[112]; // Space progress
                menuStrip.Items[0].Text = LangValue[8]; // File
                menuStrip.Items[1].Text = LangValue[9]; // View
                menuStrip.Items[2].Text = LangValue[10]; // About
                saveToolStripMenuItem.Text = LangValue[11]; // Save
                exitToolStripMenuItem.Text = LangValue[12]; // Exit
                reloadToolStripMenuItem.Text = LangValue[116]; // Reload
                settingsToolStripMenuItem.Text = LangValue[117]; // Options
                this.Text += LangValue[0] + " | " + Environment.MachineName; // System Information
            }
            catch (Exception) { MessageBox.Show("ERROR: MISSING FILES"); this.Close(); };

            linkOpSystem.Visible = true; linkMotherboard.Visible = true; linkProcessor.Visible = true;
            linkMemory.Visible = true; linkGraphics.Visible = true; linkStorage.Visible = true; linkNetwork.Visible = true;

            txtOpSystem.Visible = true; txtMotherboard.Visible = true; txtProcessor.Visible = true;
            txtMemory.Visible = true; txtGraphics.Visible = true; txtStorage.Visible = true; txtNetwork.Visible = true;

            btnOpSystem.Visible = true;  btnMotherboard.Visible = true; btnProcessor.Visible = true; btnMemory.Visible = true;
            btnGraphics.Visible = true; btnStorage.Visible = true; btnNetwork.Visible = true; btnPrinters.Visible = true;
            btnBattery.Visible = true; btnPeripherals.Visible = true;

            progCPU.Visible = true; progRAM.Visible = true; progSpace.Visible = true;
            lbl_progCPU.Visible = true; lbl_progRAM.Visible = true; lbl_progSpace.Visible = true;

            /* Detail loads from a different thread */
            thDetail[0] = new Thread(GetOpSystemDetail); thDetail[0].Start();
            thDetail[1] = new Thread(GetMotherboardDetail); thDetail[1].Start();
            thDetail[2] = new Thread(GetProcessorDetail); thDetail[2].Start();
            thDetail[3] = new Thread(GetMemoryDetail); thDetail[3].Start();
            thDetail[4] = new Thread(GetGraphicsDetail); thDetail[4].Start();
            thDetail[5] = new Thread(GetStorageDetail); thDetail[5].Start();
            thDetail[6] = new Thread(GetNetworkDetail); thDetail[6].Start();
            thDetail[7] = new Thread(GetPeripheralsDetail); thDetail[7].Start();
            thDetail[8] = new Thread(GetPrintersDetail); thDetail[8].Start();
            thDetail[9] = new Thread(GetBatteryDetail); thDetail[9].Start();

            /* Usage progresses */
            thProgCPU = new Thread(ProcessorUsage_Progress); thProgCPU.Start();
            thProgRAM = new Thread(RamUsage_Progress); thProgRAM.Start();
            thProgSpace = new Thread(SpaceUsed_Progress); thProgSpace.Start();

            /* Operating System summary information */
            componentName[0] = LangValue[1]; // Operating System
            foreach (ManagementObject obj in new ManagementObjectSearcher("SELECT Caption, OSArchitecture, WindowsDirectory ,Version FROM Win32_OperatingSystem").Get())
            {
                info[0] += String.Format("{0}  ({1}){2}[{3}]:  {4}\r\n[{5}]:  {6}", obj["Caption"], obj["OSArchitecture"], linebreak, LangValue[13], obj["WindowsDirectory"], LangValue[14], obj["Version"]); // Name, Architecture, Directory, Version
            }
            txtOpSystem.Text = info[0];

            /* Motherboard summary information */
            componentName[1] = LangValue[2]; // Motherboard
            foreach (ManagementObject obj in new ManagementObjectSearcher("SELECT Product, Manufacturer FROM Win32_Baseboard").Get())
            {
                info[1] += String.Format("{0}{1}[{2}]:  {3}", obj["Product"], linebreak, LangValue[15], obj["Manufacturer"]); // Manufacturer
            }
            foreach (ManagementObject obj in new ManagementObjectSearcher("SELECT SMBIOSBIOSVersion FROM Win32_BIOS").Get())
            {
                info[1] += String.Format("\r\n[{0}]:  {1}", LangValue[16], obj["SMBIOSBIOSVersion"]); // BIOS Version
            }
            txtMotherboard.Text = info[1];

            /* Processor summary information */
            componentName[2] = LangValue[3]; // Processor
            foreach (ManagementObject obj in new ManagementObjectSearcher("SELECT Name, NumberOfCores, NumberOfLogicalProcessors, SocketDesignation, Caption FROM Win32_Processor").Get())
            {
                info[2] = String.Format("{0}{1}[{2}]: {3}\t[{4}]: {5}\r\n[{6}]:  {7}\r\n[{8}]:  {9}", obj["Name"], linebreak, LangValue[17], obj["NumberOfCores"], LangValue[18], obj["NumberOfLogicalProcessors"], LangValue[19], obj["SocketDesignation"], LangValue[20], obj["Caption"]); // Cores,  Threads, Socket, Stepping
            }
            txtProcessor.Text = info[2];

            /* Memory summary information */
            componentName[3] = LangValue[4]; // Memory
            foreach (ManagementObject obj in new ManagementObjectSearcher("SELECT TotalPhysicalMemory FROM Win32_ComputerSystem").Get())
            {
                info[3] = String.Format("[{0}]:      {1:0.00}GB", LangValue[21], Convert.ToDouble(obj["TotalPhysicalMemory"]) / 1024 / 1024 / 1024); // Total RAM
            }

            int memspeed = 0;
            byte i = 0, memtype = 0;
            foreach (ManagementObject obj in new ManagementObjectSearcher("SELECT Speed, MemoryType FROM Win32_PhysicalMemory").Get())
            {
                memspeed = Convert.ToInt32(obj["Speed"]);
                memtype = Convert.ToByte(obj["MemoryType"]);
                i++;
            }
            switch (i)
            {
                case 0: info[3] += String.Format(" (1 {0}){1}", LangValue[25], linebreak); break; // module
                case 1: info[3] += String.Format(" (1 {0}){1}", LangValue[25], linebreak); break; // module
                default: info[3] += String.Format(" ({0} {1}){2}", i, LangValue[26], linebreak); break; // modules
            }
            if (memtype == 0)
            {
                try
                {
                    foreach (ManagementObject obj in new ManagementObjectSearcher("SELECT SMBIOSMemoryType FROM Win32_PhysicalMemory").Get())
                    {
                        memtype = Convert.ToByte(obj["SMBIOSMemoryType"]);
                    }
                }
                catch (Exception) { };
            }

            info[3] += String.Format("[{0}]:  ", LangValue[23]); // Memory Type
            switch (memtype)
            {
                case 0: info[3] += String.Format("{0}", LangValue[37]); break; // Unknown
                case 1: info[3] += String.Format("{0}", LangValue[37]); break; // Unknown
                case 17: info[3] += String.Format("{0}", LangValue[37]); break; // Unknown
                case 20: info[3] += "DDR"; break;
                case 21: info[3] += "DDR2"; break;
                case 22: info[3] += "DDR3"; break;
                case 24: info[3] += "DDR3"; break;
                case 26: info[3] += "DDR4"; break;
                default: info[3] += String.Format("{0}", LangValue[38]); break; // Undefined
            }

            info[3] += String.Format("\r\n[{0}]:  ", LangValue[22]); // Speed
            switch (memspeed)
            {
                case 0: info[3] += String.Format("{0}", LangValue[37]); break; // Unknown
                default: info[3] += String.Format("{0} MHz", memspeed); break;

            }

            info[3] += String.Format("\r\n[{0}]:  ", LangValue[24]); // Channel
            switch (i)
            {
                case 0: info[3] += String.Format("{0}", LangValue[27]); break; // Single-channel
                case 1: info[3] += String.Format("{0}", LangValue[27]); break; // Single-channel
                case 2: info[3] += String.Format("{0}", LangValue[28]); break; // Dual-channel
                case 3: info[3] += String.Format("{0}", LangValue[29]); break; // Triple-channel
                case 4: info[3] += String.Format("{0}", LangValue[30]); break; // Quad-channel
                case 6: info[3] += String.Format("{0}", LangValue[31]); break; // Six-channel
                case 8: info[3] += String.Format("{0}", LangValue[32]); break; // Eight-channel
            }
            txtMemory.Text = info[3];

            /* Graphics summary information */
            componentName[4] = LangValue[5]; // Graphics
            List<string> Resolution = new List<string>();
            List<string> RefreshRate = new List<string>();

            foreach (ManagementObject obj in new ManagementObjectSearcher("SELECT CurrentHorizontalResolution, CurrentVerticalResolution, CurrentRefreshRate FROM Win32_VideoController").Get())
            {
                Resolution.Add(String.Format("{0}x{1}", obj["CurrentHorizontalResolution"], obj["CurrentVerticalResolution"]));
                RefreshRate.Add(String.Format("{0} Hz", obj["CurrentRefreshRate"]));
            }
            i = 0;
            foreach (ManagementObject obj in new ManagementObjectSearcher("SELECT Name FROM Win32_DesktopMonitor").Get())
            {
                info[4] += String.Format("[{0}]:  {1} (", LangValue[33], obj["Name"], Resolution[i], RefreshRate[i]); // Display
                try
                {
                    switch (Resolution[i])
                    {
                        case "x": break;
                        default: info[4] += String.Format("{0}", Resolution[i]); break;
                    }
                    switch (RefreshRate[i])
                    {
                        case " Hz": break;
                        default: info[4] += String.Format(", {0}", RefreshRate[i]); break;
                    }
                }
                catch (Exception) { };
                info[4] += ") \r\n";
                i++;
            }

            foreach (ManagementObject obj in new ManagementObjectSearcher("SELECT Name, AdapterRAM FROM Win32_VideoController").Get())
            {
                info[4] += String.Format("[GPU]:  {0} {1}MB ({2:0.00}GB)\r\n", obj["Name"], Convert.ToInt64(obj["AdapterRAM"]) / 1024 / 1024, Convert.ToDouble(obj["AdapterRAM"]) / 1024 / 1024 / 1024);
            }
            txtGraphics.Text = info[4];

            /* Storage summary information */
            componentName[5] = LangValue[6]; // Storage
            foreach (ManagementObject obj in new ManagementObjectSearcher("SELECT Model, Size FROM Win32_DiskDrive").Get())
            {
                info[5] += String.Format("{0}  ({1:0.0}GB", obj["Model"], Convert.ToDouble(obj["Size"]) / 1024 / 1024 / 1024);
                if (obj["Model"].ToString().Contains("ATA"))
                {
                    info[5] += " , SATA";
                }
                else if (obj["Model"].ToString().Contains("IDE"))
                {
                    info[5] += " , IDE";
                }
                else if (obj["Model"].ToString().Contains("SSD") || obj["Model"].ToString().Contains("Solid State"))
                {
                    info[5] += " , SSD";
                }
                info[5] += ")\r\n";
            }
            txtStorage.Text = info[5];

            /* Network summary information */
            componentName[6] = LangValue[7]; // Network
            foreach (ManagementObject obj in new ManagementObjectSearcher("SELECT Name, AdapterType, Manufacturer, MACAddress, NetConnectionStatus, ServiceName FROM Win32_NetworkAdapter").Get())
            {
                if (Convert.ToString(obj["AdapterType"]) == "Ethernet 802.3")
                {
                    info[6] += String.Format("{0}{1}", obj["Name"], linebreak);
                    info[6] += String.Format("[{0}]:  ", LangValue[82]); // Type
                    if (Convert.ToString(obj["Name"]).Contains("Wireless") || Convert.ToString(obj["Name"]).Contains("vezeték nélküli") || Convert.ToString(obj["Name"]).Contains("fără fir"))
                    {
                        info[6] += String.Format("{0}\r\n", LangValue[92]); // Wireless
                    }
                    else if (Convert.ToString(obj["Name"]).Contains("Bluetooth"))
                    {
                        info[6] += String.Format("Bluetooth\r\n");
                    }
                    else
                    {
                        info[6] += String.Format("{0}\r\n", obj["AdapterType"]);
                    }
                    info[6] += String.Format("[{0}]:  {1}\r\n", LangValue[15], obj["Manufacturer"]); // Manufacturer
                    info[6] += String.Format("[{0}]:  {1}\r\n", LangValue[93], obj["MACAddress"]); // Physical Address
                    info[6] += String.Format("[{0}]:  ", LangValue[58]); // Status
                    switch (Convert.ToByte(obj["NetConnectionStatus"]))
                    {
                        case 0: info[6] += String.Format("{0}\r\n", LangValue[97]); break; // Disconnected
                        case 1: info[6] += String.Format("{0}\r\n", LangValue[98]); break; // Connecting
                        case 2: info[6] += String.Format("{0}\r\n", LangValue[99]); break; // Connected
                        case 3: info[6] += String.Format("{0}\r\n", LangValue[100]); break; // Disconnecting
                        case 4: info[6] += String.Format("{0}\r\n", LangValue[101]); break; // Hardware Not Present
                        case 5: info[6] += String.Format("{0}\r\n", LangValue[102]); break; // Hardware Disabled
                        case 6: info[6] += String.Format("{0}\r\n", LangValue[103]); break; // Hardware Malfunction
                        case 7: info[6] += String.Format("{0}\r\n", LangValue[104]); break; // Media Disconnected
                        case 8: info[6] += String.Format("{0}\r\n", LangValue[105]); break; // Authenticating
                        case 9: info[6] += String.Format("{0}\r\n", LangValue[106]); break; // Authentication Succeeded
                        case 10: info[6] += String.Format("{0}\r\n", LangValue[107]); break; // Authentication Failed
                        case 11: info[6] += String.Format("{0}\r\n", LangValue[108]); break; // Invalid Address
                        case 12: info[6] += String.Format("{0}\r\n", LangValue[109]); break; // Credentials Required
                        case 13: info[6] += String.Format("{0}\r\n", LangValue[59]); break; // Other
                    }
                    info[6] += String.Format("[{0}]:  {1}\r\n\r\n", LangValue[94], obj["ServiceName"]); // Service Name
                }
            }
            txtNetwork.Text = info[6];

            componentName[7] = LangValue[120];
            componentName[8] = LangValue[57];
            componentName[9] = LangValue[161];
        }
         
        private void GetOpSystemDetail()
        {
            int lang = 0;
            string langString = "";
            foreach (ManagementObject obj in new ManagementObjectSearcher("SELECT Caption, Version, BuildNumber, WindowsDirectory, Manufacturer, OSArchitecture, OSLanguage, InstallDate FROM Win32_OperatingSystem").Get())
            {
                detail[0] += String.Format("[{0}]:  {1}\r\n", LangValue[39], Environment.MachineName); // Computer Name
                detail[0] += String.Format("[{0}]:  {1}\r\n", LangValue[40], Environment.UserName); // User
                detail[0] += String.Format("[{0}]:  {1}\r\n", LangValue[41], obj["Caption"]); // OS Name
                detail[0] += String.Format("[{0}]:  {1}\r\n", LangValue[15], obj["Manufacturer"]); // Manufacturer
                detail[0] += String.Format("[{0}]:  {1}\r\n", LangValue[13], obj["WindowsDirectory"]); // Directory
                detail[0] += String.Format("[{0}]:  {1}\r\n", LangValue[14], obj["Version"]); // Version
                detail[0] += String.Format("[{0}]:  {1}\r\n", LangValue[42], obj["BuildNumber"]); // Build
                detail[0] += String.Format("[{0}]:  {1}\r\n", LangValue[43], obj["OSArchitecture"]); // Architecture
                detail[0] += String.Format("[{0}]:  {1}. {2}. {3}. {4}:{5}:{6}\r\n", LangValue[44], obj["InstallDate"].ToString().Substring(0, 4), obj["InstallDate"].ToString().Substring(4, 2), obj["InstallDate"].ToString().Substring(6, 2), obj["InstallDate"].ToString().Substring(8, 2), obj["InstallDate"].ToString().Substring(10, 2), obj["InstallDate"].ToString().Substring(12, 2)); // Install Date
                lang = Convert.ToInt32(obj["OSLanguage"]);
            }

            try
            {
                FileStream fs = new FileStream("Data/LANG/LIST.csv", FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                while (!sr.EndOfStream)
                {
                    string s = sr.ReadLine();
                    string[] p = s.Split(';');

                    if (lang == Convert.ToInt32(p[0]))
                    {
                        langString = p[1];
                    }
                }
                fs.Close();
                sr.Close();
            }
            catch (Exception) { };
            detail[0] += String.Format("[{0}]:  {1}\r\n", LangValue[45], langString); // OS Language
            foreach (ManagementObject obj in new ManagementObjectSearcher("SELECT Workgroup FROM Win32_ComputerSystem").Get())
            {
                detail[0] += String.Format("[{0}]:  {1}\r\n", LangValue[46], obj["Workgroup"]); // Workgroup
            }
            foreach (ManagementObject obj in new ManagementObjectSearcher("SELECT Caption FROM Win32_TimeZone").Get())
            {
                detail[0] += String.Format("[{0}]:  {1}\r\n", LangValue[47], obj["Caption"]); // Time Zone
            }
            this.Invoke(new MethodInvoker(() => linkOpSystem.Enabled = true));
            this.Invoke(new MethodInvoker(() => btnOpSystem.Enabled = true));
        }
        private void GetMotherboardDetail()
        {
            foreach (ManagementObject obj in new ManagementObjectSearcher("SELECT Product, Manufacturer, Version, SerialNumber, HotSwappable FROM Win32_Baseboard").Get())
            {
                detail[1] += String.Format("[{0}]:  {1}\r\n", LangValue[49], obj["Product"]); // Name
                detail[1] += String.Format("[{0}]:  {1}\r\n", LangValue[15], obj["Manufacturer"]); // Manufacturer
                detail[1] += String.Format("[{0}]:  {1}\r\n", LangValue[14], obj["Version"]);
                detail[1] += String.Format("[{0}]:  {1}\r\n", LangValue[50], obj["SerialNumber"]); // Serial Number
                detail[1] += String.Format("[{0}]:  ", LangValue[51]); // Hot Swap
                switch (obj["HotSwappable"].ToString())
                {
                    case "True": detail[1] += String.Format("{0}\r\n", LangValue[52]); break; // Available
                    case "False": detail[1] += String.Format("{0}\r\n", LangValue[53]); break; // Unavailable
                }
            }

            foreach (ManagementObject obj in new ManagementObjectSearcher("SELECT PrimaryBusType FROM Win32_MotherboardDevice").Get())
            {
                detail[1] += String.Format("[{0}]:  {1}\r\n", LangValue[113], obj["PrimaryBusType"]); // Primary Bus Type
            }
            byte[] buscount = new byte[2];
            foreach (ManagementObject obj in new ManagementObjectSearcher("SELECT BusType FROM Win32_Bus").Get())
            {
                switch (Convert.ToInt32(obj["BusType"]))
                {
                    case 5: buscount[0]++; break;
                    case 15: buscount[1]++; break;
                }
            }
            detail[1] += String.Format("[{0}]:  {1}\r\n", LangValue[114], buscount[0]); // Number of PCI Buses
            detail[1] += String.Format("[{0}]:  {1}\r\n", LangValue[115], buscount[1]); // Number of PnP Buses
            detail[1] += String.Format("{0}\tBIOS{1}", shortbreak, shortbreak); // BIOS Information
            foreach (ManagementObject obj in new ManagementObjectSearcher("SELECT Caption, Manufacturer, SMBIOSBIOSVersion, ReleaseDate, CurrentLanguage, TargetOperatingSystem FROM Win32_BIOS").Get())
            {
                detail[1] += String.Format("[{0}]:  {1}\r\n", LangValue[49], obj["Caption"]); // Name
                detail[1] += String.Format("[{0}]:  {1}\r\n", LangValue[15], obj["Manufacturer"]); // Manufacturer
                detail[1] += String.Format("[{0}]:  {1}\r\n", LangValue[14], obj["SMBIOSBIOSVersion"]); // Version
                detail[1] += String.Format("[{0}]:  {1}. {2}. {3}.\r\n", LangValue[54], obj["ReleaseDate"].ToString().Substring(0, 4), obj["ReleaseDate"].ToString().Substring(4, 2), obj["ReleaseDate"].ToString().Substring(6, 2)); // Release Date
                if (Convert.ToString(obj["CurrentLanguage"]) == "")
                {
                    detail[1] += String.Format("[{0}]:  {1}\r\n", LangValue[55], LangValue[37]); // Language
                }
                else
                {
                    detail[1] += String.Format("[{0}]:  {1}\r\n", LangValue[55], obj["CurrentLanguage"].ToString().ToUpper()); // Language
                }
            }

            detail[1] += String.Format("{0}      {1}{2}", shortbreak, LangValue[56], shortbreak); // Sound Devices
            foreach (ManagementObject obj in new ManagementObjectSearcher("SELECT Name, Manufacturer, StatusInfo, SystemName FROM Win32_SoundDevice").Get())
            {
                detail[1] += String.Format("{0}\r\n", obj["Name"]);
                detail[1] += String.Format("    [{0}]:  {1}\r\n", LangValue[15], obj["Manufacturer"]); // Manufacturer
                byte status = Convert.ToByte(obj["StatusInfo"]);
                string statusString = "";
                switch (status)
                {
                    case 1: statusString = String.Format("{0}", LangValue[59]); break; // Other
                    case 2: statusString = String.Format("{0}", LangValue[37]); break; // Unknown
                    case 3: statusString = String.Format("{0}", LangValue[60]); break; // Enabled
                    case 4: statusString = String.Format("{0}", LangValue[61]); break; // Disabled
                    case 5: statusString = String.Format("{0}", LangValue[62]); break; // Not Applicable
                    default:
                        break;
                }
                detail[1] += String.Format("    [{0}]:  {1}\r\n\r\n", LangValue[58], statusString); // Status
            }
            this.Invoke(new MethodInvoker(() => linkMotherboard.Enabled = true));
            this.Invoke(new MethodInvoker(() => btnMotherboard.Enabled = true));
        }
        private void GetProcessorDetail()
        {
            string virtualString = "";
            try
            {
                foreach (ManagementObject obj in new ManagementObjectSearcher("SELECT VirtualizationFirmwareEnabled FROM Win32_Processor").Get())
                {
                    switch (obj["VirtualizationFirmwareEnabled"].ToString())
                    {
                        case "True": virtualString = String.Format("{0}", LangValue[52]); break; // Available
                        case "False": virtualString = String.Format("{0}", LangValue[53]); break; // Unavailable
                    }
                }
            }
            catch (Exception) { virtualString = String.Format("{0}", LangValue[37]); }; // Unknown

            foreach (ManagementObject obj in new ManagementObjectSearcher("SELECT Name, Manufacturer, Caption, SocketDesignation, DataWidth, NumberOfCores, NumberOfLogicalProcessors, CurrentClockSpeed, L2CacheSize, L3CacheSize, ExtClock FROM Win32_Processor").Get())
            {
                detail[2] += String.Format("{0}{1}{2}", linebreak, obj["Name"], linebreak);
                detail[2] += String.Format("[{0}]:  {1}\r\n", LangValue[15], obj["Manufacturer"]); // Manufacturer
                detail[2] += String.Format("[{0}]:  {1}\r\n", LangValue[20], obj["Caption"]); // Stepping
                detail[2] += String.Format("[{0}]:  {1}\r\n", LangValue[19], obj["SocketDesignation"]); // Socket
                detail[2] += String.Format("[{0}]:  {1}\r\n", LangValue[63], virtualString); // Virtualization
                detail[2] += String.Format("[{0}]:  {1} bit\r\n", LangValue[64], obj["DataWidth"]); // Data Width
                detail[2] += String.Format("[{0}]:  {1}\r\n", LangValue[17], obj["NumberOfCores"]); // Cores
                detail[2] += String.Format("[{0}]:  {1}\r\n", LangValue[18], obj["NumberOfLogicalProcessors"]); // Threads
                detail[2] += String.Format("[{0}]:  {1} MHz\r\n", LangValue[65], obj["CurrentClockSpeed"]); // Current Speed
                detail[2] += String.Format("[{0}]:  ~{1} MHz\r\n", LangValue[118], obj["ExtClock"]); // Bus Speed
                try
                {
                    detail[2] += String.Format("[{0}]:  x{1}\r\n", LangValue[119], Convert.ToInt32(obj["CurrentClockSpeed"]) / Convert.ToInt32(obj["ExtClock"])); // Multiplier
                }
                catch (DivideByZeroException) { };
                detail[2] += String.Format("[L2 Cache]:  {0:0.0} MB\r\n", Convert.ToDouble(obj["L2CacheSize"]) / 1024); // L2 Cache
                detail[2] += String.Format("[L3 Cache]:  {0:0.0} MB\r\n", Convert.ToDouble(obj["L3CacheSize"]) / 1024); // L3 Cache
            }
            this.Invoke(new MethodInvoker(() => linkProcessor.Enabled = true));
            this.Invoke(new MethodInvoker(() => btnProcessor.Enabled = true));
        }
        private void GetMemoryDetail()
        {
            foreach (ManagementObject obj in new ManagementObjectSearcher("SELECT TotalPhysicalMemory FROM Win32_ComputerSystem").Get())
            {
                detail[3] = String.Format("[{0}]:  {1:0.00}GB ({2}MB)\r\n", LangValue[21], Convert.ToDouble(obj["TotalPhysicalMemory"]) / 1024 / 1024 / 1024, Convert.ToInt64(obj["TotalPhysicalMemory"]) / 1024 / 1024); // Total RAM
            }
            byte i = 0, memtype = 0;
            foreach (ManagementObject obj in new ManagementObjectSearcher("SELECT Caption, MemoryType FROM Win32_PhysicalMemory").Get())
            {
                i++;
                memtype = Convert.ToByte(obj["MemoryType"]);
            }
            switch (i)
            {
                case 0: i = 1; break;
                default: break;
            }
            detail[3] += String.Format("[{0}]:  {1}\r\n", LangValue[66], i); // Number of Modules
            if (memtype == 0)
            {
                try
                {
                    foreach (ManagementObject obj in new ManagementObjectSearcher("SELECT SMBIOSMemoryType FROM Win32_PhysicalMemory").Get())
                    {
                        memtype = Convert.ToByte(obj["SMBIOSMemoryType"]);
                    }
                }
                catch (Exception) { };
            }
            detail[3] += String.Format("[{0}]:  ", LangValue[23]); // Memory Type
            switch (memtype)
            {
                case 0: detail[3] += String.Format("{0}", LangValue[37]); break; // Unknown
                case 1: detail[3] += String.Format("{0}", LangValue[37]); break; // Unknown
                case 17: detail[3] += String.Format("{0}", LangValue[37]); break; // Unknown
                case 20: detail[3] += "DDR"; break;
                case 21: detail[3] += "DDR2"; break;
                case 22: detail[3] += "DDR3"; break;
                case 24: detail[3] += "DDR3"; break;
                case 26: detail[3] += "DDR4"; break;
                default: detail[3] += String.Format("{0}", LangValue[38]); break; // Undefined
            }
            detail[3] += String.Format("\r\n[{0}]:  ", LangValue[24]); // Channel
            switch (i)
            {
                case 0: detail[3] += String.Format("{0}", LangValue[27]); break; // Single-channel
                case 1: detail[3] += String.Format("{0}", LangValue[27]); break; // Single-channel
                case 2: detail[3] += String.Format("{0}", LangValue[28]); break; // Dual-channel
                case 3: detail[3] += String.Format("{0}", LangValue[29]); break; // Triple-channel
                case 4: detail[3] += String.Format("{0}", LangValue[30]); break; // Quad-channel
                case 6: detail[3] += String.Format("{0}", LangValue[31]); break; // Six-channel
                case 8: detail[3] += String.Format("{0}", LangValue[32]); break; // Eight-channel
            }
            foreach (ManagementObject obj in new ManagementObjectSearcher("SELECT TotalVirtualMemorySize FROM Win32_OperatingSystem").Get())
            {
                detail[3] += String.Format("\r\n[{0}]:  {1:0.00}GB ({2}MB)\r\n", LangValue[67], Convert.ToDouble(obj["TotalVirtualMemorySize"]) / 1024 / 1024, Convert.ToInt64(obj["TotalVirtualMemorySize"]) / 1024); // Total Virtual Memory
            }
            foreach (ManagementObject obj in new ManagementObjectSearcher("SELECT DeviceLocator, Manufacturer, SerialNumber, Capacity, Speed FROM Win32_PhysicalMemory").Get())
            {
                int memspeed = Convert.ToInt32(obj["Speed"]);
                detail[3] += String.Format("{0}      {1}{2}", shortbreak, obj["DeviceLocator"], shortbreak);
                detail[3] += String.Format("[{0}]:  {1}\r\n", LangValue[15], obj["Manufacturer"]); // Manufacturer
                detail[3] += String.Format("[{0}]:  {1}\r\n", LangValue[50], obj["SerialNumber"]); //Serial Number
                detail[3] += String.Format("[{0}]:  {1:0.00}GB ({2}MB)\r\n", LangValue[68], Convert.ToDouble(obj["Capacity"]) / 1024 / 1024 / 1024, Convert.ToInt64(obj["Capacity"]) / 1024 / 1024); // Memory Size
                detail[3] += String.Format("[{0}]:  ", LangValue[22]); // Speed
                switch (memspeed)
                {
                    case 0: String.Format("{0}\r\n", LangValue[37]); break; // Unknown
                    default: detail[3] += String.Format("{0} MHz\r\n", memspeed); break;

                }
            }
            this.Invoke(new MethodInvoker(() => linkMemory.Enabled = true));
            this.Invoke(new MethodInvoker(() => btnMemory.Enabled = true));
        }
        private void GetGraphicsDetail()
        {
            List<string> Resolution = new List<string>();
            List<string> RefreshRate = new List<string>();

            foreach (ManagementObject obj in new ManagementObjectSearcher("SELECT CurrentHorizontalResolution, CurrentVerticalResolution, CurrentRefreshRate FROM Win32_VideoController").Get())
            {
                Resolution.Add(String.Format("{0}x{1}", obj["CurrentHorizontalResolution"], obj["CurrentVerticalResolution"]));
                RefreshRate.Add(String.Format("{0} Hz", obj["CurrentRefreshRate"]));
            }
            byte i = 0;
            foreach (ManagementObject obj in new ManagementObjectSearcher("SELECT Name, MonitorManufacturer FROM Win32_DesktopMonitor").Get())
            {
                detail[4] += String.Format("{0}      {1}{2}", linebreak, obj["Name"], linebreak);
                detail[4] += String.Format("[{0}]:  {1}\r\n", LangValue[15], obj["MonitorManufacturer"]); // Manufacturer

                try
                {
                    switch (Resolution[i])
                    {
                        case "x": break;
                        default: detail[4] += String.Format("[{0}]:  {1}\r\n", LangValue[71], Resolution[i]); break; // Resolution
                    }
                    switch (RefreshRate[i])
                    {
                        case " Hz": break;
                        default: detail[4] += String.Format("[{0}]:  {1}\r\n", LangValue[72], RefreshRate[i]); break; // Refresh Rate
                    }
                }
                catch (Exception) { };
                i++;
            }

            foreach (ManagementObject obj in new ManagementObjectSearcher("SELECT Name, AdapterRAM, VideoArchitecture, AdapterDACType, AdapterCompatibility, DriverVersion, DriverDate, CurrentNumberOfColors, CurrentBitsPerPixel, CurrentHorizontalResolution, CurrentVerticalResolution, InfFilename FROM Win32_VideoController").Get())
            {
                detail[4] += String.Format("{0}      {1}{2}", linebreak, obj["Name"], linebreak);
                detail[4] += String.Format("[{0}]:  {1}\r\n", LangValue[15], obj["AdapterCompatibility"]); // Manufacturer
                detail[4] += String.Format("[{0}]:  ", LangValue[43]); // Architecture
                switch (Convert.ToByte(obj["VideoArchitecture"]))
                {
                    case 1: detail[4] += String.Format("{0}", LangValue[59]); break;
                    case 2: detail[4] += String.Format("{0}", LangValue[37]); break;
                    case 3: detail[4] += String.Format("CGA"); break;
                    case 4: detail[4] += String.Format("EGA"); break;
                    case 5: detail[4] += String.Format("VGA"); break;
                    case 6: detail[4] += String.Format("SVGA"); break;
                    case 7: detail[4] += String.Format("MDA"); break;
                    case 8: detail[4] += String.Format("HGC"); break;
                    case 9: detail[4] += String.Format("MCGA"); break;
                    case 10: detail[4] += String.Format("8514A"); break;
                    case 11: detail[4] += String.Format("XGA"); break;
                    case 12: detail[4] += String.Format("Linear Frame Buffer"); break;
                    case 160: detail[4] += String.Format("PC-98"); break;
                }
                detail[4] += String.Format("\r\n[{0}]:  {1}\r\n", LangValue[148], obj["AdapterDACType"]); // DAC Type
                detail[4] += String.Format("[{0}]:  {1}MB ({2:0.00}GB)\r\n", LangValue[73], Convert.ToInt64(obj["AdapterRAM"]) / 1024 / 1024, Convert.ToDouble(obj["AdapterRAM"]) / 1024 / 1024 / 1024); // Video Memory
                detail[4] += String.Format("[{0}]:  {1} px\r\n", LangValue[149], obj["CurrentHorizontalResolution"]); // Horizontal Resolution
                detail[4] += String.Format("[{0}]:  {1} px\r\n", LangValue[150], obj["CurrentVerticalResolution"]); // Vertical Resolution
                detail[4] += String.Format("[{0}]:  {1}\r\n", LangValue[151], obj["CurrentBitsPerPixel"]); // Bits per Pixel
                detail[4] += String.Format("[{0}]:  {1}\r\n", LangValue[152], obj["CurrentNumberOfColors"]); // Number of colors
                detail[4] += String.Format("[{0}]:  {1}\r\n", LangValue[74], obj["DriverVersion"]); // Driver Version
                detail[4] += String.Format("[{0}]:  {1}. {2}. {3}.\r\n", LangValue[75], obj["DriverDate"].ToString().Substring(0, 4), obj["DriverDate"].ToString().Substring(4, 2), obj["DriverDate"].ToString().Substring(6, 2)); // Driver Date
                detail[4] += String.Format("[{0}]:  {1}\r\n", LangValue[153], obj["InfFilename"]); // Inf filename
            }
            this.Invoke(new MethodInvoker(() => linkGraphics.Enabled = true));
            this.Invoke(new MethodInvoker(() => btnGraphics.Enabled = true));
        }
        private void GetStorageDetail()
        {
            foreach (ManagementObject obj in new ManagementObjectSearcher("SELECT Model, DeviceID, Size, TotalSectors ,FirmwareRevision, SerialNumber, Status FROM Win32_DiskDrive").Get())
            {
                detail[5] += String.Format("{0}      {1}{2}", linebreak, obj["Model"], linebreak);
                detail[5] += String.Format("[{0}]:  {1}\r\n", LangValue[76], obj["DeviceID"]); // ID
                detail[5] += String.Format("[{0}]:  {1:0.0}GB\r\n", LangValue[77], Convert.ToDouble(obj["Size"]) / 1024 / 1024 / 1024); // Size
                detail[5] += String.Format("[{0}]:  {1}\r\n", LangValue[78], Convert.ToInt64(obj["TotalSectors"])); // Number of Sectors
                detail[5] += String.Format("[{0}]:  {1}\r\n", LangValue[79], obj["FirmwareRevision"]); // Firmware
                detail[5] += String.Format("[{0}]:  {1}\r\n", LangValue[50], obj["SerialNumber"]); // Serial Number
                detail[5] += String.Format("[{0}]:  ", LangValue[80]); // Device Type
                if (obj["Model"].ToString().Contains("ATA"))
                {
                    detail[5] += "SATA ";
                }
                else if (obj["Model"].ToString().Contains("IDE"))
                {
                    detail[5] += "IDE ";
                }
                else if (obj["Model"].ToString().Contains("SSD") || obj["Model"].ToString().Contains("Solid State"))
                {
                    detail[5] += "SSD ";
                }
                else
                {
                    detail[5] += String.Format("{0}", LangValue[37]); // Unknown
                }
                detail[5] += String.Format("\r\n[{0}]:  {1}\r\n", LangValue[58], obj["Status"]); // Status
            }
            detail[5] += String.Format("{0}      {1}{2}", shortbreak, LangValue[90], shortbreak); // Partitions
            foreach (ManagementObject obj in new ManagementObjectSearcher("SELECT Name, DriveType ,FileSystem, Size, FreeSpace FROM Win32_LogicalDisk").Get())
            {
                detail[5] += String.Format("      | {0} {1} |\r\n", obj["Name"], LangValue[81]); // Drive
                detail[5] += String.Format("[{0}]:  ", LangValue[82]); // Type
                byte drivetype = Convert.ToByte(obj["DriveType"]);
                switch (drivetype)
                {
                    case 0: detail[5] += String.Format("{0}", LangValue[37]); break; // Unknown
                    case 1: detail[5] += String.Format("{0}", LangValue[83]); break; // No Root Directory
                    case 2: detail[5] += String.Format("{0}", LangValue[84]); break; // Removable Disk
                    case 3: detail[5] += String.Format("{0}", LangValue[85]); break; // Local Disk
                    case 4: detail[5] += String.Format("{0}", LangValue[86]); break; // Network Drive
                    case 5: detail[5] += String.Format("{0}", LangValue[87]); break; // Compact Disc
                    case 6: detail[5] += String.Format("{0}", LangValue[88]); break; // RAM Disk
                }
                detail[5] += String.Format("\r\n[{0}]:  {1}\r\n", LangValue[89], obj["FileSystem"]); // File System
                detail[5] += String.Format("[{0}]:  {1:0.0}GB\r\n", LangValue[77], Convert.ToDouble(obj["Size"]) / 1024 / 1024 / 1024); // Size
                detail[5] += String.Format("[{0}]:  {1:0.0}GB\r\n\r\n", LangValue[91], Convert.ToDouble(obj["FreeSpace"]) / 1024 / 1024 / 1024); // Free Space
            }
            this.Invoke(new MethodInvoker(() => linkStorage.Enabled = true));
            this.Invoke(new MethodInvoker(() => btnStorage.Enabled = true));
        }
        private void GetNetworkDetail()
        {
            try
            {
                // External IPv6
                string external = new WebClient().DownloadString("http://icanhazip.com/");
                if (external.Length < 36)
                {
                    detail[6] += String.Format("[{0}]:  ---\r\n", LangValue[95]);
                }
                else
                {
                    detail[6] += String.Format("[{0}]:  {1}\r\n", LangValue[95], external);
                }
            }
            catch (Exception) { };

            try
            {
                // External IPv4
                string external = new WebClient().DownloadString("http://checkip.dyndns.org/");
                string[] p1 = external.Split(':');
                string[] p2 = p1[1].Split('<');
                detail[6] += String.Format("[{0}]:  {1}\r\n", LangValue[96], p2[0]);
            }
            catch (Exception) { };

            List<NetworkInterface> Interfaces = new List<NetworkInterface>();
            foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (ni.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 || ni.NetworkInterfaceType == NetworkInterfaceType.Ethernet) { Interfaces.Add(ni); };
            }
            foreach (NetworkInterface intf in Interfaces)
            {
                detail[6] += String.Format("{0}      {1}{2}", linebreak, intf.Name, linebreak);
                string macaddress = Convert.ToString(intf.GetPhysicalAddress());
                byte i = 0;
                for (i = 1; i < macaddress.Length; i++)
                {
                    if (i % 3 == 0)
                    {
                        macaddress = macaddress.Insert(i - 1, "-");
                    }
                }
                detail[6] += String.Format("[MAC]:  {0}\r\n", macaddress);
                IPInterfaceProperties properties = intf.GetIPProperties();
                foreach (IPAddressInformation ipinfo in properties.UnicastAddresses)
                {
                    if (ipinfo.Address.AddressFamily.ToString() == "InterNetworkV6")
                    {
                        detail[6] += String.Format("[IPv6]:  {0}\r\n", ipinfo.Address);
                    }
                    else
                    {
                        detail[6] += String.Format("[IPv4]:  {0}\r\n", ipinfo.Address);
                        foreach (UnicastIPAddressInformation uipinfo in properties.UnicastAddresses)
                        {
                            if (uipinfo.IPv4Mask.ToString() != "0.0.0.0")
                            {
                                detail[6] += String.Format("[{0}]:  {1}\r\n", LangValue[34], uipinfo.IPv4Mask); // Subnet Mask
                            }
                        }
                        foreach (GatewayIPAddressInformation gate in intf.GetIPProperties().GatewayAddresses)
                        {
                            detail[6] += String.Format("[{0}]:  {1}\r\n", LangValue[35], gate.Address.ToString()); // Default Gateway
                        }
                        foreach (IPAddress dns in properties.DnsAddresses)
                        {
                            if (dns.AddressFamily.ToString() == "InterNetwork")
                            {
                                detail[6] += String.Format("[{0}]:  {1}\r\n", LangValue[36], dns); // DNS Server
                            }
                        }
                    }
                }
            }
            this.Invoke(new MethodInvoker(() => linkNetwork.Enabled = true));
            this.Invoke(new MethodInvoker(() => btnNetwork.Enabled = true));
        }
        private void GetPeripheralsDetail()
        {
            foreach (ManagementObject obj in new ManagementObjectSearcher("SELECT DeviceClass, DeviceName, ClassGuid, Manufacturer, DriverVersion, InfName FROM Win32_PnPSignedDriver").Get())
            {
                switch (Convert.ToString(obj["DeviceClass"]))
                {
                    case "KEYBOARD":
                        detail[7] += String.Format("{0}\t{1}{2}", linebreak, obj["DeviceName"], linebreak); // Device name
                        detail[7] += String.Format("[{0}]:  {1}\r\n", LangValue[15], obj["Manufacturer"]); // Manufacturer
                        detail[7] += String.Format("[{0}]:  {1}\r\n", LangValue[80], LangValue[121]); // Device type
                        detail[7] += String.Format("[{0}]:  {1}\r\n", LangValue[74], obj["DriverVersion"]); // Driver name
                        detail[7] += String.Format("[GUID]:  {0}\r\n", obj["ClassGuid"]); // GUID
                        detail[7] += String.Format("[{0}]:  {1}\r\n", LangValue[153], obj["InfName"]); // Inf filename
                        break;
                    case "MOUSE":
                        detail[7] += String.Format("{0}\t{1}{2}", linebreak, obj["DeviceName"], linebreak); // Device name
                        detail[7] += String.Format("[{0}]:  {1}\r\n", LangValue[15], obj["Manufacturer"]); // Manufacturer
                        detail[7] += String.Format("[{0}]:  {1}\r\n", LangValue[80], LangValue[122]); // Device type
                        detail[7] += String.Format("[{0}]:  {1}\r\n", LangValue[74], obj["DriverVersion"]); // Driver name
                        detail[7] += String.Format("[GUID]:  {0}\r\n", obj["ClassGuid"]); // GUID
                        detail[7] += String.Format("[{0}]:  {1}\r\n", LangValue[153], obj["InfName"]); // Inf filename
                        break;
                }
            }

            this.Invoke(new MethodInvoker(() => btnPeripherals.Enabled = true));
        }
        private void GetPrintersDetail()
        {
            foreach (ManagementObject obj in new ManagementObjectSearcher("SELECT Caption, HorizontalResolution, VerticalResolution, CurrentPaperType, ExtendedPrinterStatus, DriverName, Default, Network, Local, PortName, PrintProcessor, Queued FROM Win32_Printer").Get())
            {
                detail[8] += String.Format("{0}\t{1}{2}", linebreak, obj["Caption"], linebreak); // Device name
                detail[8] += String.Format("[{0}]:  ", LangValue[58]); // Status
                switch (Convert.ToByte(obj["ExtendedPrinterStatus"]))
                {
                    case 1: detail[8] += String.Format("{0}", LangValue[59]); break; // Other
                    case 2: detail[8] += String.Format("{0}", LangValue[37]); break; // Unknown
                    case 3: detail[8] += String.Format("{0}", LangValue[128]); break; // Idle
                    case 4: detail[8] += String.Format("{0}", LangValue[129]); break; // Printing
                    case 5: detail[8] += String.Format("{0}", LangValue[130]); break; // Warming up
                    case 6: detail[8] += String.Format("{0}", LangValue[131]); ; break; // Stopped printing
                    case 7: detail[8] += String.Format("{0}", LangValue[132]); ; break; // Offline
                    case 8: detail[8] += String.Format("{0}", LangValue[133]); break; // Paused
                    case 9: detail[8] += String.Format("{0}", LangValue[134]); break; // Error
                    case 10: detail[8] += String.Format("{0}", LangValue[135]); break; // Busy
                    case 11: detail[8] += String.Format("{0}", LangValue[53]); break; // Unavailable
                    case 12: detail[8] += String.Format("{0}", LangValue[136]); break; // Waiting
                    case 13: detail[8] += String.Format("{0}", LangValue[137]); break; // Processing
                    case 14: detail[8] += String.Format("{0}", LangValue[138]); break; // Initialization
                    case 15: detail[8] += String.Format("{0}", LangValue[139]); break; // Power save
                    case 16: detail[8] += String.Format("{0}", LangValue[140]); break; // Pending deletion
                    case 17: detail[8] += String.Format("{0}", LangValue[141]); break; // I/O active
                    case 18: detail[8] += String.Format("{0}", LangValue[142]); break; // Manual feed
                }
                detail[8] += String.Format("\r\n");
                detail[8] += String.Format("[{0}]:  {1}\r\n", LangValue[156], obj["DriverName"]); // Driver name
                detail[8] += String.Format("[{0}]:  {1}\r\n", LangValue[159], obj["PrintProcessor"]); // Print processor
                detail[8] += String.Format("[{0}]:  {1}\r\n", LangValue[158], obj["PortName"]); // Port name
                detail[8] += String.Format("[{0}]:  {1}\r\n", LangValue[155], obj["CurrentPaperType"]); // Current paper type
                detail[8] += String.Format("[{0}]:  {1} px\r\n", LangValue[150], obj["VerticalResolution"]); // VRes
                detail[8] += String.Format("[{0}]:  {1} px\r\n", LangValue[149], obj["HorizontalResolution"]); // HRes
                detail[8] += String.Format("[{0}]:  {1}\r\n", LangValue[143], obj["Default"]); // Default
                detail[8] += String.Format("[{0}]:  {1}\r\n", LangValue[147], obj["Local"]); // Local
                detail[8] += String.Format("[{0}]:  {1}\r\n", LangValue[146], obj["Network"]); // Network
                detail[8] += String.Format("[{0}]:  {1}\r\n", LangValue[160], obj["Queued"]); // Queued
            }

            this.Invoke(new MethodInvoker(() => btnPrinters.Enabled = true));
        }
        private void GetBatteryDetail()
        {
            byte i = 0;
            foreach (ManagementObject obj in new ManagementObjectSearcher("SELECT EstimatedChargeRemaining FROM Win32_Battery").Get())
            {
                i++;
            }

            switch (i)
            {
                case 0: break;
                default:

                    foreach (ManagementObject obj in new ManagementObjectSearcher("SELECT Caption, Name, DeviceID, Status FROM Win32_Battery").Get())
                    {
                        detail[9] += String.Format("{0}\t{1}{2}", linebreak, obj["Caption"], linebreak); // Caption
                        detail[9] += String.Format("[{0}]:  {1}\r\n", LangValue[49], obj["Name"]); // Name
                        detail[9] += String.Format("[{0}]:  {1}\r\n", LangValue[76], obj["DeviceID"]); // ID
                        detail[9] += String.Format("[{0}]:  {1}\r\n", LangValue[58], obj["Status"]); // Status
                    }

                    this.Invoke(new MethodInvoker(() => btnBattery.Enabled = true));
                    break;
            }
        }

        private void ProcessorUsage_Progress()
        {
            fclosed = false;
            PerformanceCounter CPUCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            while (!fclosed)
            {
                byte count = Convert.ToByte(CPUCounter.NextValue());
                this.Invoke(new MethodInvoker(() => progCPU.Value = Convert.ToInt32(count)));
                this.Invoke(new MethodInvoker(() => lbl_progCPU.Text = String.Format("{0}% {1}", count, LangValue[162])));
                Thread.Sleep(1000);
            }
        }
        private void RamUsage_Progress()
        {
            fclosed = false;
            double total = 0, free = 0, usage = 0;
            foreach (ManagementObject obj in new ManagementObjectSearcher("SELECT TotalPhysicalMemory FROM Win32_ComputerSystem").Get()) { total = Convert.ToDouble(obj["TotalPhysicalMemory"]) / 1024 / 1024; };
            while (!fclosed)
            {
                foreach (ManagementObject obj in new ManagementObjectSearcher("SELECT FreePhysicalMemory FROM Win32_OperatingSystem").Get())
                {
                    free = Convert.ToDouble(obj["FreePhysicalMemory"]) / 1024;
                    usage = ((total - (Convert.ToDouble(obj["FreePhysicalMemory"]) / 1024)) / total) * 100;
                    this.Invoke(new MethodInvoker(() => progRAM.Value = Convert.ToInt32(usage)));
                    this.Invoke(new MethodInvoker(() => lbl_progRAM.Text = String.Format("{0:0}% {1}", usage, LangValue[163])));
                }
                Thread.Sleep(1000);
            }
        }
        private void SpaceUsed_Progress()
        {
            fclosed = false;
            double sumTotal = 0, sumFree = 0, used = 0;
            List<double> Total = new List<double>();
            List<double> Free = new List<double>();

            while (!fclosed)
            {
                Total.Clear();
                Free.Clear();
                sumTotal = 0;
                sumFree = 0;
                foreach (ManagementObject obj in new ManagementObjectSearcher("SELECT Size, FreeSpace FROM Win32_LogicalDisk").Get())
                {
                    Total.Add(Convert.ToDouble(obj["Size"]) / 1024 / 1024 / 1024);
                    Free.Add(Convert.ToDouble(obj["FreeSpace"]) / 1024 / 1024 / 1024);
                }
                for (int i = 0; i < Total.Count; i++)
                {
                    sumTotal += Total[i];
                    sumFree += Free[i];
                }
                used = Convert.ToDouble(((sumTotal - sumFree) / sumTotal)) * 100;
                this.Invoke(new MethodInvoker(() => lbl_progSpace.Text = String.Format("{0:0.00}% {1}", used, LangValue[164])));
                this.Invoke(new MethodInvoker(() => progSpace.Value = Convert.ToInt32(used)));
                Thread.Sleep(10000);
            }
        }

        private void LinkOpSystem_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DataForm dform = new DataForm();
            dform.LoadDetails(detail[0], componentName[0], LangValue, WindowSizeValue);
            dform.Show();
        }

        private void BtnOpSystem_Click(object sender, EventArgs e)
        {
            DataForm dform = new DataForm();
            dform.LoadDetails(detail[0], componentName[0], LangValue, WindowSizeValue);
            dform.Show();
        }

        private void LinkMotherboard_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DataForm dform = new DataForm();
            dform.LoadDetails(detail[1], componentName[1], LangValue, WindowSizeValue);
            dform.Show();
        }

        private void BtnMotherboard_Click(object sender, EventArgs e)
        {
            DataForm dform = new DataForm();
            dform.LoadDetails(detail[1], componentName[1], LangValue, WindowSizeValue);
            dform.Show();
        }

        private void LinkProcessor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DataForm dform = new DataForm();
            dform.LoadDetails(detail[2], componentName[2], LangValue, WindowSizeValue);
            dform.Show();
        }

        private void BtnProcessor_Click(object sender, EventArgs e)
        {
            DataForm dform = new DataForm();
            dform.LoadDetails(detail[2], componentName[2], LangValue, WindowSizeValue);
            dform.Show();
        }

        private void LinkMemory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DataForm dform = new DataForm();
            dform.LoadDetails(detail[3], componentName[3], LangValue, WindowSizeValue);
            dform.Show();
        }

        private void BtnMemory_Click(object sender, EventArgs e)
        {
            DataForm dform = new DataForm();
            dform.LoadDetails(detail[3], componentName[3], LangValue, WindowSizeValue);
            dform.Show();
        }

        private void LinkGraphics_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DataForm dform = new DataForm();
            dform.LoadDetails(detail[4], componentName[4], LangValue, WindowSizeValue);
            dform.Show();
        }

        private void BtnGraphics_Click(object sender, EventArgs e)
        {
            DataForm dform = new DataForm();
            dform.LoadDetails(detail[4], componentName[4], LangValue, WindowSizeValue);
            dform.Show();
        }

        private void LinkStorage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DataForm dform = new DataForm();
            dform.LoadDetails(detail[5], componentName[5], LangValue, WindowSizeValue);
            dform.Show();
        }

        private void BtnStorage_Click(object sender, EventArgs e)
        {
            DataForm dform = new DataForm();
            dform.LoadDetails(detail[5], componentName[5], LangValue, WindowSizeValue);
            dform.Show();
        }
        private void LinkNetwork_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DataForm dform = new DataForm();
            dform.LoadDetails(detail[6], componentName[6], LangValue, WindowSizeValue);
            dform.Show();
        }

        private void BtnNetwork_Click(object sender, EventArgs e)
        {
            DataForm dform = new DataForm();
            dform.LoadDetails(detail[6], componentName[6], LangValue, WindowSizeValue);
            dform.Show();
        }
        private void BtnPeripherals_Click(object sender, EventArgs e)
        {
            DataForm dform = new DataForm();
            dform.LoadDetails(detail[7], componentName[7], LangValue, WindowSizeValue);
            dform.Show();
        }
        private void BtnPrinters_Click(object sender, EventArgs e)
        {
            DataForm dform = new DataForm();
            dform.LoadDetails(detail[8], componentName[8], LangValue, WindowSizeValue);
            dform.Show();
        }
        private void BtnBattery_Click(object sender, EventArgs e)
        {
            DataForm dform = new DataForm();
            dform.LoadDetails(detail[9], componentName[9], LangValue, WindowSizeValue);
            dform.Show();
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.FileName = Environment.MachineName.ToString() + ".txt";
            save.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (save.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamWriter sw = new StreamWriter(save.FileName);

                    sw.WriteLine("\t--------------------------------");
                    sw.WriteLine("\tWinSIS | Version 1.1.7");
                    sw.WriteLine("\t{0}:  {1}", LangValue[39], Environment.MachineName);
                    sw.WriteLine("\t--------------------------------\r\n");
                    for (int i = 0; i < 10; i++)
                    {
                        sw.WriteLine(componentName[i]);
                        sw.WriteLine("\r\n");
                        sw.WriteLine(info[i]);
                        sw.WriteLine(detail[i]);
                    }
                    sw.Close();
                }
                catch (Exception) { };
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm oform = new SettingsForm();
            oform.LoadTexts(LangValue[55], LangValue[110], LangValue[127]);
            oform.Text = LangValue[117];
            oform.Show();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aform = new AboutForm();
            aform.Text = LangValue[10];
            aform.Show();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            thProgCPU.Abort(); thProgRAM.Abort(); thProgSpace.Abort();
            thDetail[0].Abort(); thDetail[1].Abort(); thDetail[2].Abort();
            thDetail[3].Abort(); thDetail[4].Abort(); thDetail[5].Abort();
            thDetail[6].Abort(); thDetail[7].Abort(); thDetail[8].Abort();
            thDetail[9].Abort();
            fclosed = true;
        }
    }
}
