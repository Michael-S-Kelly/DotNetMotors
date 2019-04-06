using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMotors.Classes
{
    public class JetPlane : Plane
    {
        public override int Speed { get; set; } = 250;
        public override int Wheels { get; set; } = 5;
        public override string Type { get; set; } = "Prop Air Plane";

        public override string CatchPhrase()
        {
            return "I'm a puddle hopper.";
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
