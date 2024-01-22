using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace testgit2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите число: ");
            int n = Convert.ToInt32(Console.ReadLine());

            TaylorSin taylor = new TaylorSin(n);

            Console.WriteLine($"Факториал числа {taylor.N}: {TaylorSin.Factorial(n)}");
            Console.WriteLine($"Расчет функции при значении x = {n}. Вариант 1: {TaylorSin.Function(n)}");
            TaylorSin.Fibonachi(n);
            TaylorSin.Taylor(n);
            Console.ReadKey();
        }
    }
}
