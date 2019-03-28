using System;
using Xunit;
using DotNetMotors.Classes;

namespace DotNetMotors_TDD
{
    public class UnitTest1
    {
        //[Fact]
        public void TestFishingBoatCatchPhrase()
        {
            string phrase = FishingBoat.CatchPhrase();
            Assert.Equal("A day of fishing is better than a day at work", phrase);
        }

        //[Fact]
        public void TestRecreationalBoatCatchPhrase()
        {
            string phrase = RecreationalBoat.CatchPhrase();
            Assert.Equal("Fishing is too much work, I'd rather Relax", phrase);
        }

        //[Fact]
        public void TestWaterInheritanceThroughRecreationalBoat()
        {
            string phrase = RecreationalBoat.UsedFor();
            Assert.Equal("I travel on the water and I'm used to relax.", phrase);
        }

        //[Fact]
        public void TestVehicleInheritanceThroughMotorcycle()
        {
            string phrase = Motorcycle.Description();
            Assert.Equal("I am a Motorcycle that carries 1 passenger, travels at a speed of 60mph and I have 2 wheels.", phrase);
        }

        //[Fact]
        public void TestISteeringWheelInheritanceThroughSudan()
        {
            string phrase = Sudan.Description();
            Assert.Equal("I am a Sudan Car that carries 4 passengers, travels at a speed of 60mph and I have 4 wheels.  It is true that I have a steering wheel to control me.", phrase);
        }

        //[Fact]
        public void TestIPropellerInheritanceThroughRecreationalBoat()
        {
            string phrase = Sudan.Description();
            Assert.Equal("I am a Recreational Boat that carries 8 passengers and travel at a speed of 15mph.  It is true that I have a steering wheel to control me.  I have 2 propellers to go and steer.", phrase);
        }

    }
}
