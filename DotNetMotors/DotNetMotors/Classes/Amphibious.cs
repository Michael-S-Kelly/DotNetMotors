using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMotors.Classes
{
    class Amphibious : Water
    {
        public override string WaterUse { get; set; } = "to have fun";
        public override int Passengers { get; set; } = 4;
        public override int Wheels { get; set; } = 4;
        public override int Speed { get; set; } = 30;
        public override string Type { get; set; } = "Amphibious Vehicle";

        public override string CatchPhrase()
        {
            return "Water or Land, I travel on both.";
        }

        public override string Description()
        {
            return $"I am a {Type} that carries {Passengers} passengers, travels at a speed of {Speed}mph and I have {Wheels} wheels.";
        }

        public override string UsedFor()
        {
            return $"I travel on the {TravelMethod} and I'm used {WaterUse}.";
        }
    }
}
