using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer
{
    internal class HDD
    {
        public int CapacityGB
        {
            get; set; // Гигабайты
        }
    public string Type
        {
            get; set;
        }

    public HDD(int capacityGB, string type)
        {
            CapacityGB = capacityGB;
            Type = type;
        }

        public void StoreData(string data)
        {
            Console.WriteLine("Файл сохранен");
        }
    }
}
