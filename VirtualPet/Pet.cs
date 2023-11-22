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
        public bool Hungry = true;
        public double Cuddle = 50;
        public double CuddleRate = 0;


        public Pet(string name, int age, double cuddleRate)
        {
            Name = name;
            Age = age;
            CuddleRate = cuddleRate;
        }
        public void Feed()
        {
            Console.WriteLine($"You fed {Name}");
            Hungry = false;
        }

        public void AgePet()
        {
            Age++;
        }

        public void Toilet()
        {
            // Bladder = empty
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
            Cuddle += 25;
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
