using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planets
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            bool p = true;
            Planet Mercury = new Planet("Mercury");
            Planet Venus = new Planet("Venus");
            Planet Earth = new Planet("Earth");
            Planet Mars = new Planet("Mars");
            Planet Jupiter = new Planet("Jupiter");
            Planet Saturn = new Planet("Saturn");
            Planet Uranus = new Planet("Uranus");
            Planet Neptune = new Planet("Neptune");
            Planet Pluto = new Planet("Pluto");
            List<Planet> planets = new List<Planet>();
                    planets.Add(Mercury);
                    planets.Add(Earth);
                    planets.Add(Mars);
                    planets.Add(Jupiter);
                    planets.Add(Saturn);
                    planets.Add(Uranus);
                    planets.Add(Neptune);
                    planets.Add(Pluto);
                    planets.Insert(1, Venus);
                    planets.Remove(Pluto);
                    planets.Add(Pluto);
                     Console.WriteLine("");
            List<Planet> temperature = new List<Planet>();
                   temperature.Add(Mars);
                    temperature.Add(Jupiter);
                    temperature.Add(Saturn);
                    temperature.Add(Uranus);
                    temperature.Add(Neptune);
                    temperature.Add(Pluto);
            List<Planet> diameter = new List<Planet>();
            diameter.Add(Venus);
            diameter.Add(Earth);
            diameter.Add(Neptune);
            diameter.Clear();

            foreach (Planet i in planets)
            {
                 Console.WriteLine(i._PlanetName);
            }

            Console.WriteLine("***{0} planets***",planets.Count );

            Console.WriteLine("\n---Planets with mean temperture below 0 degrees---");

            foreach(Planet i in temperature)
            {
                Console.WriteLine(i._PlanetName);
            }

            Console.WriteLine("\n---Planets with a diameter above 10000 km but under 50000 km---");

            foreach(Planet i in diameter)
            {
                Console.WriteLine(i._PlanetName);
            }
        }
  }
}
