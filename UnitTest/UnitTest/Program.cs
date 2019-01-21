using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input n: ");
            int n = Convert.ToInt32(Console.ReadKey());
            Console.WriteLine($"n! = {Factorial(n)}");
            Console.ReadKey();
        }

        public static int Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            return n * Factorial(n - 1);
        }
    }
}
