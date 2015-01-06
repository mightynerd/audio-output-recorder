namespace audio_output_recorder
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
            this.cDevice = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupEncode = new System.Windows.Forms.GroupBox();
            this.panelHelp = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblBps = new System.Windows.Forms.Label();
            this.lblTargetBitrate = new System.Windows.Forms.Label();
            this.cBitrate = new System.Windows.Forms.ComboBox();
            this.rOgg = new System.Windows.Forms.RadioButton();
            this.rMp3 = new System.Windows.Forms.RadioButton();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.chkEncode = new System.Windows.Forms.CheckBox();
            this.btnRecord = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.chkDownsample = new System.Windows.Forms.CheckBox();
            this.groupEncode.SuspendLayout();
            this.panelHelp.SuspendLayout();
            this.SuspendLayout();
            // 
            // cDevice
            // 
            this.cDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cDevice.FormattingEnabled = true;
            this.cDevice.Location = new System.Drawing.Point(60, 7);
            this.cDevice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cDevice.Name = "cDevice";
            this.cDevice.Size = new System.Drawing.Size(265, 21);
            this.cDevice.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Device:";
            // 
            // groupEncode
            // 
            this.groupEncode.Controls.Add(this.panelHelp);
            this.groupEncode.Controls.Add(this.lblBps);
            this.groupEncode.Controls.Add(this.lblTargetBitrate);
            this.groupEncode.Controls.Add(this.cBitrate);
            this.groupEncode.Controls.Add(this.rOgg);
            this.groupEncode.Controls.Add(this.rMp3);
            this.groupEncode.Location = new System.Drawing.Point(14, 60);
            this.groupEncode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupEncode.Name = "groupEncode";
            this.groupEncode.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupEncode.Size = new System.Drawing.Size(310, 103);
            this.groupEncode.TabIndex = 2;
            this.groupEncode.TabStop = false;
            // 
            // panelHelp
            // 
            this.panelHelp.Controls.Add(this.linkLabel1);
            this.panelHelp.Location = new System.Drawing.Point(230, 74);
            this.panelHelp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelHelp.Name = "panelHelp";
            this.panelHelp.Size = new System.Drawing.Size(75, 25);
            this.panelHelp.TabIndex = 8;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(9, 6);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(62, 13);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Help/About";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lblBps
            // 
            this.lblBps.AutoSize = true;
            this.lblBps.Enabled = false;
            this.lblBps.Location = new System.Drawing.Point(187, 67);
            this.lblBps.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBps.Name = "lblBps";
            this.lblBps.Size = new System.Drawing.Size(23, 13);
            this.lblBps.TabIndex = 6;
            this.lblBps.Text = "b/s";
            // 
            // lblTargetBitrate
            // 
            this.lblTargetBitrate.AutoSize = true;
            this.lblTargetBitrate.Enabled = false;
            this.lblTargetBitrate.Location = new System.Drawing.Point(10, 67);
            this.lblTargetBitrate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTargetBitrate.Name = "lblTargetBitrate";
            this.lblTargetBitrate.Size = new System.Drawing.Size(73, 13);
            this.lblTargetBitrate.TabIndex = 5;
            this.lblTargetBitrate.Text = "Target bitrate:";
            // 
            // cBitrate
            // 
            this.cBitrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBitrate.Enabled = false;
            this.cBitrate.FormattingEnabled = true;
            this.cBitrate.Items.AddRange(new object[] {
            "64k",
            "96k",
            "128k",
            "192k",
            "256k",
            "320k"});
            this.cBitrate.Location = new System.Drawing.Point(86, 65);
            this.cBitrate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cBitrate.Name = "cBitrate";
            this.cBitrate.Size = new System.Drawing.Size(100, 21);
            this.cBitrate.TabIndex = 5;
            // 
            // rOgg
            // 
            this.rOgg.AutoSize = true;
            this.rOgg.Enabled = false;
            this.rOgg.Location = new System.Drawing.Point(12, 41);
            this.rOgg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rOgg.Name = "rOgg";
            this.rOgg.Size = new System.Drawing.Size(86, 17);
            this.rOgg.TabIndex = 1;
            this.rOgg.Text = "OGG (vorbis)";
            this.rOgg.UseVisualStyleBackColor = true;
            // 
            // rMp3
            // 
            this.rMp3.AutoSize = true;
            this.rMp3.Checked = true;
            this.rMp3.Enabled = false;
            this.rMp3.Location = new System.Drawing.Point(12, 23);
            this.rMp3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rMp3.Name = "rMp3";
            this.rMp3.Size = new System.Drawing.Size(78, 17);
            this.rMp3.TabIndex = 0;
            this.rMp3.TabStop = true;
            this.rMp3.Text = "MP3 (lame)";
            this.rMp3.UseVisualStyleBackColor = true;
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(86, 211);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(177, 20);
            this.txtOutput.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 214);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Output folder:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(268, 206);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chkEncode
            // 
            this.chkEncode.AutoSize = true;
            this.chkEncode.Location = new System.Drawing.Point(14, 42);
            this.chkEncode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkEncode.Name = "chkEncode";
            this.chkEncode.Size = new System.Drawing.Size(106, 17);
            this.chkEncode.TabIndex = 4;
            this.chkEncode.Text = "Enable encoding";
            this.chkEncode.UseVisualStyleBackColor = true;
            this.chkEncode.CheckedChanged += new System.EventHandler(this.chkEncode_CheckedChanged);
            // 
            // btnRecord
            // 
            this.btnRecord.Location = new System.Drawing.Point(14, 172);
            this.btnRecord.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(251, 28);
            this.btnRecord.TabIndex = 5;
            this.btnRecord.Text = "Record";
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(268, 172);
            this.btnStop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(56, 28);
            this.btnStop.TabIndex = 6;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.button3_Click);
            // 
            // chkDownsample
            // 
            this.chkDownsample.AutoSize = true;
            this.chkDownsample.Checked = true;
            this.chkDownsample.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDownsample.Location = new System.Drawing.Point(165, 42);
            this.chkDownsample.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkDownsample.Name = "chkDownsample";
            this.chkDownsample.Size = new System.Drawing.Size(159, 17);
            this.chkDownsample.TabIndex = 7;
            this.chkDownsample.Text = "Downsample to 44.1kHz/16";
            this.chkDownsample.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 240);
            this.Controls.Add(this.chkDownsample);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnRecord);
            this.Controls.Add(this.chkEncode);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.groupEncode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cDevice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "audio-output-recorder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupEncode.ResumeLayout(false);
            this.groupEncode.PerformLayout();
            this.panelHelp.ResumeLayout(false);
            this.panelHelp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cDevice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupEncode;
        private System.Windows.Forms.Label lblBps;
        private System.Windows.Forms.Label lblTargetBitrate;
        private System.Windows.Forms.ComboBox cBitrate;
        private System.Windows.Forms.RadioButton rOgg;
        private System.Windows.Forms.RadioButton rMp3;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox chkEncode;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.CheckBox chkDownsample;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel panelHelp;
    }
}

