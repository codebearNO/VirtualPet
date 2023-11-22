namespace VirtualPet
{
    internal class Program
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
            Pet myPet = new Pet(input, 15, 2);
            bool gameRunning = true;
            while (gameRunning)
            {
                Console.Clear();
                Console.WriteLine($"Your pet: {myPet.Name}");
                Console.WriteLine($"Age: {myPet.Age}"); 
                myPet.CuddleBuildUp();
                if(myPet.Cuddle < 25)Console.WriteLine(myPet.Cuddle);
                Thread.Sleep(100);
            }
        }
    }
}