using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Queue
{
    class MainClass
    {
        static Playlist playlist = new Playlist();
        static void Main(string[] args)
        {
            do
            {

                Console.WriteLine("==================================================");
                Console.WriteLine("            H1 Queue Operations Menu");
                Console.WriteLine("==================================================");
                Console.WriteLine("\n1. Add items");
                Console.WriteLine("2. Delete items");
                Console.WriteLine("3. Show the number of items");
                Console.WriteLine("4. Show min and max items");
                Console.WriteLine("5. Find an item");
                Console.WriteLine("6. Print all items");
                Console.WriteLine("7. Exit");
                Console.WriteLine("Indtast valg");


                int choice = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Insert name of song");
                        string input = Console.ReadLine();
                        playlist.AddSong(input);
                        break;

                    case 2:
                        playlist.RmeoveSong();
                        Console.WriteLine("Song removed");
                        break;

                    case 3:
                        Console.WriteLine($"You have {playlist.NumberOfItems()} items");
                        break;

                    case 4:
                        Console.WriteLine("MIN 1 song/Max 5 songs");
                        break;
                    case 5:
                        Console.WriteLine("What song do you want to find?");
                        string input1 = Console.ReadLine();
                        Console.WriteLine(playlist.FindItem(input1));
                        break;

                    case 6:
                        Console.WriteLine(playlist.PrintAll());
                        break;

                    case 7:
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            } while (true);
        }
    }
}