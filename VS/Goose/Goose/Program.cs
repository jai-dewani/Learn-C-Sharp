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
            for (int i = 0; i < power; i++)data:image/pjpeg;base64,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
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
