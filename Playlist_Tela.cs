using System;
using WMPLib;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lets_Musics
{
    public partial class Playlist_Tela : Form
    {
        WMPLib.WindowsMediaPlayer Player;
        public Playlist_Tela()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void PlayFile(String url)
        {
            Player = new WMPLib.WindowsMediaPlayer();
            Player.URL = url;
            Player.controls.play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

    }
}
