using System;

namespace intro
{
    class Car
    {
        public string color = "Red";
        static void Main(string[] args)
        {
            Car car1 = new Car();
            Car car2 = new Car();
            car1.color = "blue";
            Console.WriteLine(car1.color);
            Console.WriteLine(car2.color);
        }
    }
}