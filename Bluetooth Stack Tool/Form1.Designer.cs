namespace Bluetooth_Stack_Tool
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonRetrieveDevices = new System.Windows.Forms.Button();
            this.buttonRunInstaller = new System.Windows.Forms.Button();
            this.buttonUpdateINF = new System.Windows.Forms.Button();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.buttonPatch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDownload = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonDisableDriver = new System.Windows.Forms.Button();
            this.groupBoxWin8 = new System.Windows.Forms.GroupBox();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.groupBoxWin8.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonRetrieveDevices
            // 
            this.buttonRetrieveDevices.Location = new System.Drawing.Point(160, 232);
            this.buttonRetrieveDevices.Name = "buttonRetrieveDevices";
            this.buttonRetrieveDevices.Size = new System.Drawing.Size(114, 34);
            this.buttonRetrieveDevices.TabIndex = 0;
            this.buttonRetrieveDevices.Text = "Retrieve Devices";
            this.buttonRetrieveDevices.UseVisualStyleBackColor = true;
            this.buttonRetrieveDevices.Visible = false;
            this.buttonRetrieveDevices.Click += new System.EventHandler(this.buttonRetrieveDevices_Click);
            // 
            // buttonRunInstaller
            // 
            this.buttonRunInstaller.Location = new System.Drawing.Point(40, 232);
            this.buttonRunInstaller.Name = "buttonRunInstaller";
            this.buttonRunInstaller.Size = new System.Drawing.Size(114, 34);
            this.buttonRunInstaller.TabIndex = 1;
            this.buttonRunInstaller.Text = "Run Installer";
            this.buttonRunInstaller.UseVisualStyleBackColor = true;
            this.buttonRunInstaller.Visible = false;
            this.buttonRunInstaller.Click += new System.EventHandler(this.buttonRunInstaller_Click);
            // 
            // buttonUpdateINF
            // 
            this.buttonUpdateINF.Location = new System.Drawing.Point(27, 20);
            this.buttonUpdateINF.Name = "buttonUpdateINF";
            this.buttonUpdateINF.Size = new System.Drawing.Size(114, 34);
            this.buttonUpdateINF.TabIndex = 2;
            this.buttonUpdateINF.Text = "Auto Update INF";
            this.buttonUpdateINF.UseVisualStyleBackColor = true;
            this.buttonUpdateINF.Click += new System.EventHandler(this.buttonUpdateINF_Click);
            // 
            // textBoxLog
            // 
            this.textBoxLog.BackColor = System.Drawing.Color.White;
            this.textBoxLog.Location = new System.Drawing.Point(237, 12);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ReadOnly = true;
            this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLog.Size = new System.Drawing.Size(360, 229);
            this.textBoxLog.TabIndex = 3;
            // 
            // buttonPatch
            // 
            this.buttonPatch.Location = new System.Drawing.Point(27, 194);
            this.buttonPatch.Name = "buttonPatch";
            this.buttonPatch.Size = new System.Drawing.Size(173, 34);
            this.buttonPatch.TabIndex = 4;
            this.buttonPatch.Text = "Patch Registry for evaluation";
            this.buttonPatch.UseVisualStyleBackColor = true;
            this.buttonPatch.Click += new System.EventHandler(this.buttonPatch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "2 - Run Toshiba Bluetooth Stack Installer";
            // 
            // buttonDownload
            // 
            this.buttonDownload.Location = new System.Drawing.Point(164, 88);
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.Size = new System.Drawing.Size(67, 24);
            this.buttonDownload.TabIndex = 6;
            this.buttonDownload.Text = "Download";
            this.buttonDownload.UseVisualStyleBackColor = true;
            this.buttonDownload.Click += new System.EventHandler(this.buttonDownload_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "3 - After Installation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "1 - Before running installer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 9;
            // 
            // buttonDisableDriver
            // 
            this.buttonDisableDriver.Location = new System.Drawing.Point(19, 30);
            this.buttonDisableDriver.Name = "buttonDisableDriver";
            this.buttonDisableDriver.Size = new System.Drawing.Size(44, 24);
            this.buttonDisableDriver.TabIndex = 10;
            this.buttonDisableDriver.Text = "Guide";
            this.buttonDisableDriver.UseVisualStyleBackColor = true;
            this.buttonDisableDriver.Click += new System.EventHandler(this.buttonDisableDriver_Click);
            // 
            // groupBoxWin8
            // 
            this.groupBoxWin8.Controls.Add(this.buttonRestart);
            this.groupBoxWin8.Controls.Add(this.buttonDisableDriver);
            this.groupBoxWin8.Location = new System.Drawing.Point(44, 115);
            this.groupBoxWin8.Name = "groupBoxWin8";
            this.groupBoxWin8.Size = new System.Drawing.Size(187, 60);
            this.groupBoxWin8.TabIndex = 11;
            this.groupBoxWin8.TabStop = false;
            this.groupBoxWin8.Text = "If unable to detect device, disable driver signing";
            // 
            // buttonRestart
            // 
            this.buttonRestart.Location = new System.Drawing.Point(103, 30);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(78, 24);
            this.buttonRestart.TabIndex = 11;
            this.buttonRestart.Text = "Restart Now";
            this.buttonRestart.UseVisualStyleBackColor = true;
            this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(605, 245);
            this.Controls.Add(this.groupBoxWin8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonDownload);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPatch);
            this.Controls.Add(this.textBoxLog);
            this.Controls.Add(this.buttonUpdateINF);
            this.Controls.Add(this.buttonRunInstaller);
            this.Controls.Add(this.buttonRetrieveDevices);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Bluetooth Stack Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxWin8.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRetrieveDevices;
        private System.Windows.Forms.Button buttonRunInstaller;
        private System.Windows.Forms.Button buttonUpdateINF;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.Button buttonPatch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDownload;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonDisableDriver;
        private System.Windows.Forms.GroupBox groupBoxWin8;
        private System.Windows.Forms.Button buttonRestart;
    }
}

