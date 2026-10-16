using NAudio.Wave;

namespace ClickTrackSoftware
{
    partial class TrackPlayer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            BackButton = new Button();
            PlayButton = new Button();
            songTimer = new System.Windows.Forms.Timer(components);
            trackBar = new TrackBar();
            CurrentTimeLabel = new Label();
            TrackLengthLabel = new Label();
            SongTitleLabel = new Label();
            PreviousSongButton = new Button();
            NextSongButton = new Button();
            RestartSongButton = new Button();
            ((System.ComponentModel.ISupportInitialize)trackBar).BeginInit();
            SuspendLayout();
            // 
            // BackButton
            // 
            BackButton.BackColor = SystemColors.ActiveCaptionText;
            BackButton.Font = new Font("Segoe UI", 15F);
            BackButton.ForeColor = SystemColors.ButtonHighlight;
            BackButton.Location = new Point(1010, 1206);
            BackButton.Margin = new Padding(3, 4, 3, 4);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(166, 84);
            BackButton.TabIndex = 0;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // PlayButton
            // 
            PlayButton.BackColor = SystemColors.ActiveCaptionText;
            PlayButton.Font = new Font("Segoe UI", 15F);
            PlayButton.ForeColor = SystemColors.ButtonHighlight;
            PlayButton.Location = new Point(1077, 696);
            PlayButton.Margin = new Padding(3, 4, 3, 4);
            PlayButton.Name = "PlayButton";
            PlayButton.Size = new Size(86, 63);
            PlayButton.TabIndex = 1;
            PlayButton.Text = "▶️";
            PlayButton.UseVisualStyleBackColor = false;
            PlayButton.Click += PlayButton_Click;
            // 
            // songTimer
            // 
            songTimer.Tick += SongTimer_Tick;
            // 
            // trackBar
            // 
            trackBar.BackColor = SystemColors.ActiveCaptionText;
            trackBar.Location = new Point(621, 656);
            trackBar.Margin = new Padding(3, 4, 3, 4);
            trackBar.Maximum = 1000;
            trackBar.Name = "trackBar";
            trackBar.Size = new Size(985, 56);
            trackBar.TabIndex = 2;
            trackBar.TickStyle = TickStyle.None;
            trackBar.MouseDown += TrackBar_MouseDown;
            trackBar.MouseUp += TrackBar_MouseUp;
            // 
            // CurrentTimeLabel
            // 
            CurrentTimeLabel.AutoSize = true;
            CurrentTimeLabel.Font = new Font("Segoe UI", 12F);
            CurrentTimeLabel.ForeColor = SystemColors.ButtonHighlight;
            CurrentTimeLabel.Location = new Point(648, 696);
            CurrentTimeLabel.Name = "CurrentTimeLabel";
            CurrentTimeLabel.Size = new Size(60, 28);
            CurrentTimeLabel.TabIndex = 3;
            CurrentTimeLabel.Text = "00:00";
            // 
            // TrackLengthLabel
            // 
            TrackLengthLabel.AutoSize = true;
            TrackLengthLabel.Font = new Font("Segoe UI", 12F);
            TrackLengthLabel.ForeColor = SystemColors.ButtonHighlight;
            TrackLengthLabel.Location = new Point(1550, 688);
            TrackLengthLabel.Name = "TrackLengthLabel";
            TrackLengthLabel.Size = new Size(60, 28);
            TrackLengthLabel.TabIndex = 4;
            TrackLengthLabel.Text = "00:00";
            // 
            // SongTitleLabel
            // 
            SongTitleLabel.Anchor = AnchorStyles.None;
            SongTitleLabel.AutoSize = true;
            SongTitleLabel.Font = new Font("Segoe UI", 30F);
            SongTitleLabel.ForeColor = SystemColors.ButtonHighlight;
            SongTitleLabel.Location = new Point(621, 531);
            SongTitleLabel.Name = "SongTitleLabel";
            SongTitleLabel.Size = new Size(274, 67);
            SongTitleLabel.TabIndex = 5;
            SongTitleLabel.Text = "Song Title: ";
            SongTitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PreviousSongButton
            // 
            PreviousSongButton.BackColor = SystemColors.ActiveCaptionText;
            PreviousSongButton.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            PreviousSongButton.ForeColor = SystemColors.ButtonHighlight;
            PreviousSongButton.Location = new Point(993, 696);
            PreviousSongButton.Margin = new Padding(3, 4, 3, 4);
            PreviousSongButton.Name = "PreviousSongButton";
            PreviousSongButton.Padding = new Padding(0, 0, 0, 8);
            PreviousSongButton.Size = new Size(50, 63);
            PreviousSongButton.TabIndex = 6;
            PreviousSongButton.Text = "|<";
            PreviousSongButton.UseVisualStyleBackColor = false;
            PreviousSongButton.Click += backButton_Click;
            // 
            // NextSongButton
            // 
            NextSongButton.BackColor = SystemColors.ActiveCaptionText;
            NextSongButton.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            NextSongButton.ForeColor = SystemColors.ButtonHighlight;
            NextSongButton.Location = new Point(1193, 696);
            NextSongButton.Margin = new Padding(3, 4, 3, 4);
            NextSongButton.Name = "NextSongButton";
            NextSongButton.Padding = new Padding(0, 0, 0, 8);
            NextSongButton.Size = new Size(50, 63);
            NextSongButton.TabIndex = 7;
            NextSongButton.Text = ">|";
            NextSongButton.UseVisualStyleBackColor = false;
            NextSongButton.Click += nextSongButton;
            // 
            // RestartSongButton
            // 
            RestartSongButton.BackColor = SystemColors.ActiveCaptionText;
            RestartSongButton.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            RestartSongButton.ForeColor = SystemColors.ButtonHighlight;
            RestartSongButton.Location = new Point(800, 696);
            RestartSongButton.Margin = new Padding(3, 4, 3, 4);
            RestartSongButton.Name = "RestartSongButton";
            RestartSongButton.Padding = new Padding(7, 0, 0, 8);
            RestartSongButton.Size = new Size(58, 63);
            RestartSongButton.TabIndex = 8;
            RestartSongButton.Text = "↺ ";
            RestartSongButton.UseVisualStyleBackColor = false;
            RestartSongButton.Click += RestartSongButton_Click;
            // 
            // TrackPlayer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            Controls.Add(RestartSongButton);
            Controls.Add(NextSongButton);
            Controls.Add(PreviousSongButton);
            Controls.Add(PlayButton);
            Controls.Add(SongTitleLabel);
            Controls.Add(TrackLengthLabel);
            Controls.Add(CurrentTimeLabel);
            Controls.Add(trackBar);
            Controls.Add(BackButton);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TrackPlayer";
            Size = new Size(2194, 1440);
            ((System.ComponentModel.ISupportInitialize)trackBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }










        #endregion

        private Button BackButton;
        private Button PlayButton;
        private System.Windows.Forms.Timer songTimer;
        private TrackBar trackBar;
        private Label CurrentTimeLabel;
        private Label TrackLengthLabel;
        private Label SongTitleLabel;
        private Button PreviousSongButton;
        private Button NextSongButton;
        private Button RestartSongButton;
    }
}
