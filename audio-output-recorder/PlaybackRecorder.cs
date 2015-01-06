//audio-output-recorder by MightyNerd 2014
//PlaybackRecorder.cs - Class for recording audio using WASAPI loopback capture
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace audio_output_recorder
{
    class PlaybackRecorder
    {
        private NAudio.Wave.WaveFileWriter waveWriter;
        private NAudio.Wave.WasapiLoopbackCapture capture;

        private bool recording = false;
        
        public PlaybackRecorder(NAudio.CoreAudioApi.MMDevice device)
        {
            capture = new NAudio.Wave.WasapiLoopbackCapture(device);
            capture.DataAvailable += capture_DataAvailable;
        }

        void capture_DataAvailable(object sender, NAudio.Wave.WaveInEventArgs e)
        {
            if (recording)
            { 
                waveWriter.Write(e.Buffer, 0, e.BytesRecorded);
            }
        }

        public void Record(string path)
        {
            waveWriter = new NAudio.Wave.WaveFileWriter(path, capture.WaveFormat);
            capture.StartRecording();

            recording = true;
        }

        public void Stop()
        {
            recording = false;
            capture.StopRecording();
            waveWriter.Close();
        }

    }
}
