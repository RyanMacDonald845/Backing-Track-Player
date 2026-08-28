namespace ClickTrackSoftware
{
    partial class AllTracksPage
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
            label1 = new Label();
            UploadButton = new Button();
            BackButton = new Button();
            TracksListView = new ListView();
            DeleteButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(879, 210);
            label1.Name = "label1";
            label1.Size = new Size(130, 54);
            label1.TabIndex = 2;
            label1.Text = "Tracks";
            // 
            // UploadButton
            // 
            UploadButton.Location = new Point(879, 791);
            UploadButton.Name = "UploadButton";
            UploadButton.Size = new Size(118, 32);
            UploadButton.TabIndex = 3;
            UploadButton.Text = "Upload";
            UploadButton.UseVisualStyleBackColor = true;
            UploadButton.Click += uploadButton_Click;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(899, 844);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(75, 23);
            BackButton.TabIndex = 4;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // TracksListView
            // 
            TracksListView.BackColor = SystemColors.MenuText;
            TracksListView.ForeColor = SystemColors.Info;
            TracksListView.FullRowSelect = true;
            TracksListView.Location = new Point(810, 299);
            TracksListView.MultiSelect = false;
            TracksListView.Name = "TracksListView";
            TracksListView.Size = new Size(270, 438);
            TracksListView.TabIndex = 5;
            TracksListView.UseCompatibleStateImageBehavior = false;
            TracksListView.View = View.Details;
            TracksListView.MouseDoubleClick += TracksListView_MouseDoubleClick;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(1049, 743);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(31, 25);
            DeleteButton.TabIndex = 6;
            DeleteButton.Text = "❌";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // AllTracksPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            Controls.Add(DeleteButton);
            Controls.Add(TracksListView);
            Controls.Add(BackButton);
            Controls.Add(UploadButton);
            Controls.Add(label1);
            Name = "AllTracksPage";
            Size = new Size(1920, 1080);
            ResumeLayout(false);
            PerformLayout();
        }

        

        #endregion

        private Label label1;
        private Button UploadButton;
        private Button BackButton;
        private ListView TracksListView;
        private Button DeleteButton;
    }
}
