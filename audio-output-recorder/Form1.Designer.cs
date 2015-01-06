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
            this.panelHelp = new System.Windows.Forms.Panel();
            this.groupEncode.SuspendLayout();
            this.panelHelp.SuspendLayout();
            this.SuspendLayout();
            // 
            // cDevice
            // 
            this.cDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cDevice.FormattingEnabled = true;
            this.cDevice.Location = new System.Drawing.Point(90, 11);
            this.cDevice.Name = "cDevice";
            this.cDevice.Size = new System.Drawing.Size(396, 28);
            this.cDevice.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
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
            this.groupEncode.Location = new System.Drawing.Point(21, 92);
            this.groupEncode.Name = "groupEncode";
            this.groupEncode.Size = new System.Drawing.Size(465, 158);
            this.groupEncode.TabIndex = 2;
            this.groupEncode.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(13, 9);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(89, 20);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Help/About";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lblBps
            // 
            this.lblBps.AutoSize = true;
            this.lblBps.Enabled = false;
            this.lblBps.Location = new System.Drawing.Point(280, 103);
            this.lblBps.Name = "lblBps";
            this.lblBps.Size = new System.Drawing.Size(30, 20);
            this.lblBps.TabIndex = 6;
            this.lblBps.Text = "b/s";
            // 
            // lblTargetBitrate
            // 
            this.lblTargetBitrate.AutoSize = true;
            this.lblTargetBitrate.Enabled = false;
            this.lblTargetBitrate.Location = new System.Drawing.Point(15, 103);
            this.lblTargetBitrate.Name = "lblTargetBitrate";
            this.lblTargetBitrate.Size = new System.Drawing.Size(108, 20);
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
            this.cBitrate.Location = new System.Drawing.Point(129, 100);
            this.cBitrate.Name = "cBitrate";
            this.cBitrate.Size = new System.Drawing.Size(148, 28);
            this.cBitrate.TabIndex = 5;
            // 
            // rOgg
            // 
            this.rOgg.AutoSize = true;
            this.rOgg.Enabled = false;
            this.rOgg.Location = new System.Drawing.Point(18, 63);
            this.rOgg.Name = "rOgg";
            this.rOgg.Size = new System.Drawing.Size(127, 24);
            this.rOgg.TabIndex = 1;
            this.rOgg.Text = "OGG (vorbis)";
            this.rOgg.UseVisualStyleBackColor = true;
            // 
            // rMp3
            // 
            this.rMp3.AutoSize = true;
            this.rMp3.Checked = true;
            this.rMp3.Enabled = false;
            this.rMp3.Location = new System.Drawing.Point(18, 35);
            this.rMp3.Name = "rMp3";
            this.rMp3.Size = new System.Drawing.Size(114, 24);
            this.rMp3.TabIndex = 0;
            this.rMp3.TabStop = true;
            this.rMp3.Text = "MP3 (lame)";
            this.rMp3.UseVisualStyleBackColor = true;
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(129, 325);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(264, 26);
            this.txtOutput.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Output folder:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(402, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chkEncode
            // 
            this.chkEncode.AutoSize = true;
            this.chkEncode.Location = new System.Drawing.Point(21, 65);
            this.chkEncode.Name = "chkEncode";
            this.chkEncode.Size = new System.Drawing.Size(154, 24);
            this.chkEncode.TabIndex = 4;
            this.chkEncode.Text = "Enable encoding";
            this.chkEncode.UseVisualStyleBackColor = true;
            this.chkEncode.CheckedChanged += new System.EventHandler(this.chkEncode_CheckedChanged);
            // 
            // btnRecord
            // 
            this.btnRecord.Location = new System.Drawing.Point(21, 265);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(376, 43);
            this.btnRecord.TabIndex = 5;
            this.btnRecord.Text = "Record";
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(402, 265);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(84, 43);
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
            this.chkDownsample.Location = new System.Drawing.Point(248, 65);
            this.chkDownsample.Name = "chkDownsample";
            this.chkDownsample.Size = new System.Drawing.Size(230, 24);
            this.chkDownsample.TabIndex = 7;
            this.chkDownsample.Text = "Downsample to 44.1kHz/16";
            this.chkDownsample.UseVisualStyleBackColor = true;
            // 
            // panelHelp
            // 
            this.panelHelp.Controls.Add(this.linkLabel1);
            this.panelHelp.Location = new System.Drawing.Point(345, 114);
            this.panelHelp.Name = "panelHelp";
            this.panelHelp.Size = new System.Drawing.Size(112, 38);
            this.panelHelp.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 369);
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
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "audio-output-recorder";
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

