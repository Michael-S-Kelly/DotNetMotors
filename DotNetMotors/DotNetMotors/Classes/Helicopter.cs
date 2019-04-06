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

        /// <summary>
        /// Defines the catch phrase
        /// </summary>
        /// <returns>catch phrase</returns>
        public override string CatchPhrase()
        {
            return "I fly the friendly skies.";
        }

        /// <summary>
        /// Defines the Description
        /// </summary>
        /// <returns>Description</returns>
        public override string Description()
        {
            return $"I am a {Type} that carries {Passengers} passengers and travels at a speed of {Speed}mph.";
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
