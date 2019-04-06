using DotNetMotors.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMotors.Classes
{
    public abstract class Plane : Air
    {
        public override int Passengers { get; set; } = 60;
    }
}
