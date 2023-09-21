using System;
using System.Collections.Generic;
using System.Linq;
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

            Console.WriteLine($"Факториал числа {n}: {Fack(n)}");
            Console.WriteLine($"Расчет функции от {n}. Вариант 1: {Function(n)}");
            Console.ReadKey();
        }

        public static int Fack(int n)
        {
            if (n == 1) return 1;
            else return n * Fack(n - 1);
        }

        public static double Function(double n)
        {
             double res = Math.Sqrt(Math.Log(4.0/3.0)) + n + (9.0 / 7.0) - Math.Exp(Math.Sin((1.3 * n) - 0.7));


            return res;
        }



    }
}
