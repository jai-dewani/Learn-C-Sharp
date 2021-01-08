using System;

namespace stringStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Jai Kumar Dewani";
            Console.WriteLine(name.ToUpper());
            Console.WriteLine(name.ToLower());
            Console.WriteLine(name.Contains("Dewani"));
            Console.WriteLine(name.Contains("Deewani"));
            Console.WriteLine(name[0]);
            Console.WriteLine(name[3]);
            Console.WriteLine(name[4]);
            Console.WriteLine(name.IndexOf("Kumar"));
            Console.WriteLine(name.IndexOf('K'));
            Console.WriteLine(name.IndexOf('Z'));
            Console.WriteLine(name.Length);
            Console.WriteLine(name.Substring(4));
            Console.WriteLine(name.Substring(4,5));
        }
    }
}