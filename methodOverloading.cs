using System;

namespace methodOverloading
{
    class Program
    {
        static int add(int a, int b)
        {
            return a + b;
        }
        static double add(double a, double b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(add(1, 2));
            Console.WriteLine(add(1.2, 2.3));
        }
    }
}