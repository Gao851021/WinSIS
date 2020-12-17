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
            this.txtNetwork = new System.Windows.Forms.RichTextBox();
            this.txtPeripherals = new System.Windows.Forms.RichTextBox();
            this.txtStorage = new System.Windows.Forms.RichTextBox();
            this.txtGraphics = new System.Windows.Forms.RichTextBox();
            this.linkNetwork = new System.Windows.Forms.LinkLabel();
            this.linkPeripherals = new System.Windows.Forms.LinkLabel();
            this.linkStorage = new System.Windows.Forms.LinkLabel();
            this.linkGraphics = new System.Windows.Forms.LinkLabel();
            this.btnPeripherals = new System.Windows.Forms.Button();
            this.btnNetwork = new System.Windows.Forms.Button();
            this.btnStorage = new System.Windows.Forms.Button();
            this.btnGraphics = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Panel1.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            // txtMemory
            // 
            this.txtMemory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
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
            // 
            // txtProcessor
            // 
            this.txtProcessor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
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
            // 
            // txtMotherboard
            // 
            this.txtMotherboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
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
            // 
            // txtOpSystem
            // 
            this.txtOpSystem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
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
            this.linkOpSystem.VisitedLinkColor = System.Drawing.Color.DeepSkyBlue;
            this.linkOpSystem.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkOpSystem_LinkClicked);
            // 
            // btnMemory
            // 
            this.btnMemory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnMemory.Enabled = false;
            this.btnMemory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMemory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btnMemory.Image = ((System.Drawing.Image)(resources.GetObject("btnMemory.Image")));
            this.btnMemory.Location = new System.Drawing.Point(19, 417);
            this.btnMemory.Name = "btnMemory";
            this.btnMemory.Size = new System.Drawing.Size(64, 64);
            this.btnMemory.TabIndex = 0;
            this.btnMemory.TabStop = false;
            this.btnMemory.UseVisualStyleBackColor = false;
            this.btnMemory.Click += new System.EventHandler(this.BtnMemory_Click);
            // 
            // btnProcessor
            // 
            this.btnProcessor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnProcessor.Enabled = false;
            this.btnProcessor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcessor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btnProcessor.Image = ((System.Drawing.Image)(resources.GetObject("btnProcessor.Image")));
            this.btnProcessor.Location = new System.Drawing.Point(19, 292);
            this.btnProcessor.Name = "btnProcessor";
            this.btnProcessor.Size = new System.Drawing.Size(64, 64);
            this.btnProcessor.TabIndex = 0;
            this.btnProcessor.TabStop = false;
            this.btnProcessor.UseVisualStyleBackColor = false;
            this.btnProcessor.Click += new System.EventHandler(this.BtnProcessor_Click);
            // 
            // btnMotherboard
            // 
            this.btnMotherboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnMotherboard.Enabled = false;
            this.btnMotherboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMotherboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btnMotherboard.Image = ((System.Drawing.Image)(resources.GetObject("btnMotherboard.Image")));
            this.btnMotherboard.Location = new System.Drawing.Point(19, 167);
            this.btnMotherboard.Name = "btnMotherboard";
            this.btnMotherboard.Size = new System.Drawing.Size(64, 64);
            this.btnMotherboard.TabIndex = 0;
            this.btnMotherboard.TabStop = false;
            this.btnMotherboard.UseVisualStyleBackColor = false;
            this.btnMotherboard.Click += new System.EventHandler(this.BtnMotherboard_Click);
            // 
            // btnOpSystem
            // 
            this.btnOpSystem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnOpSystem.Enabled = false;
            this.btnOpSystem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpSystem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btnOpSystem.Image = ((System.Drawing.Image)(resources.GetObject("btnOpSystem.Image")));
            this.btnOpSystem.Location = new System.Drawing.Point(19, 42);
            this.btnOpSystem.Name = "btnOpSystem";
            this.btnOpSystem.Size = new System.Drawing.Size(64, 64);
            this.btnOpSystem.TabIndex = 0;
            this.btnOpSystem.TabStop = false;
            this.btnOpSystem.UseVisualStyleBackColor = false;
            this.btnOpSystem.Click += new System.EventHandler(this.BtnOpSystem_Click);
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel2.Controls.Add(this.txtNetwork);
            this.Panel2.Controls.Add(this.txtPeripherals);
            this.Panel2.Controls.Add(this.txtStorage);
            this.Panel2.Controls.Add(this.txtGraphics);
            this.Panel2.Controls.Add(this.linkNetwork);
            this.Panel2.Controls.Add(this.linkPeripherals);
            this.Panel2.Controls.Add(this.linkStorage);
            this.Panel2.Controls.Add(this.linkGraphics);
            this.Panel2.Controls.Add(this.btnPeripherals);
            this.Panel2.Controls.Add(this.btnNetwork);
            this.Panel2.Controls.Add(this.btnStorage);
            this.Panel2.Controls.Add(this.btnGraphics);
            this.Panel2.Location = new System.Drawing.Point(436, 37);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(408, 512);
            this.Panel2.TabIndex = 1;
            // 
            // txtNetwork
            // 
            this.txtNetwork.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.txtNetwork.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNetwork.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNetwork.ForeColor = System.Drawing.Color.White;
            this.txtNetwork.Location = new System.Drawing.Point(89, 417);
            this.txtNetwork.Name = "txtNetwork";
            this.txtNetwork.ReadOnly = true;
            this.txtNetwork.Size = new System.Drawing.Size(304, 78);
            this.txtNetwork.TabIndex = 25;
            this.txtNetwork.TabStop = false;
            this.txtNetwork.Text = "Loading...";
            // 
            // txtPeripherals
            // 
            this.txtPeripherals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.txtPeripherals.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPeripherals.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPeripherals.ForeColor = System.Drawing.Color.White;
            this.txtPeripherals.Location = new System.Drawing.Point(89, 292);
            this.txtPeripherals.Name = "txtPeripherals";
            this.txtPeripherals.ReadOnly = true;
            this.txtPeripherals.Size = new System.Drawing.Size(304, 78);
            this.txtPeripherals.TabIndex = 24;
            this.txtPeripherals.TabStop = false;
            this.txtPeripherals.Text = "Loading...";
            // 
            // txtStorage
            // 
            this.txtStorage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
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
            // 
            // txtGraphics
            // 
            this.txtGraphics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
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
            // 
            // linkNetwork
            // 
            this.linkNetwork.ActiveLinkColor = System.Drawing.Color.LightSkyBlue;
            this.linkNetwork.AutoSize = true;
            this.linkNetwork.Enabled = false;
            this.linkNetwork.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.linkNetwork.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkNetwork.LinkColor = System.Drawing.Color.DeepSkyBlue;
            this.linkNetwork.Location = new System.Drawing.Point(15, 388);
            this.linkNetwork.Name = "linkNetwork";
            this.linkNetwork.Size = new System.Drawing.Size(65, 20);
            this.linkNetwork.TabIndex = 8;
            this.linkNetwork.TabStop = true;
            this.linkNetwork.Text = "Network";
            this.linkNetwork.VisitedLinkColor = System.Drawing.Color.DeepSkyBlue;
            this.linkNetwork.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkNetwork_LinkClicked);
            // 
            // linkPeripherals
            // 
            this.linkPeripherals.ActiveLinkColor = System.Drawing.Color.LightSkyBlue;
            this.linkPeripherals.AutoSize = true;
            this.linkPeripherals.Enabled = false;
            this.linkPeripherals.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.linkPeripherals.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkPeripherals.LinkColor = System.Drawing.Color.DeepSkyBlue;
            this.linkPeripherals.Location = new System.Drawing.Point(15, 263);
            this.linkPeripherals.Name = "linkPeripherals";
            this.linkPeripherals.Size = new System.Drawing.Size(81, 20);
            this.linkPeripherals.TabIndex = 7;
            this.linkPeripherals.TabStop = true;
            this.linkPeripherals.Text = "Peripherals";
            this.linkPeripherals.VisitedLinkColor = System.Drawing.Color.DeepSkyBlue;
            this.linkPeripherals.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkPeripherals_LinkClicked);
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
            this.linkGraphics.VisitedLinkColor = System.Drawing.Color.DeepSkyBlue;
            this.linkGraphics.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkGraphics_LinkClicked);
            // 
            // btnPeripherals
            // 
            this.btnPeripherals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnPeripherals.Enabled = false;
            this.btnPeripherals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPeripherals.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btnPeripherals.Image = ((System.Drawing.Image)(resources.GetObject("btnPeripherals.Image")));
            this.btnPeripherals.Location = new System.Drawing.Point(19, 292);
            this.btnPeripherals.Name = "btnPeripherals";
            this.btnPeripherals.Size = new System.Drawing.Size(64, 64);
            this.btnPeripherals.TabIndex = 7;
            this.btnPeripherals.TabStop = false;
            this.btnPeripherals.UseVisualStyleBackColor = false;
            this.btnPeripherals.Click += new System.EventHandler(this.BtnPeripherals_Click);
            // 
            // btnNetwork
            // 
            this.btnNetwork.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnNetwork.Enabled = false;
            this.btnNetwork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNetwork.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btnNetwork.Image = ((System.Drawing.Image)(resources.GetObject("btnNetwork.Image")));
            this.btnNetwork.Location = new System.Drawing.Point(19, 417);
            this.btnNetwork.Name = "btnNetwork";
            this.btnNetwork.Size = new System.Drawing.Size(64, 64);
            this.btnNetwork.TabIndex = 6;
            this.btnNetwork.TabStop = false;
            this.btnNetwork.UseVisualStyleBackColor = false;
            this.btnNetwork.Click += new System.EventHandler(this.BtnNetwork_Click);
            // 
            // btnStorage
            // 
            this.btnStorage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnStorage.Enabled = false;
            this.btnStorage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStorage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btnStorage.Image = ((System.Drawing.Image)(resources.GetObject("btnStorage.Image")));
            this.btnStorage.Location = new System.Drawing.Point(19, 167);
            this.btnStorage.Name = "btnStorage";
            this.btnStorage.Size = new System.Drawing.Size(64, 64);
            this.btnStorage.TabIndex = 5;
            this.btnStorage.TabStop = false;
            this.btnStorage.UseVisualStyleBackColor = false;
            this.btnStorage.Click += new System.EventHandler(this.BtnStorage_Click);
            // 
            // btnGraphics
            // 
            this.btnGraphics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnGraphics.Enabled = false;
            this.btnGraphics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGraphics.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btnGraphics.Image = ((System.Drawing.Image)(resources.GetObject("btnGraphics.Image")));
            this.btnGraphics.Location = new System.Drawing.Point(19, 42);
            this.btnGraphics.Name = "btnGraphics";
            this.btnGraphics.Size = new System.Drawing.Size(64, 64);
            this.btnGraphics.TabIndex = 4;
            this.btnGraphics.TabStop = false;
            this.btnGraphics.UseVisualStyleBackColor = false;
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
            this.optionsToolStripMenuItem});
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
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.OptionsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(55, 21);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
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
        private System.Windows.Forms.Button btnPeripherals;
        private System.Windows.Forms.Button btnNetwork;
        private System.Windows.Forms.Button btnStorage;
        private System.Windows.Forms.Button btnGraphics;
        private System.Windows.Forms.LinkLabel linkProcessor;
        private System.Windows.Forms.LinkLabel linkMotherboard;
        private System.Windows.Forms.LinkLabel linkOpSystem;
        private System.Windows.Forms.LinkLabel linkMemory;
        private System.Windows.Forms.LinkLabel linkNetwork;
        private System.Windows.Forms.LinkLabel linkPeripherals;
        private System.Windows.Forms.LinkLabel linkStorage;
        private System.Windows.Forms.LinkLabel linkGraphics;
        private System.Windows.Forms.RichTextBox txtMemory;
        private System.Windows.Forms.RichTextBox txtProcessor;
        private System.Windows.Forms.RichTextBox txtMotherboard;
        private System.Windows.Forms.RichTextBox txtOpSystem;
        private System.Windows.Forms.RichTextBox txtNetwork;
        private System.Windows.Forms.RichTextBox txtPeripherals;
        private System.Windows.Forms.RichTextBox txtStorage;
        private System.Windows.Forms.RichTextBox txtGraphics;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

