namespace ClickTrackSoftware
{
    partial class PlaylistPage
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
            AddTrackButton = new Button();
            PlaylistNameLabel = new Label();
            SongsList = new ListView();
            BackButton = new Button();
            SuspendLayout();
            // 
            // AddTrackButton
            // 
            AddTrackButton.BackColor = SystemColors.ActiveCaptionText;
            AddTrackButton.Font = new Font("Segoe UI", 15F);
            AddTrackButton.ForeColor = SystemColors.ButtonHighlight;
            AddTrackButton.Location = new Point(855, 774);
            AddTrackButton.Name = "AddTrackButton";
            AddTrackButton.Size = new Size(108, 41);
            AddTrackButton.TabIndex = 0;
            AddTrackButton.Text = "Add";
            AddTrackButton.UseVisualStyleBackColor = false;
            AddTrackButton.Click += AddTrackButton_Click;
            // 
            // PlaylistNameLabel
            // 
            PlaylistNameLabel.AutoSize = true;
            PlaylistNameLabel.Font = new Font("Segoe UI", 30F);
            PlaylistNameLabel.ForeColor = SystemColors.ButtonHighlight;
            PlaylistNameLabel.Location = new Point(0, 0);
            PlaylistNameLabel.Name = "PlaylistNameLabel";
            PlaylistNameLabel.Size = new Size(0, 54);
            PlaylistNameLabel.TabIndex = 1;
            // 
            // SongsList
            // 
            SongsList.BackColor = SystemColors.ControlText;
            SongsList.ForeColor = SystemColors.HighlightText;
            SongsList.FullRowSelect = true;
            SongsList.Location = new Point(774, 277);
            SongsList.Name = "SongsList";
            SongsList.Size = new Size(259, 440);
            SongsList.TabIndex = 5;
            SongsList.UseCompatibleStateImageBehavior = false;
            SongsList.View = View.Details;
            SongsList.MouseDoubleClick += SongsList_MouseDoubleClick;
            // 
            // BackButton
            // 
            BackButton.BackColor = SystemColors.ActiveCaptionText;
            BackButton.ForeColor = SystemColors.ButtonFace;
            BackButton.Location = new Point(872, 832);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(75, 23);
            BackButton.TabIndex = 3;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // PlaylistPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            Controls.Add(BackButton);
            Controls.Add(SongsList);
            Controls.Add(PlaylistNameLabel);
            Controls.Add(AddTrackButton);
            Name = "PlaylistPage";
            Size = new Size(1920, 1080);
            Load += PlaylistPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        

        #endregion

        private Button AddTrackButton;
        private Label PlaylistNameLabel;
        private ListView SongsList;
        private Button BackButton;
    }
}
