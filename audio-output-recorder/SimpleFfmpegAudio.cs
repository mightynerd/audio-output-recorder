using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace audio_output_recorder
{
    class SimpleFfmpegAudio
    {
        private Process ffmpeg;
        private string ffmpegPath;

        public SimpleFfmpegAudio(string path)
        {
            if (System.IO.File.Exists(path))
            {
                ffmpegPath = path;
            }
            else
            {
                throw new Exception("Invalid ffmpeg path");
            }

            ffmpeg = new Process();
        }

        public void Start(string args)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = ffmpegPath;
            startInfo.Arguments = args;

            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardError = true;

            ffmpeg.StartInfo = startInfo;
            ffmpeg.Start();
            ffmpeg.WaitForExit();
            if (ffmpeg.ExitCode != 0)
            {
                Debug.WriteLine(ffmpeg.StandardError.ReadToEnd());
            }
        }

        public static string CreateArgs(string codec, string bitrate, string input, string output)
        {
            return String.Format("-i \"{0}\" -c:a {1} -ar 44100 -ac 2 -b:a {2} \"{3}\"", input, codec, bitrate, output);
        }

    }
}
