using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer
{
    internal class RAM
    {
        public int CapacityGB { get; set; }

        public RAM(int capacity) 
        { 
            CapacityGB = capacity;
        }
    }
}
