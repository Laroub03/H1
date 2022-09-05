using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keeper
{
    
    internal class Employee
    {
        private int id;
        private string name;

        public int Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }

        public void EmployeeID()
        {
            Random rnd = new Random();

            for (int j = 0; j < 5; j++)
            {
                Console.Write(rnd.Next(5));
            }
        }
    }
}
