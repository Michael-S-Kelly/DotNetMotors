using DotNetMotors.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMotors.Classes
{
    public class Plane : Air, IPropeller
    {
        public override int Passengers { get; set; } = 60;
        public override int Speed { get; set; } = 500;
        public override int Wheels { get; set; } = 7;
        public override string Type { get; set; } = "Air Plane";
        public string Propellers { get; set; } = "I have 4 propellers to keep me in the air.";


        public override string CatchPhrase()
        {
            return "I fly the friendly skies.";
        }

        public override string Description()
        {
            return $"I am a {Type} that carries {Passengers} passengers, travels at a speed of {Speed}mph and I have {Wheels} wheels.";
        }

        public override string UsedFor()
        {
            return $"I travel in the {TravelMethod}.";
        }
    }
}
