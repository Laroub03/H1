﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    internal class Song
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        public Song(string name)
        {

            this.name = name;
        }
    }
}
