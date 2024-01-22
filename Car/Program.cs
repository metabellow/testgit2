using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Engine v6Engine = new Engine("V6", 300);
            List<Wheel> wheels = new List<Wheel>
            {
                new Wheel("Michelin", 18),
                new Wheel("Michelin", 18),
                new Wheel("Michelin", 18),
                new Wheel("Michelin", 18)
            };

            Car myCar = new Car("Camry", "Toyota", 2023, 35000, v6Engine, wheels);

            Console.WriteLine(myCar.CarData());

            myCar.Start();
            myCar.Accelerate();
            myCar.Brake();
            myCar.Stop();

            Console.ReadKey();
        }
    }
}
