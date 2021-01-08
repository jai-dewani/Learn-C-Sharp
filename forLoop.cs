using System;

namespace forLoop
{
    class Programs
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
            string[] cars = { "Tesla", "BMW", "Audi" };
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }
        }
    }
}