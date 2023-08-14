namespace ExtractAudioTracksFromVideo {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.txtFFmpegPath = new System.Windows.Forms.TextBox();
            this.txtInputFile = new System.Windows.Forms.TextBox();
            this.btnExtractTracks = new System.Windows.Forms.Button();
            this.lblFFmpegPath = new System.Windows.Forms.Label();
            this.lblInputFile = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnBrowseFFmpeg = new System.Windows.Forms.Button();
            this.btnBrowseInput = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFFmpegPath
            // 
            this.txtFFmpegPath.Location = new System.Drawing.Point(118, 22);
            this.txtFFmpegPath.Name = "txtFFmpegPath";
            this.txtFFmpegPath.Size = new System.Drawing.Size(265, 20);
            this.txtFFmpegPath.TabIndex = 0;
            // 
            // txtInputFile
            // 
            this.txtInputFile.Location = new System.Drawing.Point(118, 61);
            this.txtInputFile.Name = "txtInputFile";
            this.txtInputFile.Size = new System.Drawing.Size(265, 20);
            this.txtInputFile.TabIndex = 1;
            // 
            // btnExtractTracks
            // 
            this.btnExtractTracks.Location = new System.Drawing.Point(118, 105);
            this.btnExtractTracks.Name = "btnExtractTracks";
            this.btnExtractTracks.Size = new System.Drawing.Size(96, 23);
            this.btnExtractTracks.TabIndex = 2;
            this.btnExtractTracks.Text = "Extract Tracks";
            this.btnExtractTracks.UseVisualStyleBackColor = true;
            this.btnExtractTracks.Click += new System.EventHandler(this.btnExtractTracks_Click);
            // 
            // lblFFmpegPath
            // 
            this.lblFFmpegPath.AutoSize = true;
            this.lblFFmpegPath.Location = new System.Drawing.Point(12, 25);
            this.lblFFmpegPath.Name = "lblFFmpegPath";
            this.lblFFmpegPath.Size = new System.Drawing.Size(70, 13);
            this.lblFFmpegPath.TabIndex = 3;
            this.lblFFmpegPath.Text = "FFmpeg Path:";
            // 
            // lblInputFile
            // 
            this.lblInputFile.AutoSize = true;
            this.lblInputFile.Location = new System.Drawing.Point(12, 64);
            this.lblInputFile.Name = "lblInputFile";
            this.lblInputFile.Size = new System.Drawing.Size(56, 13);
            this.lblInputFile.TabIndex = 4;
            this.lblInputFile.Text = "Input File:";
            // 
            // btnBrowseFFmpeg
            // 
            this.btnBrowseFFmpeg.Location = new System.Drawing.Point(389, 20);
            this.btnBrowseFFmpeg.Name = "btnBrowseFFmpeg";
            this.btnBrowseFFmpeg.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseFFmpeg.TabIndex = 5;
            this.btnBrowseFFmpeg.Text = "Browse";
            this.btnBrowseFFmpeg.UseVisualStyleBackColor = true;
            this.btnBrowseFFmpeg.Click += new System.EventHandler(this.btnBrowseFFmpeg_Click);
            // 
            // btnBrowseInput
            // 
            this.btnBrowseInput.Location = new System.Drawing.Point(389, 59);
            this.btnBrowseInput.Name = "btnBrowseInput";
            this.btnBrowseInput.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseInput.TabIndex = 6;
            this.btnBrowseInput.Text = "Browse";
            this.btnBrowseInput.UseVisualStyleBackColor = true;
            this.btnBrowseInput.Click += new System.EventHandler(this.btnBrowseInput_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 146);
            this.Controls.Add(this.btnBrowseInput);
            this.Controls.Add(this.btnBrowseFFmpeg);
            this.Controls.Add(this.lblInputFile);
            this.Controls.Add(this.lblFFmpegPath);
            this.Controls.Add(this.btnExtractTracks);
            this.Controls.Add(this.txtInputFile);
            this.Controls.Add(this.txtFFmpegPath);
            this.Name = "Form1";
            this.Text = "Extract Audio Tracks From Video";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtFFmpegPath;
        private System.Windows.Forms.TextBox txtInputFile;
        private System.Windows.Forms.Button btnExtractTracks;
        private System.Windows.Forms.Label lblFFmpegPath;
        private System.Windows.Forms.Label lblInputFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnBrowseFFmpeg;
        private System.Windows.Forms.Button btnBrowseInput;
    }
}