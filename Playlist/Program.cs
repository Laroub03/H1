using Playlist;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Playlist
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Playlist playlist = new Playlist("Hiphop");

            LinkedListNode<Track> t1 = new LinkedListNode<Track>(new Track("N95", "Kendrick Lamar"));
            LinkedListNode<Track> t2 = new LinkedListNode<Track>(new Track("Thuggin", "Freddie Gibbs"));
            LinkedListNode<Track> t3 = new LinkedListNode<Track>(new Track("Off The Grid", "Kanye West"));
            LinkedListNode<Track> t4 = new LinkedListNode<Track>(new Track("Where I Belong", "Joey Bada$$"));
            LinkedListNode<Track> t5 = new LinkedListNode<Track>(new Track("Doomsday", "MF DOOM"));
            LinkedListNode<Track> t6 = new LinkedListNode<Track>(new Track("Marvins Room", "Drake"));
            LinkedListNode<Track> t7 = new LinkedListNode<Track>(new Track("Peso", "A$AP Rocky"));
            LinkedListNode<Track> t8 = new LinkedListNode<Track>(new Track("JUGGERNAUT", "Tyler The Creator"));
            
            



            playlist.Tracks.AddFirst(t6);

            foreach (var item in playlist.Tracks)
            {
                Console.WriteLine(item.ToString);
            }

        }
    }
}