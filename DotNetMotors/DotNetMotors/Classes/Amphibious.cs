using DotNetMotors.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMotors.Classes
{
    public class Amphibious : Water, ISteeringWheel, IPropeller
    {
        public override string WaterUse { get; set; } = "to have fun";
        public override int Passengers { get; set; } = 4;
        public override int Wheels { get; set; } = 4;
        public override int Speed { get; set; } = 30;
        public override string Type { get; set; } = "Amphibious Vehicle";
        public bool SteeringWheel { get; set; } = true;
        public string Propellers { get; set; } = "I have 2 propellers to go and steer on water.";


        /// <summary>
        /// Defines the catch phrase
        /// </summary>
        /// <returns>catch phrase</returns>
        public override string CatchPhrase()
        {
            return "Water or Land, I travel on both.";
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
            return $"I travel on the {TravelMethod} and I'm used {WaterUse}.";
        }
    }
}
