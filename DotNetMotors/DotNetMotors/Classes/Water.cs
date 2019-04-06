using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMotors.Classes
{
    /// <summary>
    /// This impliments the TravelMethod property and creates a abstract WaterUse property.
    /// </summary>
    public abstract class Water : Vehicles
    {
        public override string TravelMethod { get; set; } = "water";
        public abstract string WaterUse { get; set; }

    }
}
