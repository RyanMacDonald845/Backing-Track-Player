using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickTrackSoftware
{
    public partial class AllPlaylistsPage : UserControl
    {
        public AllPlaylistsPage()
        {
            InitializeComponent();
            PlaylistsListView.Columns.Clear();
            PlaylistsListView.Columns.Add("", 0);
            PlaylistsListView.Columns.Add("Playlists", PlaylistsListView.Width - 22, HorizontalAlignment.Center);

            PlaylistsListViewLoad();
        }

       

        private void PlaylistsListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // implementation:
            //opens playlist page and connects to the appropriate file
            ListView listView = (ListView)sender;
            ListViewItem playlistItem = listView.GetItemAt(e.X, e.Y);
            string playlist = playlistItem.SubItems[1].Text;

            PlaylistPage playlistPage = new PlaylistPage(playlist);
            Form1 form = (Form1)this.FindForm();
            form.ShowPanel(playlistPage);
        }


        private void CreateButton_Click(object sender, EventArgs e)
        {
            string name = PlaylistNameInputBox.Text;
            if (name.Length > 0)
            {
                bool playlistExists = false;

                foreach (ListViewItem item in PlaylistsListView.Items)
                {
                    
                    if (item.SubItems[1].Text == name)
                    {
                        playlistExists = true;
                    }
                }

                if (!playlistExists)
                {
                    PlaylistPage playlistPage = new PlaylistPage(PlaylistNameInputBox.Text);
                    Form1 form = (Form1)this.FindForm();
                    form.ShowPanel(playlistPage);
                }
                else
                {
                    MessageBox.Show("Name already exists!");
                }
            }
            else
            {
                MessageBox.Show("Name is required!");
            }
            //File.AppendAllText("../../../../Configs/PlaylistsConfig.txt", "FirstGig!!!\n");
        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            Form1 form = (Form1)this.FindForm();
            form.ShowPanel(new MainPage());
        }

        private void PlaylistsListViewLoad()
        {
            PlaylistsListView.Items.Clear(); // clearing everything before loading stuff again

            foreach (string file in Directory.GetFiles("../../../../Configs"))
            {
                ListViewItem item = new ListViewItem("");
                item.SubItems.Add(Path.GetFileNameWithoutExtension(file));
                PlaylistsListView.Items.Add(item);
            }


        }

        private void AllPlaylistsPage_Load(object sender, EventArgs e)
        {

        }

        private void PlaylistsListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AllPlaylistsPage_Load_1(object sender, EventArgs e)
        {

        }
    }
}
