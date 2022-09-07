using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveGood
{
    internal class FourRoom: FiveRoom
    {
        protected internal FourRoom(bool Kitchen, bool Bathroom, bool Livingroom, int BathroomBay, int LivingroomBay, int RoomCount, int WindowCount, int ApartmentSize, bool FrontDoor, bool BackDoor, string FloorType, int TotalDoors) : base(Kitchen, Bathroom, Livingroom, BathroomBay, LivingroomBay, RoomCount, WindowCount, ApartmentSize, FrontDoor, BackDoor, FloorType, TotalDoors)
        {

        }

        protected internal override void Rooms()
        {
            Console.WriteLine(Kitchen);
            Console.WriteLine(BathroomBay);
            Console.WriteLine(LivingroomBay);
            Console.WriteLine(RoomCount);
            Console.WriteLine(WindowCount);
            Console.WriteLine(ApartmentSize);
            Console.WriteLine(FrontDoor);
            Console.WriteLine(BackDoor);
            Console.WriteLine(FloorType);
            Console.WriteLine(TotalDoors);
        }
    }
}
