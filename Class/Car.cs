using System;

namespace Car
{
    class Car
    {
        public string model;
        public string company;
        public int year;

        public Car()
        {
            model = "Y";
            company = "Tesla";
            year = 2016;
            Console.WriteLine("Constructor was called");
        }

        public Car(string modelName, string companyName, int yearName)
        {
            model = modelName;
            company = companyName;
            year = yearName; 
        }

        public void honk()
        {
            Console.WriteLine("HONK! HONK!");
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            Car car2 = new Car("X","Honda",1234);
            Console.WriteLine(car1.model + car1.company + car1.year);
            Console.WriteLine(car2.model + car2.company + car2.year);
        }
    }
}