using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer
{
    internal class Processor
    {
        public string Model { get; set; }
        public int Cores { get; set; }
        public double ClockSpeed { get; set; }

        public Processor(string model, int cores, double clockSpeed)
        {
            Model = model;
            Cores = cores;
            ClockSpeed = clockSpeed;
        }

        public string GetData()
        {
            return string.Format("Модель: {0} \n" +
                "Количество ядер: {1} \n" +
                "Частота: {2} Ггц", Model, Cores, ClockSpeed);
        }

        public void ExecuteInstructions()
        {
            Console.WriteLine("Выполняется задача");
        }
    }
}
