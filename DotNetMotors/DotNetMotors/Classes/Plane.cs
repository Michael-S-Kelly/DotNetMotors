using DotNetMotors.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMotors.Classes
{
    /// <summary>
    /// Defines the property of the Passengers as 60.
    /// </summary>
    public abstract class Plane : Air
    {
        public override int Passengers { get; set; } = 60;
    }
}
