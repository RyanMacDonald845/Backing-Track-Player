namespace ClickTrackSoftware
{
    partial class MainPage
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
            PlaylistsButton = new Button();
            TracksButton = new Button();
            TitleLabel = new Label();
            SuspendLayout();
            // 
            // PlaylistsButton
            // 
            PlaylistsButton.BackColor = SystemColors.ActiveCaptionText;
            PlaylistsButton.Font = new Font("Segoe UI", 15F);
            PlaylistsButton.ForeColor = SystemColors.ButtonHighlight;
            PlaylistsButton.Location = new Point(852, 561);
            PlaylistsButton.Name = "PlaylistsButton";
            PlaylistsButton.Padding = new Padding(0, 0, 0, 3);
            PlaylistsButton.Size = new Size(177, 69);
            PlaylistsButton.TabIndex = 0;
            PlaylistsButton.Text = "Playlists";
            PlaylistsButton.UseVisualStyleBackColor = false;
            PlaylistsButton.Click += PlaylistButton_Click;
            // 
            // TracksButton
            // 
            TracksButton.BackColor = SystemColors.ActiveCaptionText;
            TracksButton.Font = new Font("Segoe UI", 15F);
            TracksButton.ForeColor = SystemColors.ButtonHighlight;
            TracksButton.Location = new Point(852, 451);
            TracksButton.Name = "TracksButton";
            TracksButton.Padding = new Padding(0, 0, 0, 3);
            TracksButton.Size = new Size(177, 62);
            TracksButton.TabIndex = 1;
            TracksButton.Text = "Tracks";
            TracksButton.UseVisualStyleBackColor = false;
            TracksButton.Click += TracksButton_Click;
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Segoe UI", 30F);
            TitleLabel.ForeColor = SystemColors.ButtonHighlight;
            TitleLabel.Location = new Point(773, 291);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(324, 54);
            TitleLabel.TabIndex = 2;
            TitleLabel.Text = "Click Track Player";
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            Controls.Add(TitleLabel);
            Controls.Add(TracksButton);
            Controls.Add(PlaylistsButton);
            Name = "MainPage";
            Size = new Size(1920, 1080);
            ResumeLayout(false);
            PerformLayout();
        }

        



        #endregion

        private Button PlaylistsButton;
        private Button TracksButton;
        private Label TitleLabel;
    }
}
