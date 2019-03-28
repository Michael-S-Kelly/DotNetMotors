using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMotors
{
    abstract class Vehicles
    {
        public abstract int Passengers { get; set; }
        public abstract int Speed { get; set; }
        public abstract string TravelMethod { get; set; }
        public virtual int Wheels { get; set; }
        public abstract string Type { get; set; }

        public abstract string CatchPhrase();
        public abstract string Description();
        public abstract string UsedFor();
    }
}
