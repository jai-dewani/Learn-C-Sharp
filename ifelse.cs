using System;

namespace ifelse
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 12;
            if (a > b)
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(3);
            }
            if (a < b)
            {
                Console.WriteLine(2);
            }
            if (a > b)
            {
                Console.WriteLine(4);
            }else if( a!=b )
            {
                Console.WriteLine(5);
            }
            else
            {
                Console.WriteLine(6);
            }
            string result = (a < b) ? "A" : "B";
            Console.WriteLine(result);
        }
    }
}