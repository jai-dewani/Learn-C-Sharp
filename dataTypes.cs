using System;

namespace dataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name = "Jai";
            char initial = 'J';
            int age = 21;
            // Least accurate -> Most accurate 
            // float, double, decimal
            double height = 5.9;
            bool isMale = true;
            Console.WriteLine(Name + initial + age + height + isMale);
        }
    }
}