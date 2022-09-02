using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Playlist
{
    internal class Track
    {
        private string songName;
        private string artist;

        public string SongName
        {
            get { return songName; }
            set { songName = value; }
        }
        public string Artist { get { return artist; } set { artist = value; } }

        public Track(string songName, string artist)
        {

            this.songName = songName;
            this.artist = artist;
            
        }
    }
}
