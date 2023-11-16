using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Computer
{
    internal class Computer
    {
        public string Model { get; set; }
        public Processor Cpu { get; set; }
        public RAM Ram { get; set; }
        public HDD Storage { get; set; }
        public Power Power { get; set; }

        public Computer(string model, Processor cpu, RAM ram, HDD storage, Power power)
        {
            Model = model;
            Cpu = cpu;
            Ram = ram;
            Storage = storage;
            Power = power;
        }

        public string GetData()
        {
            return string.Format("Название: {0} \n" +
                "Процессор: {1} \n" +
                "Количество ОЗУ: {2} \n" +
                "Память: {3} \n" +
                "Мощность блока питания: {4}", Model, Cpu.GetData(), Ram.CapacityGB, Storage.GetData(), Power.PowerW);
        }

        public void PowerOn()
        {
            Power.PowerOn();
        }

        public void PowerOff()
        {
            Power.PowerOff();
        }

        public void InstallSoftware(string softwareName)
        {
            Cpu.ExecuteInstructions();
            Storage.StoreData(softwareName);
        }

        public void RunApplication(string applicationName)
        {
            Cpu.ExecuteInstructions();
            Console.WriteLine($"{applicationName} запущен");
        }
    }
}
