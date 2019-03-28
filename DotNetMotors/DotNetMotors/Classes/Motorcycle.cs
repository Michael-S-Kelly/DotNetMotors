using DotNetMotors.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMotors.Classes
{
    public class Motorcycle : Ground
    {
        public override string GroundUse { get; set; } = "to whip through traffic";
        public override int Passengers { get; set; } = 1;
        public override int Wheels { get; set; } = 2;
        public override string Type { get; set; } = "Motorcycle";

        public override string CatchPhrase()
        {
            return "Born to be Wild!";
        }

        public override string Description()
        {
            return $"I am a {Type} that carries {Passengers} passenger, travels at a speed of {Speed}mph and I have {Wheels} wheels.";
        }

        public override string UsedFor()
        {
            return $"I travel on the {TravelMethod}.";
        }
    }
}
