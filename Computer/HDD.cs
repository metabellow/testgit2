using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer
{
    internal class HDD
    {
        public int CapacityGB { get; set; }
        public string Type { get; set; }

        public HDD(int capacityGB, string type)
        {
            CapacityGB = capacityGB;
            Type = type;
        }

        public string GetData()
        {
            return string.Format("Тип: {0} \n" +
                "Объем: {1} GB", Type, CapacityGB);
        }

        public void StoreData(string data)
        {
            Console.WriteLine($"{data} установлен");
        }
    }
}
