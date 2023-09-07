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

            Console.WriteLine(fack(n));
            Console.ReadKey();
        }

            public static int fack(int n)
            {
                if (n == 1) return 1;
                else return n * fack(n - 1);
            }
    }
}
