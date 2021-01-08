using System;

namespace methodStuff
{
    class Program
    {
        static bool shouldPrint(int a)
        {
            if (a < 10)
            {
                return true;
            }
            return false;
        }

        static void print(string data = "Inside print", bool shouldPrint = true)
        {
            if (shouldPrint)
            {
                Console.WriteLine(data);
            }
        }

        static void Main(string[] args)
        {
            print("Does this even runs?");
            print();
            print("This will not print", shouldPrint(11));
            print("This will not print twice", shouldPrint(9));
            print(shouldPrint: true, data: "Named parameters");
            // Will not work
            print(shouldPrint: true, "Named parameters");
        }
    }
}