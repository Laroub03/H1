using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsComing
{
    public enum Microchips
    {
        RX54667,
        QT8339, 
    }
 
    internal class Robot
    {
        private string _color;
        private int _battery;
        private int _soap;
        private int _wheels;
        private Microchips _microchips;
        public string _Color
        { get => _color; }             

        public int _Battery
            { get => _battery; }

        public int _Soap
            { get => _soap; }

        public int _Wheels
            { get => _wheels; }
        public Microchips _Microchips
            { get => _microchips; }
        public void Color()
        {
            string[] color = { "White", "Blue", "Green" };
            Random random = new Random();
            int randomIndex = random.Next(0, 3);
            string selectedColor = color[randomIndex];
            _color = selectedColor;
        }

        public void Battery()
        {
            if (_color != "White")
            {
                Random random = new Random();
                int battery = random.Next(0, 255);
                _battery = battery;
            }
        }

        public void Wheels()
        {
            int wheels = int.Parse(Console.ReadLine());
            if (wheels == 0)
            {
                Console.WriteLine("The size of the robot is small");
            }
            else if (wheels > 0)
            {
                Console.WriteLine("The size of the robot is medium");
            }
            else if (wheels > 5)
            {
                Console.WriteLine("The size of the robot is large");
            }
        }

        public Robot()
        {
            _soap = _soap;
            _soap = 2300;
            Random random = new Random();
            Microchips mc = (Microchips)random.Next(2);
            _microchips = mc;
            Color();
            Battery();
        }


    }
}
