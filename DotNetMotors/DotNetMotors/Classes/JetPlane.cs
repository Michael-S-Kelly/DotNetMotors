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

        /// <summary>
        /// Defines the catch phrase
        /// </summary>
        /// <returns>catch phrase</returns>
        public override string CatchPhrase()
        {
            return "I'm a puddle hopper.";
        }

        /// <summary>
        /// Defines the Description
        /// </summary>
        /// <returns>Description</returns>
        public override string Description()
        {
            return $"I am a {Type} that carries {Passengers} passengers, travels at a speed of {Speed}mph and I have {Wheels} wheels.";
        }

        /// <summary>
        /// Defines what it is used for
        /// </summary>
        /// <returns>Used for</returns>
        public override string UsedFor()
        {
            return $"I travel in the {TravelMethod}.";
        }
    }
}
