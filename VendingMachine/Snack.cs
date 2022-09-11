using System;
using System.Collections.Generic;
using System.Text;


//TODO: Make namespaces Logic and Model
namespace Automaten.Logic
{
    internal class Snack
    {
        private int _price;
        private string _snackName;

        protected internal int Price
        {
            get { return _price; }
            set { _price = value; }
        }

        protected internal string Name
        {
            get { return _snackName; }
            set { _snackName = value; }
        }


        protected internal Snack(string name, int price)
        {
            Name = name;
            Price = price;
        }
    }
}
