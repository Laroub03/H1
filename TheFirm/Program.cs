using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Employee m = new Manager("Ayoub", "Laroub", 1111110001, 22222222);
            Employee p = new ProjectManager("Bruce", "Wayne", 1111110002, 22222223, "BruceWayne@gotham.bat");
            Employee s = new Sweeper("Peter", "Parker", 22222224);

            Manager m2 = (Manager)m;
            ProjectManager p2 = (ProjectManager)p;
            Sweeper s2 = (Sweeper)s;

            Console.WriteLine("Manager:");
            Console.WriteLine(m2.FirstName);
            Console.WriteLine(m2.LastName);
            Console.WriteLine(m2.CPRNumber);
            Console.WriteLine(m2.PhoneNumber);

            Console.WriteLine("\nProject Manager:");
            Console.WriteLine(p2.FirstName);
            Console.WriteLine(p2.LastName);
            Console.WriteLine(p2.CPRNumber);
            Console.WriteLine(p2.PhoneNumber);
            Console.WriteLine(p2.Email);

            Console.WriteLine("\nSweeper: ");
            Console.WriteLine(s2.FirstName);
            Console.WriteLine(s2.LastName);
            Console.WriteLine(s2.CPRNumber);
        }
    }
}
