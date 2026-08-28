using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickTrackSoftware
{
    public partial class PlaylistPage : UserControl
    {
        public string PlaylistName { get; set; }
        public PlaylistPage(string name)
        {
            PlaylistName = name;
            InitializeComponent();

            SongsList.Columns.Add("Song", SongsList.Width / 2 - 2);
            SongsList.Columns.Add("Length", SongsList.Width / 2 - 2);


            if (!File.Exists($"../../../../Configs/{PlaylistName}.txt")) 
            { 
                //File.Create opens a stream line so you need to add .dispose in order to close the stream line after its complete
                File.Create($"../../../../Configs/{PlaylistName}.txt").Dispose();
            }
            LoadPlaylistTracks();
        }

        private void LoadPlaylistTracks()
        {
            //songsList
            SongsList.Items.Clear();
            foreach (string song in File.ReadAllLines($"../../../../Configs/{PlaylistName}.txt"))
            {
                ListViewItem songItem = new ListViewItem(Path.GetFileNameWithoutExtension(song));
                AudioFileReader soundPlayerSong = new AudioFileReader($"../../../../ClickTracks/{song}");
                string length = "--:--";
                length = soundPlayerSong.TotalTime.ToString(@"mm\:ss");
                songItem.SubItems.Add(length);

                SongsList.Items.Add(songItem);
            }
        }

        private void AddTrackButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Audio Files|*.mp3;*.wav";
            string FileName = "";
            string path = Path.GetFullPath(
                Path.Combine(Application.StartupPath, @"..\..\..\..\ClickTracks")
            );
            dialog.InitialDirectory = path;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                FileName = Path.GetFileName(dialog.FileName);
                bool FileExist = false;
                foreach (string file in Directory.GetFiles(path))
                {
                    if (Path.GetFileName(file) == FileName)
                        FileExist = true;
                }
                if (!FileExist)
                {
                    File.Copy(dialog.FileName, path + "\\" + FileName);
                    MessageBox.Show("File Copied");
                }

                File.AppendAllText($"../../../../Configs/{PlaylistName}.txt", FileName + "\n");
            }

            LoadPlaylistTracks();
        }
        

        private void PlaylistPage_Load(object sender, EventArgs e)
        {
            PlaylistNameLabel.Text = PlaylistName;

            PlaylistNameLabel.PerformLayout();

            PlaylistNameLabel.Left =
                (this.ClientSize.Width - PlaylistNameLabel.Width) / 2 - 50;

            PlaylistNameLabel.Top = 210;

        }

        private void SongsList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListView listView = sender as ListView;
            ListViewItem item = listView.GetItemAt(e.X, e.Y);
            string name = item.Text;

            Form1 form = (Form1)this.FindForm();
            form.ShowPanel(new TrackPlayer(name, PlaylistName));
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Form1 form = (Form1)this.FindForm();
            form.ShowPanel(new AllPlaylistsPage());
        }
    }
}
