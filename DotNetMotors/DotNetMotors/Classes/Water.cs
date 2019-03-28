using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMotors.Classes
{
    public abstract class Water : Vehicles
    {
        public override string TravelMethod { get; set; } = "water";
        public abstract string WaterUse { get; set; }

    }
}
