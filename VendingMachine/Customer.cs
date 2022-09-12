using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten.Logic
{
    internal class Customer
    {

        protected internal int cash = 1000;


        protected internal int GiveChange(int money)
        {
            int change = money - 20;

            return change;
        }

    }
}
