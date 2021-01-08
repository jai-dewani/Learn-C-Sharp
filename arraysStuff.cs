using System;
using System.Linq;

namespace arrayStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 8,7,6,5,4,3,2 };
            Console.WriteLine(numbers.Length);
            for(int i=0; i<numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.Write("\n");
            foreach(int i in numbers)
            {
                Console.Write(i + " ");
            }
            Console.Write("\n");
            Array.Sort(numbers);
            foreach(int i in numbers)
            {
                Console.Write(i + " ");
            }
            Console.Write("\n");
            Console.WriteLine(numbers.Max());
            Console.WriteLine(numbers.Min());
            Console.WriteLine(numbers.Sum());
        }
    }
}