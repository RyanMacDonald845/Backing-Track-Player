namespace ClickTrackSoftware
{
    partial class AllPlaylistsPage
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
            PlaylistsLabel = new Label();
            CreateButton = new Button();
            BackButton = new Button();
            PlaylistNameInputBox = new TextBox();
            columnHeader1 = new ColumnHeader();
            PlaylistsListView = new ListView();
            SuspendLayout();
            // 
            // PlaylistsLabel
            // 
            PlaylistsLabel.AutoSize = true;
            PlaylistsLabel.Font = new Font("Segoe UI", 30F);
            PlaylistsLabel.ForeColor = SystemColors.ButtonHighlight;
            PlaylistsLabel.Location = new Point(848, 77);
            PlaylistsLabel.Name = "PlaylistsLabel";
            PlaylistsLabel.Size = new Size(162, 54);
            PlaylistsLabel.TabIndex = 3;
            PlaylistsLabel.Text = "Playlists";
            // 
            // CreateButton
            // 
            CreateButton.BackColor = SystemColors.ActiveCaptionText;
            CreateButton.Font = new Font("Segoe UI", 15F);
            CreateButton.ForeColor = SystemColors.ButtonHighlight;
            CreateButton.Location = new Point(865, 806);
            CreateButton.Name = "CreateButton";
            CreateButton.Size = new Size(116, 41);
            CreateButton.TabIndex = 4;
            CreateButton.Text = "Create";
            CreateButton.UseVisualStyleBackColor = false;
            CreateButton.Click += CreateButton_Click;
            // 
            // BackButton
            // 
            BackButton.BackColor = SystemColors.ActiveCaptionText;
            BackButton.Font = new Font("Segoe UI", 15F);
            BackButton.ForeColor = SystemColors.ButtonHighlight;
            BackButton.Location = new Point(879, 853);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(92, 38);
            BackButton.TabIndex = 5;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // PlaylistNameInputBox
            // 
            PlaylistNameInputBox.BackColor = SystemColors.InactiveCaptionText;
            PlaylistNameInputBox.Font = new Font("Segoe UI", 15F);
            PlaylistNameInputBox.ForeColor = SystemColors.HighlightText;
            PlaylistNameInputBox.Location = new Point(825, 766);
            PlaylistNameInputBox.MinimumSize = new Size(0, 6);
            PlaylistNameInputBox.Name = "PlaylistNameInputBox";
            PlaylistNameInputBox.PlaceholderText = "Playlist Name";
            PlaylistNameInputBox.Size = new Size(200, 34);
            PlaylistNameInputBox.TabIndex = 6;
            PlaylistNameInputBox.TextAlign = HorizontalAlignment.Center;
            // 
            // PlaylistsListView
            // 
            PlaylistsListView.BackColor = SystemColors.MenuText;
            PlaylistsListView.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
            PlaylistsListView.Font = new Font("Segoe UI", 15F);
            PlaylistsListView.ForeColor = SystemColors.Info;
            PlaylistsListView.FullRowSelect = true;
            PlaylistsListView.Location = new Point(780, 164);
            PlaylistsListView.MultiSelect = false;
            PlaylistsListView.Name = "PlaylistsListView";
            PlaylistsListView.Size = new Size(281, 578);
            PlaylistsListView.TabIndex = 5;
            PlaylistsListView.UseCompatibleStateImageBehavior = false;
            PlaylistsListView.View = View.Details;
            PlaylistsListView.SelectedIndexChanged += PlaylistsListView_SelectedIndexChanged;
            PlaylistsListView.MouseDoubleClick += PlaylistsListView_MouseDoubleClick;
            // 
            // AllPlaylistsPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            Controls.Add(PlaylistsListView);
            Controls.Add(PlaylistNameInputBox);
            Controls.Add(BackButton);
            Controls.Add(CreateButton);
            Controls.Add(PlaylistsLabel);
            Name = "AllPlaylistsPage";
            Size = new Size(1920, 1080);
            Load += AllPlaylistsPage_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        



        #endregion

        private Label PlaylistsLabel;
        private Button CreateButton;
        private Button BackButton;
        private TextBox PlaylistNameInputBox;
        private ColumnHeader columnHeader1;
        private ListView PlaylistsListView;
    }
}
