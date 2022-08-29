using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElonSatsning
{
    public class Car
        {
            private int _battery;
            private int _meter;
            private string _color;


            public int _Battery
            { get { return _battery; } set { _battery = value; } }
            public int _Meter
            { get { return _meter; } set { _meter = value; } }
            public string _Color
            { get { return _color; } set { _color = value; } }


            public int Start()
            {
                _Battery = 100;
                return _Battery;
            }
            public void Color()
            {
                string[] color = { "Red", "Blue", "Green", "Yellow" };
                Random random = new Random();
                int randomIndex = random.Next(1, 4);
                string selectedColor = color[randomIndex];
                _color = selectedColor;
            }

            public void Drive()
            {
                int _Meter = int.Parse(Console.ReadLine());
                if (_Battery > 0)
                {
                    _Meter /= 20;
                    _battery -= _Meter;
                }
       }
   }
}