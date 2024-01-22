using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    internal class Engine
    {
        public string Type { get; set; }
        public int Horsepower { get; set; }

        public Engine(string type, int horsepower)
        {
            Type = type;
            Horsepower = horsepower;
        }

        public void Start()
        {
            Console.WriteLine("Двигатель запущен");
        }

        public void Stop()
        {
            Console.WriteLine("Двигатель остановлен");
        }
    }
}
