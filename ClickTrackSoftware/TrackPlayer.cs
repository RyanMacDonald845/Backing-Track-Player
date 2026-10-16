using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Media;
using System.Text;
using System.Windows.Forms;
using NAudio.Wave;

namespace ClickTrackSoftware
{
    public partial class TrackPlayer : UserControl
    {
        private string _playlistName = "";
        public TrackPlayer()
        {
        }
        public TrackPlayer(string songName)
        {
            InitializeComponent();
            _currentSong = $"{songName}.mp3";
            LoadSong(_currentSong);
        }

        public TrackPlayer(string songName, string playlistName)
        {
            InitializeComponent();
            _currentSong = $"{songName}.mp3";
            LoadSong(_currentSong);
            _playlistName = playlistName;
        }

        private WaveOutEvent _output = new WaveOutEvent();
        private AudioFileReader? _audioFile;
        private bool _isDragging = false;
        private bool _isPlaying = false;
        private string? _currentSong;

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (_playlistName == "")
            {
                Form1? form = (Form1?)this.FindForm();
                if (form != null)
                    form.ShowPanel(new AllTracksPage());
                
            }
            else
            {
                Form1? form = (Form1?)this.FindForm();
                if (form != null)
                    form.ShowPanel(new PlaylistPage(_playlistName));
            }
            if (_output != null)
                _output.Stop();
        }



        private void LoadSong(string path)
        {
            _audioFile = new AudioFileReader("../../../../ClickTracks/" + path);
            _output.Init(_audioFile);
            TrackLengthLabel.Text = _audioFile.TotalTime.ToString(@"mm\:ss");
            SongTitleLabel.Text = "Song Title: ";
            SongTitleLabel.Text += Path.GetFileNameWithoutExtension(path);
        }
        private void PlayButton_Click(object sender, EventArgs e)
        {
            if (!_isPlaying && _output != null)
            {
                _output.Play();
                songTimer.Start();
                _isPlaying = true;
                PlayButton.Text = "⏸️";
            }
            else if (_output != null)
            {
                _output.Stop();
                PlayButton.Text = "▶️";
                _isPlaying = false;
            }

        }
        private void SongTimer_Tick(object sender, EventArgs e)
        {
            if (_audioFile == null) return;
            if (_isDragging) return;

            float progress = (float)_audioFile.CurrentTime.TotalMilliseconds /
                             (float)_audioFile.TotalTime.TotalMilliseconds;

            trackBar.Value = (int)(progress * 1000);

            CurrentTimeLabel.Text = _audioFile.CurrentTime.ToString(@"mm\:ss");
        }

        private void TrackBar_MouseDown(object sender, MouseEventArgs e)
        {
            _isDragging = true;
        }

        private void TrackBar_MouseUp(object sender, MouseEventArgs e)
        {
            float progress = trackBar.Value / 1000f;
            if (_audioFile != null)
                _audioFile.CurrentTime = TimeSpan.FromMilliseconds(
                    _audioFile.TotalTime.TotalMilliseconds * progress
                );

            _isDragging = false;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            
        }

        private void nextSongButton(object sender, EventArgs e)
        {

        }

        private void RestartSongButton_Click(object sender, EventArgs e)
        {
            _output.Stop();
            PlayButton.Text = "▶️";
            _isPlaying = false;
            if(_currentSong != null)
                LoadSong(_currentSong);
        }
    }
}
