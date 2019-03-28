using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMotors.Classes
{
    abstract class Air : Vehicles
    {
        public override string TravelMethod { get; set; } = "Air";
    }
}
