using DotNetMotors.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMotors.Classes
{
    public class FishingBoat : Water, ISteeringWheel, IPropeller
    {
        public override string WaterUse { get; set; } = "to fish";
        public override int Passengers { get; set; } = 6;
        public override int Speed { get; set; } = 5;
        public override string Type { get; set; } = "Fishing Boat";
        public bool SteeringWheel { get; set; } = true;
        public string Propellers { get; set; } = "I have 2 propellers to go and steer.";


        public override string CatchPhrase()
        {
            return "A day of fishing is better than a day at work";
        }

        public override string Description()
        {
            return $"I am a {Type} that carries {Passengers} passengers and travel at a speed of {Speed}mph.   It is {SteeringWheel} that I have a steering wheel to control me.";
        }

        public override string UsedFor()
        {
            return $"I travel on the {TravelMethod} and I'm used {WaterUse}.";
        }
    }
}
