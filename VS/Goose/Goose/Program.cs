using System;

namespace Goose
{
    class Goose
    {
        public string name;
        public string honk;
        public int power;

        // private member with custom set and get methods 
        // which can be removed to only allow get or set as required
        string intentions = "BAD";
        public string Intentions
        {
            get { return intentions; }
            set { name = value; }
        }

        // Constructor
        public Goose(string namePass, string honkPass, int powerPass)
        {
            name = namePass;
            honk = honkPass;
            power = powerPass;
        }

        // Method
        public void HONK()
        {
            Console.WriteLine(name + " is ready to honk");
            for (int i = 0; i < power; i++)
            {
                Console.WriteLine(honk);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Goose one = new Goose("Jai", "HONK!", 5);
            one.HONK();
        }
    }
}
