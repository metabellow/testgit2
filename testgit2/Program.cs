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

            Console.WriteLine($"Факториал числа {n}: {Factorial(n)}");
            Console.WriteLine($"Расчет функции при значении x = {n}. Вариант 1: {Function(n)}");
            Fibonachi(n);
            Console.ReadKey();
        }

        public static int Factorial(int n)
        {
            if (n == 1) return 1;
            else return n * Factorial(n - 1);
        }

        public static double Function(double n)
        {
            double res = Math.Sqrt(Math.Log(4.0 / 3.0)) + n + (9.0 / 7.0) - Math.Exp(Math.Sin((1.3 * n) - 0.7));


            return res;
        }

        public static void Fibonachi(int n)
        {
            int a = 0;
            int b = 1;

            Console.WriteLine($"Последовательность Фибоначчи до {n}: ");

            for (int i = 0; i < n+1; i++)
            {
                if (a <= n)
                {
                    Console.Write(a + " ");
                    int temp = a;
                    a = b;
                    b = temp + b;
                }
                else { break; }


            }
        }

    }
}
