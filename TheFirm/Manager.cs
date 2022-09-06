using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm
{
    internal class Manager : Employee
    {
        private int _phoneNumber;
        protected internal int PhoneNumber
        {
            get { return _phoneNumber; }
            private set { _phoneNumber = value; }
        }

        protected internal Manager(string FirstName, string LastName, int CPRNumber, int PhoneNumber): base(FirstName, LastName, CPRNumber)
        {
            this.PhoneNumber = PhoneNumber;
        }

        protected internal override void EInfo()
        {
            Console.WriteLine(FirstName);
            Console.WriteLine(LastName);
            Console.WriteLine(CPRNumber);
            Console.WriteLine(PhoneNumber);
        }

        protected internal virtual void EInfo1()
        { }
    }
}
