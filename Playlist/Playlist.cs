using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playlist
{
    internal class Playlist
    {
        private string name;
        private LinkedList<Track> playlist = new LinkedList<Track>();
        public string Name { 
        get {return name; }
        set {name = value;}
        }
        public LinkedList<Track> Tracks
        {
            get { return playlist; }
            set { playlist = value; }
        }
        public Playlist(string Name)
        {

            name = Name;
        }
    }
}
