using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten.Logic
{
       class Admin : VendingMachine
        {
            protected internal int adminBal;

        //Allows admin to collect money from vm
        protected internal string CollectMoney()
            {
            adminBal += vendingBal;
            vendingBal = 0;
            return "Money collected. You now have: " + adminBal + " DKK";
            }
        }
 }


