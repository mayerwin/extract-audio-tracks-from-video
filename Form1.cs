using System.Diagnostics;
using System.Windows.Forms;
using System;
using System.IO;

namespace ExtractAudioTracksFromVideo {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnExtractTracks_Click(object sender, EventArgs e) {
            string ffmpegPath = txtFFmpegPath.Text;
            string inputFile = txtInputFile.Text;

            if (!File.Exists(ffmpegPath) || !File.Exists(inputFile)) {
                MessageBox.Show("Please ensure FFmpeg path and input file are correct.");
                return;
            }

            ExtractTracks(ffmpegPath, inputFile);
        }

        private void ExtractTracks(string ffmpegPath, string inputFile) {
            // Get the list of streams in the file
            ProcessStartInfo startInfo = new ProcessStartInfo {
                FileName = ffmpegPath,
                Arguments = $"-i \"{inputFile}\" -hide_banner",
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            string ffmpegOutput;
            using (Process process = new Process { StartInfo = startInfo }) {
                process.Start();
                ffmpegOutput = process.StandardError.ReadToEnd();
                process.WaitForExit();
            }

            // Parse the FFmpeg output to get the stream indices and types
            string[] lines = ffmpegOutput.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
            int streamIndex = 0;
            foreach (string line in lines) {
                if (line.Contains("Stream #0:")) {
                    string extension = "";
                    if (line.Contains("Video:")) extension = ".mp4";
                    else if (line.Contains("Audio:")) extension = ".m4a";
                    else if (line.Contains("Subtitle:")) extension = ".srt";

                    if (!string.IsNullOrEmpty(extension)) {
                        string outputFile = Path.Combine(Path.GetDirectoryName(inputFile),
                            Path.GetFileNameWithoutExtension(inputFile) + $"_track{streamIndex}" + extension);
                        ExtractStream(ffmpegPath, inputFile, streamIndex, outputFile);
                        streamIndex++;
                    }
                }
            }

            MessageBox.Show("Extraction completed!");
        }

        private void ExtractStream(string ffmpegPath, string inputFile, int streamIndex, string outputFile) {
            string arguments = $"-i \"{inputFile}\" -map 0:{streamIndex} -c copy \"{outputFile}\"";
            ProcessStartInfo startInfo = new ProcessStartInfo {
                FileName = ffmpegPath,
                Arguments = arguments,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (Process process = new Process { StartInfo = startInfo }) {
                process.Start();
                process.WaitForExit();
            }
        }

        private void btnBrowseInput_Click(object sender, EventArgs e) {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                txtInputFile.Text = openFileDialog1.FileName;
            }
        }

        private void btnBrowseFFmpeg_Click(object sender, EventArgs e) {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                txtFFmpegPath.Text = openFileDialog1.FileName;
            }
        }
    }
}
