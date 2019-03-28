using DotNetMotors.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMotors.Classes
{
    public class Helicopter : Air, IPropeller
    {
        public override int Passengers { get; set; } = 4;
        public override int Speed { get; set; } = 60;
        public override string Type { get; set; } = "Helicopter";
        public string Propellers { get; set; } = "I have 2 propellers; one to fly and one to stablize and control where I go.";


        public override string CatchPhrase()
        {
            return "I fly the friendly skies.";
        }

        public override string Description()
        {
            return $"I am a {Type} that carries {Passengers} passengers and travels at a speed of {Speed}mph.";
        }

        public override string UsedFor()
        {
            return $"I travel in the {TravelMethod}.";
        }
    }
}
