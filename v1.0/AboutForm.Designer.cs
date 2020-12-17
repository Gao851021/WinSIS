namespace WinSIS
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLicense = new System.Windows.Forms.LinkLabel();
            this.linkGithub = new System.Windows.Forms.LinkLabel();
            this.linkSourceforge = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.linkLicense);
            this.panel1.Controls.Add(this.linkGithub);
            this.panel1.Controls.Add(this.linkSourceforge);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.labelVersion);
            this.panel1.Controls.Add(this.labelName);
            this.panel1.Controls.Add(this.labelCopyright);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 217);
            this.panel1.TabIndex = 0;
            // 
            // linkLicense
            // 
            this.linkLicense.ActiveLinkColor = System.Drawing.Color.LightSkyBlue;
            this.linkLicense.AutoSize = true;
            this.linkLicense.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.linkLicense.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLicense.LinkColor = System.Drawing.Color.DeepSkyBlue;
            this.linkLicense.Location = new System.Drawing.Point(28, 125);
            this.linkLicense.Name = "linkLicense";
            this.linkLicense.Size = new System.Drawing.Size(74, 13);
            this.linkLicense.TabIndex = 17;
            this.linkLicense.TabStop = true;
            this.linkLicense.Text = "Show license";
            this.linkLicense.VisitedLinkColor = System.Drawing.Color.DeepSkyBlue;
            this.linkLicense.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLicense_LinkClicked);
            // 
            // linkGithub
            // 
            this.linkGithub.ActiveLinkColor = System.Drawing.Color.LightSkyBlue;
            this.linkGithub.AutoSize = true;
            this.linkGithub.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.linkGithub.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkGithub.LinkColor = System.Drawing.Color.DeepSkyBlue;
            this.linkGithub.Location = new System.Drawing.Point(13, 174);
            this.linkGithub.Name = "linkGithub";
            this.linkGithub.Size = new System.Drawing.Size(48, 17);
            this.linkGithub.TabIndex = 16;
            this.linkGithub.TabStop = true;
            this.linkGithub.Text = "GitHub";
            this.linkGithub.VisitedLinkColor = System.Drawing.Color.DeepSkyBlue;
            this.linkGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkGithub_LinkClicked);
            // 
            // linkSourceforge
            // 
            this.linkSourceforge.ActiveLinkColor = System.Drawing.Color.LightSkyBlue;
            this.linkSourceforge.AutoSize = true;
            this.linkSourceforge.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.linkSourceforge.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkSourceforge.LinkColor = System.Drawing.Color.DeepSkyBlue;
            this.linkSourceforge.Location = new System.Drawing.Point(13, 191);
            this.linkSourceforge.Name = "linkSourceforge";
            this.linkSourceforge.Size = new System.Drawing.Size(80, 17);
            this.linkSourceforge.TabIndex = 15;
            this.linkSourceforge.TabStop = true;
            this.linkSourceforge.Text = "Sourceforge";
            this.linkSourceforge.VisitedLinkColor = System.Drawing.Color.DeepSkyBlue;
            this.linkSourceforge.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkSourceforge_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(61, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelVersion.ForeColor = System.Drawing.Color.Silver;
            this.labelVersion.Location = new System.Drawing.Point(117, 70);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(72, 17);
            this.labelVersion.TabIndex = 13;
            this.labelVersion.Text = "Version 1.0";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(115, 44);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(71, 25);
            this.labelName.TabIndex = 12;
            this.labelName.Text = "WinSIS";
            // 
            // labelCopyright
            // 
            this.labelCopyright.AutoSize = true;
            this.labelCopyright.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCopyright.ForeColor = System.Drawing.Color.Silver;
            this.labelCopyright.Location = new System.Drawing.Point(28, 104);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(258, 17);
            this.labelCopyright.TabIndex = 11;
            this.labelCopyright.Text = "Copyleft | 2020-2021 | David Patrick Gavras";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(344, 241);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkLicense;
        private System.Windows.Forms.LinkLabel linkGithub;
        private System.Windows.Forms.LinkLabel linkSourceforge;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelCopyright;
    }
}