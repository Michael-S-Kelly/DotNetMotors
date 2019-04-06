using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMotors.Classes
{
    /// <summary>
    /// This impliments the TravelMethod property
    /// </summary>
    public abstract class Air : Vehicles
    {
        public override string TravelMethod { get; set; } = "Air";
    }
}
