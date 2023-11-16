using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer
{
    internal class Power
    {
        public int PowerW { get; set; }

        public Power(int powerW)
        {
            PowerW = powerW;
        }

        public void PowerOn()
        {
            Console.WriteLine("Компьютер запущен");
        }

        public void PowerOff()
        {
            Console.WriteLine("Компьютер выключен");
        }
    }
}
