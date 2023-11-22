using System.Security.Cryptography.X509Certificates;

namespace VirtualPet
{    internal class Program
    {
        //Virtual Pet
        // Lag en konsoll-applikasjon hvor man kan generere opp flere forskjellige virtuelle kjæledyr.
        // Bruk constructor i klassen, og man skal ikke ha lov til å endre data som navn, age eller noen andre egenskaper utenfra klassen.
        // Lag funksjonalitet som gjør at man kan gi dyret mat, kose med dyret eller sjekke om dyret må på do
        //
        // Her er et eksempel på hvordan det kan se ut:
        //
        // Hvilket dyr vil du ta vare på? 
        // Pikachu
        // 1. Gi Pikachu mat
        // 2. Kos med Pikachu
        // 3. Sjekk om Pikachu må på do
        // 2
        // Pikachu smiler!
        // 1. Gi Pikachu mat
        // 2. Kos med Pikachu
        // 3. Sjekk om Pikachu må på do
        // 1
        // Pikachu er mett og fornøyd
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Name your pet:");
            string input = Console.ReadLine();
            Pet myPet = new Pet(input, 15, 0.5);
            bool gameRunning = Pet.gameRunning;
            while (gameRunning)
            {
                Console.Clear();
                gameMenu(myPet);

                myPet.CuddleBuildUp();
                if(myPet.Cuddle < 25) Console.WriteLine(myPet.Cuddle);
                Thread.Sleep(1000);
            }

            static void gameMenu(Pet myPet)
            {
                Console.WriteLine($"Your pet: {myPet.Name}");
                Console.WriteLine($"Age: {myPet.Age}");
                Console.WriteLine($"Hva vil du gjøre med {myPet.Name}");
                Console.WriteLine($"1. Gi {myPet.Name} mat.");
                Console.WriteLine($"2. Kos med {myPet.Name}.");
                Console.WriteLine($"3. Gå på do med {myPet.Name}.");
                Console.WriteLine($"4. Sjekk hvordan det går med {myPet.Name}.");
                int userInput = Convert.ToInt16(Console.ReadLine());

                //userInput switch
                //{
                //     1 => myPet.Feed(),
                //     2 => myPet.CuddlePet(),
                //     3 => myPet.Toilet(),
                //     4 => myPet.StatusPet(),
                //    _ => Console.WriteLine("Du må velge et gyldig alternativ"),
                //};

                if(userInput == 1)
                {
                    myPet.Feed();
                }
                else if (userInput == 2)
                {
                    myPet.CuddlePet();
                }
                else if (userInput == 3)
                {
                    myPet.Toilet();
                }
                else if (userInput == 4)
                {
                    Console.WriteLine(myPet.StatusPet()); 

                }
                else
                {
                    Console.WriteLine("Du må velge et gyldig alternativ");

                }

               
            }
        }
    }
}