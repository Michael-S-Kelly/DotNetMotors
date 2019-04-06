using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMotors.Classes
{
    /// <summary>
    /// This impliments the TravelMethod and Speed property.  It also creates a new abstract property; GroundUse.
    /// </summary>
    public abstract class Ground : Vehicles
    {
        public override int Speed { get; set; } = 60;
        public override string TravelMethod { get; set; } = "ground";
        public abstract string GroundUse { get; set; }
    }
}
