using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Keeper;

namespace HRDepartment
{
    internal class HR
    {

        private string _name;
        private Random rnd = new Random();


        protected internal string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        protected internal void AddHRID()
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(rnd.Next(5));
            }
        }
    }
}