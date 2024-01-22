using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    internal class Wheel
    {
        public string Brand { get; set; }
        public double Diameter { get; set; }

        public Wheel(string brand, double diameter)
        {
            Brand = brand;
            Diameter = diameter;
        }
    }
}
