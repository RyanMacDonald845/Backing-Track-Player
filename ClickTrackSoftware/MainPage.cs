using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClickTrackSoftware
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void PlaylistButton_Click(object sender, EventArgs e)
        {
            Form1 form = (Form1)this.FindForm();
            form.ShowPanel(new AllPlaylistsPage());
        }

        private void TracksButton_Click(object sender, EventArgs e)
        {
            Form1 form = (Form1)this.FindForm();
            form.ShowPanel(new AllTracksPage());
        }
    }
}
