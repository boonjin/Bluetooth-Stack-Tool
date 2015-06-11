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
            this.buttonRetrieveDevices = new System.Windows.Forms.Button();
            this.buttonRunInstaller = new System.Windows.Forms.Button();
            this.buttonUpdateINF = new System.Windows.Forms.Button();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.buttonPatch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonRetrieveDevices
            // 
            this.buttonRetrieveDevices.Location = new System.Drawing.Point(12, 12);
            this.buttonRetrieveDevices.Name = "buttonRetrieveDevices";
            this.buttonRetrieveDevices.Size = new System.Drawing.Size(114, 34);
            this.buttonRetrieveDevices.TabIndex = 0;
            this.buttonRetrieveDevices.Text = "Retrieve Devices";
            this.buttonRetrieveDevices.UseVisualStyleBackColor = true;
            this.buttonRetrieveDevices.Click += new System.EventHandler(this.buttonRetrieveDevices_Click);
            // 
            // buttonRunInstaller
            // 
            this.buttonRunInstaller.Location = new System.Drawing.Point(12, 52);
            this.buttonRunInstaller.Name = "buttonRunInstaller";
            this.buttonRunInstaller.Size = new System.Drawing.Size(114, 34);
            this.buttonRunInstaller.TabIndex = 1;
            this.buttonRunInstaller.Text = "Run Toshiba Installer";
            this.buttonRunInstaller.UseVisualStyleBackColor = true;
            this.buttonRunInstaller.Click += new System.EventHandler(this.buttonRunInstaller_Click);
            // 
            // buttonUpdateINF
            // 
            this.buttonUpdateINF.Location = new System.Drawing.Point(12, 92);
            this.buttonUpdateINF.Name = "buttonUpdateINF";
            this.buttonUpdateINF.Size = new System.Drawing.Size(114, 34);
            this.buttonUpdateINF.TabIndex = 2;
            this.buttonUpdateINF.Text = "Update INF";
            this.buttonUpdateINF.UseVisualStyleBackColor = true;
            this.buttonUpdateINF.Click += new System.EventHandler(this.buttonUpdateINF_Click);
            // 
            // textBoxLog
            // 
            this.textBoxLog.Location = new System.Drawing.Point(132, 12);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLog.Size = new System.Drawing.Size(304, 229);
            this.textBoxLog.TabIndex = 3;
            // 
            // buttonPatch
            // 
            this.buttonPatch.Location = new System.Drawing.Point(12, 132);
            this.buttonPatch.Name = "buttonPatch";
            this.buttonPatch.Size = new System.Drawing.Size(114, 34);
            this.buttonPatch.TabIndex = 4;
            this.buttonPatch.Text = "Patch Registry";
            this.buttonPatch.UseVisualStyleBackColor = true;
            this.buttonPatch.Click += new System.EventHandler(this.buttonPatch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 261);
            this.Controls.Add(this.buttonPatch);
            this.Controls.Add(this.textBoxLog);
            this.Controls.Add(this.buttonUpdateINF);
            this.Controls.Add(this.buttonRunInstaller);
            this.Controls.Add(this.buttonRetrieveDevices);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRetrieveDevices;
        private System.Windows.Forms.Button buttonRunInstaller;
        private System.Windows.Forms.Button buttonUpdateINF;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.Button buttonPatch;
    }
}

