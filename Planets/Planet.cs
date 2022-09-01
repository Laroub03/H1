using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planets
{
    internal class Planet
    {

        private string _planetName;


        public string _PlanetName
        { get => _planetName; }

        public Planet(string planets)
        {
            _planetName = planets;
        }

    }
}
