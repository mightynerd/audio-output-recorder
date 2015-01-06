using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio;
using NAudio.CoreAudioApi;
using System.Diagnostics;

namespace audio_output_recorder
{
    public partial class Form1 : Form
    {
        private PlaybackRecorder recorder;
        private string currentOutput;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(Environment.CurrentDirectory + "\\ffmpeg.exe") == false)
            {
                if (MessageBox.Show("No ffmpeg.exe could not be found although it's needed for encoding and downsampling." + 
                    "\n\nWould you like to open up a webbrowser window with a website where you can download ffmpeg? " +
                    "Choose 32-bit static if you're unsure and put ffmpeg.exe in the same folder as audio-output-recorder.", 
                    "Error", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("http://ffmpeg.zeranoe.com/builds/");
                    Environment.Exit(0);
                }
                else
                {
                    chkDownsample.Checked = false;
                    chkDownsample.Enabled = false;
                    chkEncode.Checked = false;
                    chkEncode.Enabled = false;
                }
            }

            if (System.IO.Directory.Exists(Properties.Settings.Default.recordingPath))
            {
                txtOutput.Text = Properties.Settings.Default.recordingPath;
            }
            else
            {
                txtOutput.Text = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            }
            
            NAudio.CoreAudioApi.MMDeviceEnumerator devEnum = new NAudio.CoreAudioApi.MMDeviceEnumerator();
            NAudio.CoreAudioApi.MMDeviceCollection devColl = devEnum.EnumerateAudioEndPoints(
                NAudio.CoreAudioApi.DataFlow.Render, NAudio.CoreAudioApi.DeviceState.Active);

            foreach (NAudio.CoreAudioApi.MMDevice d in devColl)
            {
                cDevice.Items.Add(d.FriendlyName);
            }

            if (cDevice.Items.Count > 0)
            {
                cDevice.Text = cDevice.Items[0].ToString();
            }

            cBitrate.Text = "192k";
        }

        private void chkEncode_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEncode.Checked)
            {
                rOgg.Enabled = true;
                rMp3.Enabled = true;
                cBitrate.Enabled = true;
                lblBps.Enabled = true;
                lblTargetBitrate.Enabled = true;
                chkDownsample.Checked = true;
                chkDownsample.Enabled = false;
            }
            else
            {
                rOgg.Enabled = false;
                rMp3.Enabled = false;
                cBitrate.Enabled = false;
                lblBps.Enabled = false;
                lblTargetBitrate.Enabled = false;
                chkDownsample.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browse = new FolderBrowserDialog();
            browse.Description = "Select output folder";
            if (browse.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtOutput.Text = browse.SelectedPath;
            }

            if (System.IO.Directory.Exists(txtOutput.Text) == false)
            {
                MessageBox.Show("Error: Please choose a valid output path!");
            }

            FixOutputTextbox();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            NAudio.CoreAudioApi.MMDevice currentDevice = null;
            foreach (MMDevice d in new MMDeviceEnumerator().EnumerateAudioEndPoints(DataFlow.Render, DeviceState.Active))
            {
                if (d.FriendlyName == cDevice.Text)
                {
                    currentDevice = d;
                }
            }

            if (currentDevice == null)
            {
                MessageBox.Show("Error: Device not found.");
                return;
            }
            
            recorder = new PlaybackRecorder(currentDevice);

            if (System.IO.Directory.Exists(txtOutput.Text) == false)
            {
                MessageBox.Show("Error: Please choose a valid output path!");
                return;
            }

            FixOutputTextbox();

            btnRecord.Enabled = false;
            btnStop.Enabled = true;

            currentOutput = GetOutputName();

            recorder.Record(currentOutput + "_TEMP.wav");
            this.Text = "[REC] audio-output-capture";
        }

        private void FixOutputTextbox()
        {
            if (txtOutput.Text.EndsWith("\\") == false)
            {
                txtOutput.Text += "\\";
            }
        }

        private string GetOutputName()
        {
            FixOutputTextbox();
            return txtOutput.Text +
            DateTime.Now.Day.ToString() + "_" + DateTime.Now.Month.ToString() + "_" + DateTime.Now.Year.ToString() + "___" +
            DateTime.Now.Hour.ToString() + "_" + DateTime.Now.Minute.ToString() + "_" + DateTime.Now.Second.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            recorder.Stop();
            btnStop.Enabled = false;
            //Encode

            string output = currentOutput;

            if (chkDownsample.Checked == false)
            {
                System.IO.File.Move(output + "_TEMP.wav", output + ".wav");
                return;
            }

            SimpleFfmpegAudio encoder = new SimpleFfmpegAudio(Environment.CurrentDirectory + "\\" + "ffmpeg.exe");
            string codec = "pcm_s16le";


            if (chkEncode.Checked == false)
            {
                output += ".wav";
                codec = "pcm_s16le"; 
            }
            else if (rMp3.Checked == true)
            {
                output += ".mp3";
                codec = "libmp3lame";
            }
            else if (rOgg.Checked == true)
            {
                output += ".ogg";
                codec = "libvorbis";
            }

            Debug.WriteLine("Arguments: "+ SimpleFfmpegAudio.CreateArgs(codec, cBitrate.Text, output.Remove(output.LastIndexOf('.')) + "_TEMP.wav", output));
            encoder.Start(SimpleFfmpegAudio.CreateArgs(codec, cBitrate.Text, output.Remove(output.LastIndexOf('.')) + "_TEMP.wav", output));

            //Done encoding
            System.IO.File.Delete(output.Remove(output.LastIndexOf('.')) + "_TEMP.wav");
            btnRecord.Enabled = true;
            this.Text = "audio-output-capture";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new HelpForm().Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (System.IO.Directory.Exists(txtOutput.Text))
            {
                Properties.Settings.Default.recordingPath = txtOutput.Text;
                Properties.Settings.Default.Save();
            }
        }
    }
}
