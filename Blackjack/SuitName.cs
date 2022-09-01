using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    internal struct SuitName
    {
        //public string Name{ get => Name; set => Name = value; } 
        private string _name;
        public string _Name 
        { 
            get { return _name; }
            set { _name = value; }
        }

        public override string ToString()
        {
            return _Name;
        }
    }
}
