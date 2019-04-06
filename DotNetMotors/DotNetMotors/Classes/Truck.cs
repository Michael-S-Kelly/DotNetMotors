using DotNetMotors.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMotors.Classes
{
    public class Truck : Ground, ISteeringWheel
    {
        public override string GroundUse { get; set; } = "to work";
        public override int Passengers { get; set; } = 3;
        public override int Wheels { get; set; } = 4;
        public override string Type { get; set; } = "Truck";
        public bool SteeringWheel { get; set; } = true;

        /// <summary>
        /// Defines the catch phrase
        /// </summary>
        /// <returns>catch phrase</returns>
        public override string CatchPhrase()
        {
            return "I'm the work horse of America.";
        }

        /// <summary>
        /// Defines the Description
        /// </summary>
        /// <returns>Description</returns>
        public override string Description()
        {
            return $"I am a {Type} that carries {Passengers} passengers, travels at a speed of {Speed}mph and I have {Wheels} wheels.  It is {SteeringWheel} that I have a steering wheel to control me.";
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
