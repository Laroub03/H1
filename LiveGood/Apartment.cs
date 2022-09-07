using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LiveGood
{
    internal abstract class Apartment
    {
        private bool _kitchen;
        private bool _bathroom;
        private bool _livingroom;
        private int _bathroomBay;
        private int _livingroomBay;
        private int _windowCount;
        private int _apartmentSize;
        private bool _frontDoor;
        private bool _backDoor;
        private string _floorType;
        private int _totalDoors;

        protected internal bool Kitchen
        {
            get { return _kitchen; }
            private set { _kitchen = value; }
        }
        protected internal bool Bathroom
        {
            get { return _bathroom; }
            private set { _bathroom = value; }
        }
        protected internal bool Livingroom
        {
            get { return _livingroom; }
            private set { _livingroom = value; }
        }

        protected internal int BathroomBay
        {
            get { return _bathroomBay; }
            private set { _bathroomBay = value; }
        }

        protected internal int LivingroomBay
        {
            get { return _livingroomBay; }
            private set { _livingroomBay = value; }
        }

        protected internal int WindowCount
        {
            get { return _windowCount; }
            private set { _windowCount = value; }
        }

        protected internal int ApartmentSize
        {
            get { return _apartmentSize; }
            private set { _apartmentSize = value; }
        }
        protected internal bool FrontDoor
        { get { return _frontDoor; } private set { _frontDoor = value; } }
        protected internal bool BackDoor
        { get { return _backDoor; } private set { _backDoor = value; } }

        protected internal string FloorType
            { get { return _floorType; } private set { _floorType = value; } }
        protected internal int TotalDoors
        { get { return _totalDoors; } private set { _totalDoors = value; } }

        private protected Apartment(bool Kitchen, bool Bathroom, bool Livingroom, int BathroomBay, int LivingroomBay, int WindowCount, int ApartmentSize, bool FrontDoor, bool BackDoor, string FloorType, int TotalDoors)
        {
            this.Kitchen = Kitchen;
            this.Bathroom = Bathroom;
            this.Livingroom = Livingroom;
            this.BathroomBay = BathroomBay;
            this.LivingroomBay = LivingroomBay;
            this.WindowCount = WindowCount;
            this.ApartmentSize = ApartmentSize;
            this.FrontDoor = FrontDoor;
            this.BackDoor = BackDoor;
            this.FloorType = FloorType;
            this.TotalDoors = TotalDoors;
        }

        protected internal abstract void Rooms();
    }
}
