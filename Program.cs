using System;

namespace Constructors
{
    internal class Program
    {
        public static int PrintHello(string name, string surname)
        {
            if (string.IsNullOrEmpty(name))
            {
                return 0;
            }
            if (string.IsNullOrEmpty(surname))
            {
                return 0;
            }
            Console.WriteLine($"Hello {name} {surname}.");
            return 1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(10));
            Console.WriteLine(FactorialCycle(5));
            Console.ReadLine();

        }

        public static int Factorial(int value)
        {
            if (value <= 1)
            {
                return 1;
            }
            else
            {
                return value * Factorial(value - 1);
            }

        }

        public static int FactorialCycle(int value)
        {
            int i;
            int res;
            res = 1;
            for (i = 1; i <= value; i++)
            {
                res = res * i;
            }
            return res;
        }
    }
}
