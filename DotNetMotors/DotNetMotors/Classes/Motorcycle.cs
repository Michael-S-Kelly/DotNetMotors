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

        /// <summary>
        /// Defines the catch phrase
        /// </summary>
        /// <returns>catch phrase</returns>
        public override string CatchPhrase()
        {
            return "Born to be Wild!";
        }

        /// <summary>
        /// Defines the Description
        /// </summary>
        /// <returns>Description</returns>
        public override string Description()
        {
            return $"I am a {Type} that carries {Passengers} passenger, travels at a speed of {Speed}mph and I have {Wheels} wheels.";
        }

        /// <summary>
        /// Defines what it is used for
        /// </summary>
        /// <returns>Used for</returns>
        public override string UsedFor()
        {
            return $"I travel on the {TravelMethod}.";
        }
    }
}
