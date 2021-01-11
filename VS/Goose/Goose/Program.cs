using System;

namespace Goose
{
    class Animal
    {
        public string name;
        public string sound;

        public Animal(string name, string sound)
        {
            this.name = name;
            this.sound = sound;
        }

        public void makeSound()
        {
            Console.WriteLine(sound);
        }
    }
    class Goose : Animal
    {
        public int power;

        // private member with custom set and get methods 
        // which can be removed to only allow get or set as required
        string intentions = "BAD";
        public string Intentions
        {
            get { return intentions; }
            set { intentions = value; }
        }

        // Constructor
        public Goose(string namePass, string honkPass, int powerPass): base(namePass, honkPass)
        {
            this.power = powerPass;
        }

        // Method
        public new void makeSound()
        {
            Console.WriteLine(name + " is ready to honk");
            for (int i = 0; i < power; i++)
            {
                Console.WriteLine(sound);
            }
            Console.WriteLine(name + " has " + intentions + " intentions.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Goose one = new Goose("Jai", "HONK!", 5);
            one.Intentions = "GOOD";
            one.makeSound();
        }
    }
}
