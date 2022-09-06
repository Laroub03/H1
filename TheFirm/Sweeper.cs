using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm
{
    internal class Sweeper : Employee
    {
        protected internal Sweeper(string FirstName, string LastName, int CPRNumber) : base(FirstName, LastName, CPRNumber)
        {  
        }

        protected internal override void EInfo()
        {
            Console.WriteLine(FirstName);
            Console.WriteLine(LastName);
            Console.WriteLine(CPRNumber);
        }
    }
}
