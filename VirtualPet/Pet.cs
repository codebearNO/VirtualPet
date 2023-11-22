using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    internal class Pet
    {
        public string Name { get;  }
        public int Age { get; set; }
        public bool Hungry;
        public double Cuddle = 50;
        public double CuddleRate = 0;
        public static bool gameRunning = true;
        public bool FullBladder = true;


        public Pet(string name, int age, double cuddleRate)
        {
            Name = name;
            Age = age;
            CuddleRate = cuddleRate;
            Hungry = true;
    }
        public void Feed()
        {
            Console.WriteLine($"You fed {Name}");
            Hungry = false;
            FullBladder = true;
        }

        public void AgePet()
        {
            Age++;
        }

        public void Toilet()
        {
            FullBladder = false;
            Console.WriteLine($"You went to the toilet with {Name}");
            Hungry = true;
        }
        
        public void CuddleBuildUp()
        {
            if (Cuddle > 0)
            {
                Cuddle -= CuddleRate;
            }
            else
            {
                gameRunning = false;
                Console.Clear();
                Console.WriteLine("Game Over");
            }
        }

        public void CuddlePet()
        {
            Console.WriteLine($"You cuddle {Name}");

            Cuddle += 25;

        }

        public string StatusPet()
        {
            string a = $"{Name} er {Age} år gammel";
            string h = Hungry ? $"{Name} er sulten" : $"{Name} er mett";
            string c = Cuddle < 50 ? $"{Name} vil ha kos" : $"{Name} vil ha alenetid";
            string t = FullBladder ? $"{Name} må på do" : $"{Name} trenger ikke å gå på do akkurat nå";

            return a + "\n" + h + "\n" + c + "\n" + t;
        }

    }
}

//class Car
//{
//    public string model;

//    // Create a class constructor with a parameter
//    public Car(string modelName)
//    {
//        model = modelName;
//    }

//    static void Main(string[] args)
//    {
//        Car Ford = new Car("Mustang");
//        Console.WriteLine(Ford.model);
//    }
//}
