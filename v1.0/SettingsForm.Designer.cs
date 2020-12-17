namespace WinSIS
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelWindowSize = new System.Windows.Forms.Label();
            this.labelLanguage = new System.Windows.Forms.Label();
            this.cboxWindowSize = new System.Windows.Forms.ComboBox();
            this.cboxLanguage = new System.Windows.Forms.ComboBox();
            this.btnSettings = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelWindowSize);
            this.panel1.Controls.Add(this.labelLanguage);
            this.panel1.Controls.Add(this.cboxWindowSize);
            this.panel1.Controls.Add(this.cboxLanguage);
            this.panel1.Controls.Add(this.btnSettings);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 217);
            this.panel1.TabIndex = 0;
            // 
            // labelWindowSize
            // 
            this.labelWindowSize.AutoSize = true;
            this.labelWindowSize.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWindowSize.ForeColor = System.Drawing.Color.White;
            this.labelWindowSize.Location = new System.Drawing.Point(97, 84);
            this.labelWindowSize.Name = "labelWindowSize";
            this.labelWindowSize.Size = new System.Drawing.Size(81, 17);
            this.labelWindowSize.TabIndex = 4;
            this.labelWindowSize.Text = "Window size";
            // 
            // labelLanguage
            // 
            this.labelLanguage.AutoSize = true;
            this.labelLanguage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLanguage.ForeColor = System.Drawing.Color.White;
            this.labelLanguage.Location = new System.Drawing.Point(97, 24);
            this.labelLanguage.Name = "labelLanguage";
            this.labelLanguage.Size = new System.Drawing.Size(65, 17);
            this.labelLanguage.TabIndex = 3;
            this.labelLanguage.Text = "Language";
            // 
            // cboxWindowSize
            // 
            this.cboxWindowSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.cboxWindowSize.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cboxWindowSize.ForeColor = System.Drawing.Color.White;
            this.cboxWindowSize.FormattingEnabled = true;
            this.cboxWindowSize.Items.AddRange(new object[] {
            "Small",
            "Normal",
            "Large"});
            this.cboxWindowSize.Location = new System.Drawing.Point(100, 104);
            this.cboxWindowSize.Name = "cboxWindowSize";
            this.cboxWindowSize.Size = new System.Drawing.Size(121, 23);
            this.cboxWindowSize.TabIndex = 2;
            // 
            // cboxLanguage
            // 
            this.cboxLanguage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.cboxLanguage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cboxLanguage.ForeColor = System.Drawing.Color.White;
            this.cboxLanguage.FormattingEnabled = true;
            this.cboxLanguage.Items.AddRange(new object[] {
            "English",
            "Hungarian",
            "Romanian"});
            this.cboxLanguage.Location = new System.Drawing.Point(100, 44);
            this.cboxLanguage.Name = "cboxLanguage";
            this.cboxLanguage.Size = new System.Drawing.Size(121, 23);
            this.cboxLanguage.TabIndex = 1;
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Location = new System.Drawing.Point(110, 173);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(100, 36);
            this.btnSettings.TabIndex = 3;
            this.btnSettings.Text = "Apply";
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.BtnOptions_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(344, 241);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.ComboBox cboxLanguage;
        private System.Windows.Forms.ComboBox cboxWindowSize;
        private System.Windows.Forms.Label labelWindowSize;
        private System.Windows.Forms.Label labelLanguage;
    }
}