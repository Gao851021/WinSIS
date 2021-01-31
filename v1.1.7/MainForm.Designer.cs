namespace WinSIS
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Panel1 = new System.Windows.Forms.Panel();
            this.lbl_progRAM = new System.Windows.Forms.Label();
            this.progRAM = new System.Windows.Forms.ProgressBar();
            this.lbl_progCPU = new System.Windows.Forms.Label();
            this.progCPU = new System.Windows.Forms.ProgressBar();
            this.txtMemory = new System.Windows.Forms.RichTextBox();
            this.txtProcessor = new System.Windows.Forms.RichTextBox();
            this.txtMotherboard = new System.Windows.Forms.RichTextBox();
            this.txtOpSystem = new System.Windows.Forms.RichTextBox();
            this.linkMemory = new System.Windows.Forms.LinkLabel();
            this.linkProcessor = new System.Windows.Forms.LinkLabel();
            this.linkMotherboard = new System.Windows.Forms.LinkLabel();
            this.linkOpSystem = new System.Windows.Forms.LinkLabel();
            this.btnMemory = new System.Windows.Forms.Button();
            this.btnProcessor = new System.Windows.Forms.Button();
            this.btnMotherboard = new System.Windows.Forms.Button();
            this.btnOpSystem = new System.Windows.Forms.Button();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.btnPeripherals = new System.Windows.Forms.Button();
            this.btnBattery = new System.Windows.Forms.Button();
            this.lbl_progSpace = new System.Windows.Forms.Label();
            this.progSpace = new System.Windows.Forms.ProgressBar();
            this.txtNetwork = new System.Windows.Forms.RichTextBox();
            this.txtStorage = new System.Windows.Forms.RichTextBox();
            this.txtGraphics = new System.Windows.Forms.RichTextBox();
            this.linkNetwork = new System.Windows.Forms.LinkLabel();
            this.linkStorage = new System.Windows.Forms.LinkLabel();
            this.linkGraphics = new System.Windows.Forms.LinkLabel();
            this.btnPrinters = new System.Windows.Forms.Button();
            this.btnNetwork = new System.Windows.Forms.Button();
            this.btnStorage = new System.Windows.Forms.Button();
            this.btnGraphics = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Panel1.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.lbl_progRAM);
            this.Panel1.Controls.Add(this.progRAM);
            this.Panel1.Controls.Add(this.lbl_progCPU);
            this.Panel1.Controls.Add(this.progCPU);
            this.Panel1.Controls.Add(this.txtMemory);
            this.Panel1.Controls.Add(this.txtProcessor);
            this.Panel1.Controls.Add(this.txtMotherboard);
            this.Panel1.Controls.Add(this.txtOpSystem);
            this.Panel1.Controls.Add(this.linkMemory);
            this.Panel1.Controls.Add(this.linkProcessor);
            this.Panel1.Controls.Add(this.linkMotherboard);
            this.Panel1.Controls.Add(this.linkOpSystem);
            this.Panel1.Controls.Add(this.btnMemory);
            this.Panel1.Controls.Add(this.btnProcessor);
            this.Panel1.Controls.Add(this.btnMotherboard);
            this.Panel1.Controls.Add(this.btnOpSystem);
            this.Panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Panel1.Location = new System.Drawing.Point(12, 37);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(408, 512);
            this.Panel1.TabIndex = 0;
            // 
            // lbl_progRAM
            // 
            this.lbl_progRAM.AutoSize = true;
            this.lbl_progRAM.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_progRAM.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_progRAM.Location = new System.Drawing.Point(175, 393);
            this.lbl_progRAM.Name = "lbl_progRAM";
            this.lbl_progRAM.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_progRAM.Size = new System.Drawing.Size(87, 15);
            this.lbl_progRAM.TabIndex = 31;
            this.lbl_progRAM.Text = "0% RAM Usage";
            this.lbl_progRAM.Visible = false;
            // 
            // progRAM
            // 
            this.progRAM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.progRAM.ForeColor = System.Drawing.Color.LimeGreen;
            this.progRAM.Location = new System.Drawing.Point(123, 393);
            this.progRAM.Name = "progRAM";
            this.progRAM.Size = new System.Drawing.Size(50, 15);
            this.progRAM.Step = 5;
            this.progRAM.TabIndex = 30;
            this.progRAM.Visible = false;
            // 
            // lbl_progCPU
            // 
            this.lbl_progCPU.AutoSize = true;
            this.lbl_progCPU.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_progCPU.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_progCPU.Location = new System.Drawing.Point(175, 268);
            this.lbl_progCPU.Name = "lbl_progCPU";
            this.lbl_progCPU.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_progCPU.Size = new System.Drawing.Size(84, 15);
            this.lbl_progCPU.TabIndex = 29;
            this.lbl_progCPU.Text = "0% CPU Usage";
            this.lbl_progCPU.Visible = false;
            // 
            // progCPU
            // 
            this.progCPU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.progCPU.ForeColor = System.Drawing.Color.LimeGreen;
            this.progCPU.Location = new System.Drawing.Point(123, 268);
            this.progCPU.Name = "progCPU";
            this.progCPU.Size = new System.Drawing.Size(50, 15);
            this.progCPU.Step = 5;
            this.progCPU.TabIndex = 28;
            this.progCPU.Visible = false;
            // 
            // txtMemory
            // 
            this.txtMemory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtMemory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMemory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtMemory.ForeColor = System.Drawing.Color.White;
            this.txtMemory.Location = new System.Drawing.Point(89, 417);
            this.txtMemory.Name = "txtMemory";
            this.txtMemory.ReadOnly = true;
            this.txtMemory.Size = new System.Drawing.Size(304, 78);
            this.txtMemory.TabIndex = 19;
            this.txtMemory.TabStop = false;
            this.txtMemory.Text = "Loading...";
            this.txtMemory.Visible = false;
            // 
            // txtProcessor
            // 
            this.txtProcessor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtProcessor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProcessor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtProcessor.ForeColor = System.Drawing.Color.White;
            this.txtProcessor.Location = new System.Drawing.Point(89, 292);
            this.txtProcessor.Name = "txtProcessor";
            this.txtProcessor.ReadOnly = true;
            this.txtProcessor.Size = new System.Drawing.Size(304, 78);
            this.txtProcessor.TabIndex = 18;
            this.txtProcessor.TabStop = false;
            this.txtProcessor.Text = "Loading...";
            this.txtProcessor.Visible = false;
            // 
            // txtMotherboard
            // 
            this.txtMotherboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtMotherboard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMotherboard.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtMotherboard.ForeColor = System.Drawing.Color.White;
            this.txtMotherboard.Location = new System.Drawing.Point(89, 167);
            this.txtMotherboard.Name = "txtMotherboard";
            this.txtMotherboard.ReadOnly = true;
            this.txtMotherboard.Size = new System.Drawing.Size(304, 78);
            this.txtMotherboard.TabIndex = 17;
            this.txtMotherboard.TabStop = false;
            this.txtMotherboard.Text = "Loading...";
            this.txtMotherboard.Visible = false;
            // 
            // txtOpSystem
            // 
            this.txtOpSystem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtOpSystem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOpSystem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtOpSystem.ForeColor = System.Drawing.Color.White;
            this.txtOpSystem.Location = new System.Drawing.Point(89, 42);
            this.txtOpSystem.Name = "txtOpSystem";
            this.txtOpSystem.ReadOnly = true;
            this.txtOpSystem.Size = new System.Drawing.Size(304, 78);
            this.txtOpSystem.TabIndex = 16;
            this.txtOpSystem.TabStop = false;
            this.txtOpSystem.Text = "Loading...";
            this.txtOpSystem.Visible = false;
            // 
            // linkMemory
            // 
            this.linkMemory.ActiveLinkColor = System.Drawing.Color.LightSkyBlue;
            this.linkMemory.AutoSize = true;
            this.linkMemory.Enabled = false;
            this.linkMemory.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.linkMemory.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkMemory.LinkColor = System.Drawing.Color.DeepSkyBlue;
            this.linkMemory.Location = new System.Drawing.Point(15, 388);
            this.linkMemory.Name = "linkMemory";
            this.linkMemory.Size = new System.Drawing.Size(64, 20);
            this.linkMemory.TabIndex = 4;
            this.linkMemory.TabStop = true;
            this.linkMemory.Text = "Memory";
            this.linkMemory.Visible = false;
            this.linkMemory.VisitedLinkColor = System.Drawing.Color.DeepSkyBlue;
            this.linkMemory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkMemory_LinkClicked);
            // 
            // linkProcessor
            // 
            this.linkProcessor.ActiveLinkColor = System.Drawing.Color.LightSkyBlue;
            this.linkProcessor.AutoSize = true;
            this.linkProcessor.Enabled = false;
            this.linkProcessor.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.linkProcessor.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkProcessor.LinkColor = System.Drawing.Color.DeepSkyBlue;
            this.linkProcessor.Location = new System.Drawing.Point(15, 263);
            this.linkProcessor.Name = "linkProcessor";
            this.linkProcessor.Size = new System.Drawing.Size(72, 20);
            this.linkProcessor.TabIndex = 3;
            this.linkProcessor.TabStop = true;
            this.linkProcessor.Text = "Processor";
            this.linkProcessor.Visible = false;
            this.linkProcessor.VisitedLinkColor = System.Drawing.Color.DeepSkyBlue;
            this.linkProcessor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkProcessor_LinkClicked);
            // 
            // linkMotherboard
            // 
            this.linkMotherboard.ActiveLinkColor = System.Drawing.Color.LightSkyBlue;
            this.linkMotherboard.AutoSize = true;
            this.linkMotherboard.Enabled = false;
            this.linkMotherboard.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.linkMotherboard.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkMotherboard.LinkColor = System.Drawing.Color.DeepSkyBlue;
            this.linkMotherboard.Location = new System.Drawing.Point(15, 138);
            this.linkMotherboard.Name = "linkMotherboard";
            this.linkMotherboard.Size = new System.Drawing.Size(97, 20);
            this.linkMotherboard.TabIndex = 2;
            this.linkMotherboard.TabStop = true;
            this.linkMotherboard.Text = "Motherboard";
            this.linkMotherboard.Visible = false;
            this.linkMotherboard.VisitedLinkColor = System.Drawing.Color.DeepSkyBlue;
            this.linkMotherboard.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkMotherboard_LinkClicked);
            // 
            // linkOpSystem
            // 
            this.linkOpSystem.ActiveLinkColor = System.Drawing.Color.LightSkyBlue;
            this.linkOpSystem.AutoSize = true;
            this.linkOpSystem.Enabled = false;
            this.linkOpSystem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.linkOpSystem.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkOpSystem.LinkColor = System.Drawing.Color.DeepSkyBlue;
            this.linkOpSystem.Location = new System.Drawing.Point(15, 13);
            this.linkOpSystem.Name = "linkOpSystem";
            this.linkOpSystem.Size = new System.Drawing.Size(127, 20);
            this.linkOpSystem.TabIndex = 1;
            this.linkOpSystem.TabStop = true;
            this.linkOpSystem.Text = "Operating System";
            this.linkOpSystem.Visible = false;
            this.linkOpSystem.VisitedLinkColor = System.Drawing.Color.DeepSkyBlue;
            this.linkOpSystem.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkOpSystem_LinkClicked);
            // 
            // btnMemory
            // 
            this.btnMemory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnMemory.Enabled = false;
            this.btnMemory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMemory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnMemory.Image = ((System.Drawing.Image)(resources.GetObject("btnMemory.Image")));
            this.btnMemory.Location = new System.Drawing.Point(19, 417);
            this.btnMemory.Name = "btnMemory";
            this.btnMemory.Size = new System.Drawing.Size(64, 64);
            this.btnMemory.TabIndex = 0;
            this.btnMemory.TabStop = false;
            this.btnMemory.UseVisualStyleBackColor = false;
            this.btnMemory.Visible = false;
            this.btnMemory.Click += new System.EventHandler(this.BtnMemory_Click);
            // 
            // btnProcessor
            // 
            this.btnProcessor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnProcessor.Enabled = false;
            this.btnProcessor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcessor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnProcessor.Image = ((System.Drawing.Image)(resources.GetObject("btnProcessor.Image")));
            this.btnProcessor.Location = new System.Drawing.Point(19, 292);
            this.btnProcessor.Name = "btnProcessor";
            this.btnProcessor.Size = new System.Drawing.Size(64, 64);
            this.btnProcessor.TabIndex = 0;
            this.btnProcessor.TabStop = false;
            this.btnProcessor.UseVisualStyleBackColor = false;
            this.btnProcessor.Visible = false;
            this.btnProcessor.Click += new System.EventHandler(this.BtnProcessor_Click);
            // 
            // btnMotherboard
            // 
            this.btnMotherboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnMotherboard.Enabled = false;
            this.btnMotherboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMotherboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnMotherboard.Image = ((System.Drawing.Image)(resources.GetObject("btnMotherboard.Image")));
            this.btnMotherboard.Location = new System.Drawing.Point(19, 167);
            this.btnMotherboard.Name = "btnMotherboard";
            this.btnMotherboard.Size = new System.Drawing.Size(64, 64);
            this.btnMotherboard.TabIndex = 0;
            this.btnMotherboard.TabStop = false;
            this.btnMotherboard.UseVisualStyleBackColor = false;
            this.btnMotherboard.Visible = false;
            this.btnMotherboard.Click += new System.EventHandler(this.BtnMotherboard_Click);
            // 
            // btnOpSystem
            // 
            this.btnOpSystem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnOpSystem.Enabled = false;
            this.btnOpSystem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpSystem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnOpSystem.Image = ((System.Drawing.Image)(resources.GetObject("btnOpSystem.Image")));
            this.btnOpSystem.Location = new System.Drawing.Point(19, 42);
            this.btnOpSystem.Name = "btnOpSystem";
            this.btnOpSystem.Size = new System.Drawing.Size(64, 64);
            this.btnOpSystem.TabIndex = 0;
            this.btnOpSystem.TabStop = false;
            this.btnOpSystem.UseVisualStyleBackColor = false;
            this.btnOpSystem.Visible = false;
            this.btnOpSystem.Click += new System.EventHandler(this.BtnOpSystem_Click);
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel2.Controls.Add(this.btnPeripherals);
            this.Panel2.Controls.Add(this.btnBattery);
            this.Panel2.Controls.Add(this.lbl_progSpace);
            this.Panel2.Controls.Add(this.progSpace);
            this.Panel2.Controls.Add(this.txtNetwork);
            this.Panel2.Controls.Add(this.txtStorage);
            this.Panel2.Controls.Add(this.txtGraphics);
            this.Panel2.Controls.Add(this.linkNetwork);
            this.Panel2.Controls.Add(this.linkStorage);
            this.Panel2.Controls.Add(this.linkGraphics);
            this.Panel2.Controls.Add(this.btnPrinters);
            this.Panel2.Controls.Add(this.btnNetwork);
            this.Panel2.Controls.Add(this.btnStorage);
            this.Panel2.Controls.Add(this.btnGraphics);
            this.Panel2.Location = new System.Drawing.Point(436, 37);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(408, 512);
            this.Panel2.TabIndex = 1;
            // 
            // btnPeripherals
            // 
            this.btnPeripherals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnPeripherals.Enabled = false;
            this.btnPeripherals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPeripherals.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPeripherals.ForeColor = System.Drawing.Color.White;
            this.btnPeripherals.Image = ((System.Drawing.Image)(resources.GetObject("btnPeripherals.Image")));
            this.btnPeripherals.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPeripherals.Location = new System.Drawing.Point(19, 415);
            this.btnPeripherals.Name = "btnPeripherals";
            this.btnPeripherals.Size = new System.Drawing.Size(100, 80);
            this.btnPeripherals.TabIndex = 32;
            this.btnPeripherals.TabStop = false;
            this.btnPeripherals.Text = "Peripherals";
            this.btnPeripherals.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPeripherals.UseVisualStyleBackColor = false;
            this.btnPeripherals.Visible = false;
            this.btnPeripherals.Click += new System.EventHandler(this.BtnPeripherals_Click);
            // 
            // btnBattery
            // 
            this.btnBattery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnBattery.Enabled = false;
            this.btnBattery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBattery.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBattery.ForeColor = System.Drawing.Color.White;
            this.btnBattery.Image = ((System.Drawing.Image)(resources.GetObject("btnBattery.Image")));
            this.btnBattery.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBattery.Location = new System.Drawing.Point(229, 415);
            this.btnBattery.Name = "btnBattery";
            this.btnBattery.Size = new System.Drawing.Size(100, 80);
            this.btnBattery.TabIndex = 31;
            this.btnBattery.TabStop = false;
            this.btnBattery.Text = "Battery";
            this.btnBattery.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBattery.UseVisualStyleBackColor = false;
            this.btnBattery.Visible = false;
            this.btnBattery.Click += new System.EventHandler(this.BtnBattery_Click);
            // 
            // lbl_progSpace
            // 
            this.lbl_progSpace.AutoSize = true;
            this.lbl_progSpace.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_progSpace.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_progSpace.Location = new System.Drawing.Point(175, 143);
            this.lbl_progSpace.Name = "lbl_progSpace";
            this.lbl_progSpace.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_progSpace.Size = new System.Drawing.Size(85, 15);
            this.lbl_progSpace.TabIndex = 29;
            this.lbl_progSpace.Text = "0% Used space";
            this.lbl_progSpace.Visible = false;
            // 
            // progSpace
            // 
            this.progSpace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.progSpace.ForeColor = System.Drawing.Color.LimeGreen;
            this.progSpace.Location = new System.Drawing.Point(123, 143);
            this.progSpace.Name = "progSpace";
            this.progSpace.Size = new System.Drawing.Size(50, 15);
            this.progSpace.TabIndex = 28;
            this.progSpace.Visible = false;
            // 
            // txtNetwork
            // 
            this.txtNetwork.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtNetwork.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNetwork.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNetwork.ForeColor = System.Drawing.Color.White;
            this.txtNetwork.Location = new System.Drawing.Point(89, 292);
            this.txtNetwork.Name = "txtNetwork";
            this.txtNetwork.ReadOnly = true;
            this.txtNetwork.Size = new System.Drawing.Size(304, 110);
            this.txtNetwork.TabIndex = 25;
            this.txtNetwork.TabStop = false;
            this.txtNetwork.Text = "Loading...";
            this.txtNetwork.Visible = false;
            // 
            // txtStorage
            // 
            this.txtStorage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtStorage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStorage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtStorage.ForeColor = System.Drawing.Color.White;
            this.txtStorage.Location = new System.Drawing.Point(89, 167);
            this.txtStorage.Name = "txtStorage";
            this.txtStorage.ReadOnly = true;
            this.txtStorage.Size = new System.Drawing.Size(304, 78);
            this.txtStorage.TabIndex = 23;
            this.txtStorage.TabStop = false;
            this.txtStorage.Text = "Loading...";
            this.txtStorage.Visible = false;
            // 
            // txtGraphics
            // 
            this.txtGraphics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtGraphics.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGraphics.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtGraphics.ForeColor = System.Drawing.Color.White;
            this.txtGraphics.Location = new System.Drawing.Point(89, 42);
            this.txtGraphics.Name = "txtGraphics";
            this.txtGraphics.ReadOnly = true;
            this.txtGraphics.Size = new System.Drawing.Size(304, 78);
            this.txtGraphics.TabIndex = 22;
            this.txtGraphics.TabStop = false;
            this.txtGraphics.Text = "Loading...";
            this.txtGraphics.Visible = false;
            // 
            // linkNetwork
            // 
            this.linkNetwork.ActiveLinkColor = System.Drawing.Color.LightSkyBlue;
            this.linkNetwork.AutoSize = true;
            this.linkNetwork.Enabled = false;
            this.linkNetwork.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.linkNetwork.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkNetwork.LinkColor = System.Drawing.Color.DeepSkyBlue;
            this.linkNetwork.Location = new System.Drawing.Point(15, 263);
            this.linkNetwork.Name = "linkNetwork";
            this.linkNetwork.Size = new System.Drawing.Size(65, 20);
            this.linkNetwork.TabIndex = 8;
            this.linkNetwork.TabStop = true;
            this.linkNetwork.Text = "Network";
            this.linkNetwork.Visible = false;
            this.linkNetwork.VisitedLinkColor = System.Drawing.Color.DeepSkyBlue;
            this.linkNetwork.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkNetwork_LinkClicked);
            // 
            // linkStorage
            // 
            this.linkStorage.ActiveLinkColor = System.Drawing.Color.LightSkyBlue;
            this.linkStorage.AutoSize = true;
            this.linkStorage.Enabled = false;
            this.linkStorage.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.linkStorage.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkStorage.LinkColor = System.Drawing.Color.DeepSkyBlue;
            this.linkStorage.Location = new System.Drawing.Point(15, 138);
            this.linkStorage.Name = "linkStorage";
            this.linkStorage.Size = new System.Drawing.Size(61, 20);
            this.linkStorage.TabIndex = 6;
            this.linkStorage.TabStop = true;
            this.linkStorage.Text = "Storage";
            this.linkStorage.Visible = false;
            this.linkStorage.VisitedLinkColor = System.Drawing.Color.DeepSkyBlue;
            this.linkStorage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkStorage_LinkClicked);
            // 
            // linkGraphics
            // 
            this.linkGraphics.ActiveLinkColor = System.Drawing.Color.LightSkyBlue;
            this.linkGraphics.AutoSize = true;
            this.linkGraphics.Enabled = false;
            this.linkGraphics.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.linkGraphics.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkGraphics.LinkColor = System.Drawing.Color.DeepSkyBlue;
            this.linkGraphics.Location = new System.Drawing.Point(15, 13);
            this.linkGraphics.Name = "linkGraphics";
            this.linkGraphics.Size = new System.Drawing.Size(66, 20);
            this.linkGraphics.TabIndex = 5;
            this.linkGraphics.TabStop = true;
            this.linkGraphics.Text = "Graphics";
            this.linkGraphics.Visible = false;
            this.linkGraphics.VisitedLinkColor = System.Drawing.Color.DeepSkyBlue;
            this.linkGraphics.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkGraphics_LinkClicked);
            // 
            // btnPrinters
            // 
            this.btnPrinters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnPrinters.Enabled = false;
            this.btnPrinters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrinters.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrinters.ForeColor = System.Drawing.Color.White;
            this.btnPrinters.Image = ((System.Drawing.Image)(resources.GetObject("btnPrinters.Image")));
            this.btnPrinters.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPrinters.Location = new System.Drawing.Point(123, 415);
            this.btnPrinters.Name = "btnPrinters";
            this.btnPrinters.Size = new System.Drawing.Size(100, 80);
            this.btnPrinters.TabIndex = 7;
            this.btnPrinters.TabStop = false;
            this.btnPrinters.Text = "Printers";
            this.btnPrinters.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPrinters.UseVisualStyleBackColor = false;
            this.btnPrinters.Visible = false;
            this.btnPrinters.Click += new System.EventHandler(this.BtnPrinters_Click);
            // 
            // btnNetwork
            // 
            this.btnNetwork.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnNetwork.Enabled = false;
            this.btnNetwork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNetwork.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnNetwork.Image = ((System.Drawing.Image)(resources.GetObject("btnNetwork.Image")));
            this.btnNetwork.Location = new System.Drawing.Point(19, 292);
            this.btnNetwork.Name = "btnNetwork";
            this.btnNetwork.Size = new System.Drawing.Size(64, 64);
            this.btnNetwork.TabIndex = 6;
            this.btnNetwork.TabStop = false;
            this.btnNetwork.UseVisualStyleBackColor = false;
            this.btnNetwork.Visible = false;
            this.btnNetwork.Click += new System.EventHandler(this.BtnNetwork_Click);
            // 
            // btnStorage
            // 
            this.btnStorage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnStorage.Enabled = false;
            this.btnStorage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStorage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnStorage.Image = ((System.Drawing.Image)(resources.GetObject("btnStorage.Image")));
            this.btnStorage.Location = new System.Drawing.Point(19, 167);
            this.btnStorage.Name = "btnStorage";
            this.btnStorage.Size = new System.Drawing.Size(64, 64);
            this.btnStorage.TabIndex = 5;
            this.btnStorage.TabStop = false;
            this.btnStorage.UseVisualStyleBackColor = false;
            this.btnStorage.Visible = false;
            this.btnStorage.Click += new System.EventHandler(this.BtnStorage_Click);
            // 
            // btnGraphics
            // 
            this.btnGraphics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnGraphics.Enabled = false;
            this.btnGraphics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGraphics.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnGraphics.Image = ((System.Drawing.Image)(resources.GetObject("btnGraphics.Image")));
            this.btnGraphics.Location = new System.Drawing.Point(19, 42);
            this.btnGraphics.Name = "btnGraphics";
            this.btnGraphics.Size = new System.Drawing.Size(64, 64);
            this.btnGraphics.TabIndex = 4;
            this.btnGraphics.TabStop = false;
            this.btnGraphics.UseVisualStyleBackColor = false;
            this.btnGraphics.Visible = false;
            this.btnGraphics.Click += new System.EventHandler(this.BtnGraphics_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.White;
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(856, 25);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reloadToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.viewToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // reloadToolStripMenuItem
            // 
            this.reloadToolStripMenuItem.Name = "reloadToolStripMenuItem";
            this.reloadToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.reloadToolStripMenuItem.Text = "Reload";
            this.reloadToolStripMenuItem.Click += new System.EventHandler(this.ReloadToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.SettingsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(55, 21);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(856, 561);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Panel Panel2;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.Button btnOpSystem;
        private System.Windows.Forms.Button btnMemory;
        private System.Windows.Forms.Button btnProcessor;
        private System.Windows.Forms.Button btnMotherboard;
        private System.Windows.Forms.Button btnPrinters;
        private System.Windows.Forms.Button btnNetwork;
        private System.Windows.Forms.Button btnStorage;
        private System.Windows.Forms.Button btnGraphics;
        private System.Windows.Forms.LinkLabel linkProcessor;
        private System.Windows.Forms.LinkLabel linkMotherboard;
        private System.Windows.Forms.LinkLabel linkOpSystem;
        private System.Windows.Forms.LinkLabel linkMemory;
        private System.Windows.Forms.LinkLabel linkNetwork;
        private System.Windows.Forms.LinkLabel linkStorage;
        private System.Windows.Forms.LinkLabel linkGraphics;
        private System.Windows.Forms.RichTextBox txtMemory;
        private System.Windows.Forms.RichTextBox txtProcessor;
        private System.Windows.Forms.RichTextBox txtMotherboard;
        private System.Windows.Forms.RichTextBox txtOpSystem;
        private System.Windows.Forms.RichTextBox txtNetwork;
        private System.Windows.Forms.RichTextBox txtStorage;
        private System.Windows.Forms.RichTextBox txtGraphics;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lbl_progRAM;
        private System.Windows.Forms.ProgressBar progRAM;
        private System.Windows.Forms.Label lbl_progCPU;
        private System.Windows.Forms.ProgressBar progCPU;
        private System.Windows.Forms.Label lbl_progSpace;
        private System.Windows.Forms.ProgressBar progSpace;
        private System.Windows.Forms.Button btnBattery;
        private System.Windows.Forms.Button btnPeripherals;
    }
}

