using System;

namespace namedParameters
{
    class Program
    {
        static void func(string a = "a", string b = "B", string c = "c")
        {
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
        static void Main(string[] args)
        {
            func("t");
        }
    }
}