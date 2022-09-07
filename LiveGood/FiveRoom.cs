using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LiveGood
{
    internal class FiveRoom: Apartment
    {
        private int _roomCount;
        protected internal int RoomCount
        {
            get { return _roomCount; }
            private set { _roomCount = value; }
        }
        protected internal FiveRoom(bool Kitchen, bool Bathroom, bool Livingroom, int BathroomBay, int LivingroomBay, int RoomCount, int WindowCount, int ApartmentSize, bool FrontDoor, bool BackDoor, string FloorType, int TotalDoors) : base(Kitchen, Bathroom, Livingroom, BathroomBay, LivingroomBay, WindowCount, ApartmentSize, FrontDoor,  BackDoor, FloorType, TotalDoors)
        {
            this.RoomCount = RoomCount;
        }

        protected internal override void Rooms()
        {
            Console.WriteLine(Kitchen);
            Console.WriteLine(Bathroom);
            Console.WriteLine(Livingroom);
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

        protected internal virtual void Rooms2()
        { }
    }
}
