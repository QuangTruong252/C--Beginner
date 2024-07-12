using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class MusicPlayer : Form
    {
        string[] files, paths;
        public MusicPlayer()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBoxSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer.URL = paths[listBoxSongs.SelectedIndex];
        }

        private void MusicPlayer_Load(object sender, EventArgs e)
        {

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            // Allow to select Multi File
            ofd.Multiselect = true;
            if(ofd.ShowDialog() == DialogResult.OK )
            {
                files = ofd.SafeFileNames;
                paths = ofd.FileNames;

                for (int i = 0; i < files.Length; i++)
                {
                    listBoxSongs.Items.Add(files[i]);
                }
            }
        }
    }
}
