using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Processor cpu = new Processor("Ryzen 5", 8, 3200);
            RAM ram = new RAM(16);
            HDD hdd = new HDD(1024, "SSD");
            Power power = new Power(700);

            Computer computer = new Computer("FFD-E34", cpu, ram, hdd, power);

            Console.WriteLine(computer.GetData());

            Console.ReadKey();
        }
    }
}
