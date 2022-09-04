using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    internal class Playlist
    {
        Queue<Song> songs = new Queue<Song>();

        public void AddSong(string add)
        {
            songs.Enqueue(new Song(add));
        }

        public void RmeoveSong()
        {
            songs.Dequeue();
        }

        public int NumberOfItems()
        {
            return songs.Count;
        }



        public string FindItem(string songName)
        {
            string temp = " ";
            List<Song> song = songs.Where(x => x.Name.Contains(songName)).ToList();

            if (song.Count() != 0)
            {
                foreach (Song i in song)
                {

                    temp = temp + i.Name;

                }

            }

            return temp;
        }

        public string PrintAll()
        {
            string temp = "";

            foreach (Song i in songs)
            {
                temp += i.Name + "\n";

            }

            return temp;
        }
    }
}
    