using System;
using DotNetMotors.Classes;
using DotNetMotors.Interfaces;

namespace DotNetMotors
{
    public class Program
    {
        static void Main(string[] args)
        {

            FishingBoatMessage();
            RecreationalBoatMessage();
            AmphibiousMessage();
            PlaneMessage();
            HelicopterMessage();
            SudanMessage();
            TruckMessage();
            MotorcycleMessage();
            Console.ReadKey();
        }

        static void FishingBoatMessage()
        {
            FishingBoat fishingBoat = new FishingBoat();
            string phrase = fishingBoat.Description();
            Console.WriteLine(phrase);
            phrase = fishingBoat.UsedFor();
            Console.WriteLine(phrase);
            phrase = fishingBoat.CatchPhrase();
            Console.WriteLine(phrase);
            Console.WriteLine(" ");
        }

        static void RecreationalBoatMessage()
        {
            RecreationalBoat recreationalBoat = new RecreationalBoat();
            string phrase = recreationalBoat.Description();
            Console.WriteLine(phrase);
            phrase = recreationalBoat.UsedFor();
            Console.WriteLine(phrase);
            phrase = recreationalBoat.CatchPhrase();
            Console.WriteLine(phrase);
            Console.WriteLine(" ");
        }

        static void AmphibiousMessage()
        {
            Amphibious amphibious = new Amphibious();
            string phrase = amphibious.Description();
            Console.WriteLine(phrase);
            phrase = amphibious.UsedFor();
            Console.WriteLine(phrase);
            phrase = amphibious.CatchPhrase();
            Console.WriteLine(phrase);
            Console.WriteLine(" ");
        }

        static void PlaneMessage()
        {
            Plane plane = new Plane();
            string phrase = plane.Description();
            Console.WriteLine(phrase);
            phrase = plane.UsedFor();
            Console.WriteLine(phrase);
            phrase = plane.CatchPhrase();
            Console.WriteLine(phrase);
            Console.WriteLine(" ");
        }

        static void HelicopterMessage()
        {
            Helicopter helicopter = new Helicopter();
            string phrase = helicopter.Description();
            Console.WriteLine(phrase);
            phrase = helicopter.UsedFor();
            Console.WriteLine(phrase);
            phrase = helicopter.CatchPhrase();
            Console.WriteLine(phrase);
            Console.WriteLine(" ");
        }

        static void SudanMessage()
        {
            Sudan sudan = new Sudan();
            string phrase = sudan.Description();
            Console.WriteLine(phrase);
            phrase = sudan.UsedFor();
            Console.WriteLine(phrase);
            phrase = sudan.CatchPhrase();
            Console.WriteLine(phrase);
            Console.WriteLine(" ");
        }

        static void TruckMessage()
        {
            Truck truck = new Truck();
            string phrase = truck.Description();
            Console.WriteLine(phrase);
            phrase = truck.UsedFor();
            Console.WriteLine(phrase);
            phrase = truck.CatchPhrase();
            Console.WriteLine(phrase);
            Console.WriteLine(" ");
        }

        static void MotorcycleMessage()
        {
            Motorcycle motorcycle = new Motorcycle();
            string phrase = motorcycle.Description();
            Console.WriteLine(phrase);
            phrase = motorcycle.UsedFor();
            Console.WriteLine(phrase);
            phrase = motorcycle.CatchPhrase();
            Console.WriteLine(phrase);
            Console.WriteLine(" ");
        }
    }
}
