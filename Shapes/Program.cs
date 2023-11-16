using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(0, 0, 5);
            Square square = new Square(1, 1, 4);
            Rectangle rectangle = new Rectangle(2, 2, 3, 6);

            Console.WriteLine("Круг: " + circle);
            Console.WriteLine("Квадрат: " + square);
            Console.WriteLine("Прямоугольник: " + rectangle);

            Console.WriteLine("\n Перемещение объектов \n");

            circle.Move(2, 3);
            square.Move(1, -1);
            rectangle.Move(-3, 5);

            Console.WriteLine("Круг: " + circle);
            Console.WriteLine("Квадрат: " + square);
            Console.WriteLine("Прямоугольник: " + rectangle);

            Console.WriteLine("\n Изменение размеров объектов \n");

            circle.Resize(1.5);
            square.Resize(2);
            rectangle.Resize(0.5);

            Console.WriteLine("Круг: " + circle);
            Console.WriteLine("Квадрат: " + square);
            Console.WriteLine("Прямоугольник: " + rectangle);

            Console.WriteLine("\n Вращение объектов \n");

            square.Rotate(45);
            rectangle.Rotate(90);

            Console.WriteLine("Круг: " + circle);
            Console.WriteLine("Квадрат: " + square);
            Console.WriteLine("Прямоугольник: " + rectangle);

            Console.ReadKey();
        }
    }
}
