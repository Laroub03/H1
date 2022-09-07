using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LiveGood
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Apartment f = new FiveRoom(true, true, true, 1, 3, 4, 10 , 110, true, true, "Marble", 7);
            Apartment o = new OneRoom(true, true, true, 1, 2, 7, 40, true, false, "Wood", 7);

            FiveRoom fr = (FiveRoom)f;
            OneRoom or = (OneRoom)o;


            Console.WriteLine("5 rooms apartment:");
            Console.WriteLine("The apartment has a kitchen: " + fr.Kitchen);
            Console.WriteLine("The apartment has a bathroom: " + fr.Bathroom);
            Console.WriteLine("The apartment has a livingroom: " + fr.Livingroom);
            Console.WriteLine("The bathroom has a {0} bay window", fr.BathroomBay);
            Console.WriteLine("The livingroom has {0} bay windows", fr.LivingroomBay);
            Console.WriteLine("Total amount of rooms is " + fr.RoomCount);
            Console.WriteLine("Total amount of windows is " + fr.WindowCount);
            Console.WriteLine("Apartment size is {0} kvm", fr.ApartmentSize);
            Console.WriteLine("The apartment has a frontdoor: " + fr.FrontDoor);
            Console.WriteLine("The apartment has a backdoor: " + fr.BackDoor);
            Console.WriteLine("The floor type is " + fr.FloorType);
            Console.WriteLine("Total amount of doors is " + fr.TotalDoors);

            Console.WriteLine("\nOne rooom apartment:");
            Console.WriteLine("The apartment has a kitchen: " + or.Kitchen);
            Console.WriteLine("The apartment has a bathroom: " + or.Bathroom);
            Console.WriteLine("The apartment has a livingroom: " + or.Livingroom);
            Console.WriteLine("The bathroom has a {0} bay window", or.BathroomBay);
            Console.WriteLine("The livingroom has {0} bay windows", or.LivingroomBay);
            Console.WriteLine("Total amount of windows is " + or.WindowCount);
            Console.WriteLine("Apartment size is {0} kvm", or.ApartmentSize);
            Console.WriteLine("The apartment has a frontdoor: " + or.FrontDoor);
            Console.WriteLine("The apartment has a backdoor: " + or.BackDoor);
            Console.WriteLine("The floor type is " + or.FloorType);
            Console.WriteLine("Total amount of doors is " + or.TotalDoors);

            //Output for class FiveRoom and OneRoom
        }
    }
}

