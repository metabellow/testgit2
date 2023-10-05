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

            Console.WriteLine($"Факториал числа {n}: {Factorial(n)}");
            Console.WriteLine($"Расчет функции при значении x = {n}. Вариант 1: {Function(n)}");
            Fibonachi(n);
            Taylor();
            Console.ReadKey();
        }

        public static double Factorial(int n)
        {
            if (n == 0)
                return 1;
            return n * Factorial(n - 1);

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

            for (int i = 0; i < n + 1; i++)
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

            Console.WriteLine();
        }

        public static void Taylor()
        {     
            double n = 5.0;

            Console.WriteLine($"Разложение sin({n}) по ряду Тейлора");
            Console.Write($"Введите точность после запятой: ");
            int count = int.Parse(Console.ReadLine());


            Console.WriteLine($"sin({n}) примерно равен: {CalculateSinTaylor(n, count)}");
        }

        //public static double CalculateSinTaylor(double x, int n)
        //{
        //    double result = 0.0;

        //    for (int i = 0; i < n; i++)
        //    {
        //        int exp = 2 * i + 1;
        //        double temp = Math.Pow(-1, i) * Math.Pow(x, exp) / Factorial(exp);
        //        result += temp;
        //    }

        //    return result;
        //}

        public static double CalculateSinTaylor(double x, int n)
        {
            double result = 0.0;
            int j = 0;
            double raz;
            double temp;
            double eps = Math.Pow(0.1, n);


            do
            {
                temp = result;
                int exp = 2 * j + 1;
                double term = Math.Pow(-1, j) * Math.Pow(x, exp) / Factorial(exp);
                result += term;
                j++;
                raz = Math.Abs(temp - result);
            } while (raz > eps);

            return result;
        }

    }
}
