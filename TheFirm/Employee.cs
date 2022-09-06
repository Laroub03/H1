using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm
{
    internal abstract class Employee
    {
        private string _firstName;
        private string _lastName;
        private int _cprNumber;


        protected internal string FirstName
        {
            get { return _firstName; }
            private set { _firstName = value; }
        }

        protected internal string LastName
        {
            get { return _lastName; }
            private set { _lastName = value; }
        }
        
        protected internal int CPRNumber
        {
            get { return _cprNumber; }
            private set { _cprNumber = value; }
        }

        private protected Employee(string FirstName, string LastName, int CPRNumber)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.CPRNumber = CPRNumber;
        }

        protected internal abstract void EInfo();

    }
}
