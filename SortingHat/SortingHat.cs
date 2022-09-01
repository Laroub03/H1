using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingHat
{
    public enum Groups
    {
        Gryffindor,
        Hufflepuff,
        Ravenclaw,
        Slythetin
    }
    internal class SortingHat
    {
        private Groups _groups;

        public Groups _Groups
        { get => _groups; }

        public SortingHat()
        {
            Random random = new Random();
            Groups groups = (Groups)random.Next(0, 4);
            _groups = groups;
        }
    }
}
