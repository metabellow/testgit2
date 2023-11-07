using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    internal class Car
    {
        public string Model { get; set; }
        public string Make { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }
        public Engine CarEngine { get; set; }
        public List<Wheel> Wheels { get; set; }

        public Car(string model, string make, int year, double price, Engine engine, List<Wheel> wheels)
        {
            Model = model;
            Make = make;
            Year = year;
            Price = price;
            CarEngine = engine;
            Wheels = wheels;
        }

        public void Start()
        {
            CarEngine.Start();
        }

        public void Stop()
        {
            CarEngine.Stop();
        }

        public void Accelerate()
        {
            Console.WriteLine("Автомобиль ускоряется");
        }

        public void Brake()
        {
            Console.WriteLine("Автомобиль останавливается");
        }

        public string CarData() 
        {
            return string.Format("Марка автомобиля: {0} \n" +
                "Модель автомобиля: {1} \n" +
                "Год выпуска: {2} \n" +
                "Стоимость автомобиля: {3} \n" +
                "Тип двигателя: {4} \n" +
                "Мощность: {5} л.с. \n" +
                "Колеса:\n{6}", Make, Model, Year, Price, CarEngine.Type, CarEngine.Horsepower, WheelData());
        }

        public string WheelData() 
        {
            string wheels = "";
            foreach (Wheel wheel in Wheels)
            {
                
                wheels += string.Format("Марка: {0} \n" +
                    "Диаметр: {1} \n", wheel.Brand, wheel.Diameter);
            }

            return wheels;
            
        }
    }
}
