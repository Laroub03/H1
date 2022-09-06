using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm
{
    internal class ProjectManager : Manager
    {
        private string _Email;
        protected internal string Email
        { 
            get { return _Email; }
            private set { _Email = value; }
        }

        protected internal ProjectManager(string FirstName, string LastName, int CPRNumber, int PhoneNumber, string Email) : base(FirstName, LastName, CPRNumber, PhoneNumber)
        {
            this.Email = Email;
        }

        protected internal override void EInfo1()
        {
            base.EInfo1();
            Console.WriteLine(Email);
        }
    }
}
