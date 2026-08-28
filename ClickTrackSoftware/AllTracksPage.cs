using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using NAudio.Wave;

namespace ClickTrackSoftware
{
    public partial class AllTracksPage : UserControl
    {
        public AllTracksPage()
        {
            InitializeComponent();
            TracksListView.Columns.Clear();

            TracksListView.Columns.Add("🎵 Track", 500);
            TracksListView.Columns.Add("⏱ Length", 100);
            TracksListView.Columns[0].Width = TracksListView.Width - 120;
            TracksListView.Columns[1].Width = 100;

            LoadTracks();
        }



        private void LoadTracks()
        {
            TracksListView.Items.Clear();

            string folderPath = "../../../../ClickTracks";//Path.Combine(Application.StartupPath, "ClickTracks");

            foreach (string file in Directory.GetFiles(folderPath))
            {
                string length = "";

                try
                {
                    using (var reader = new AudioFileReader(file))
                    {
                        length = reader.TotalTime.ToString(@"mm\:ss");
                    }
                }
                catch
                {
                    length = "--:--";
                }

                ListViewItem item = new ListViewItem(Path.GetFileNameWithoutExtension(file));

                item.SubItems.Add(length);

                item.Tag = file;

                TracksListView.Items.Add(item);
            }
        }



        private void uploadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Audio Files|*.mp3;*.wav"; // sets a filter for the files. so only mp3 and wav files are accepted

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string clickTracksFolder = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..\..\..\ClickTracks"));
                // This gets the file path to i think a deeper file in the app and then it combines it with the string and makes it so the app can find the folder for the clicks

                string destinationPath = Path.Combine(clickTracksFolder, Path.GetFileName(dialog.FileName));
                // im pretty sure this adds the file name at the end of the path we previously created -> only used for naming purposes (i think)

                File.Copy(dialog.FileName, destinationPath, true);// this will actually copy the file that the user selected to the location we set.

                MessageBox.Show("File uploaded successfully");// prints success
            }
            LoadTracks();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Form1 form = (Form1)this.FindForm();
            form.ShowPanel(new MainPage());
        }

        private void TracksListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListView song = ((ListView)sender);
            ListViewItem item = song.GetItemAt(e.X, e.Y);
            string songname = item.Text;
            Form1 form = (Form1)this.FindForm();
            form.ShowPanel(new TrackPlayer(songname));
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (TracksListView.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in TracksListView.SelectedItems)
                {
                    File.Delete("" + item.Tag.ToString());
                }
                MessageBox.Show("File(s) deleted!");
                LoadTracks();
            }
            else
            {
                MessageBox.Show("No File Selected");
            }
    }
}
}
