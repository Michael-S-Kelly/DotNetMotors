using System;
using Xunit;
using DotNetMotors.Classes;

namespace DotNetMotors_TDD
{
    public class UnitTest1
    {
        [Fact]
        public void TestFishingBoatCatchPhrase()
        {
            FishingBoat fishingBoat = new FishingBoat();
            string phrase = fishingBoat.CatchPhrase();
            Assert.Equal("A day of fishing is better than a day at work", phrase);
        }
        
        [Fact]
        public void TestRecreationalBoatCatchPhrase()
        {
            RecreationalBoat recreationalBoat = new RecreationalBoat();
            string phrase = recreationalBoat.CatchPhrase();
            Assert.Equal("Fishing is too much work, I'd rather Relax", phrase);
        }
        
        [Fact]
        public void TestWaterInheritanceThroughRecreationalBoat()
        {
            RecreationalBoat recreationalBoat = new RecreationalBoat();
            string phrase = recreationalBoat.UsedFor();
            Assert.Equal("I travel on the water and I'm used to relax.", phrase);
        }
        
        [Fact]
        public void TestVehicleInheritanceThroughMotorcycle()
        {
            Motorcycle motorcycle = new Motorcycle();
            string phrase = motorcycle.Description();
            Assert.Equal("I am a Motorcycle that carries 1 passenger, travels at a speed of 60mph and I have 2 wheels.", phrase);
        }

        [Fact]
        public void TestISteeringWheelInheritanceThroughSudan()
        {
            Sudan sudan = new Sudan();
            string phrase = sudan.Description();
            Assert.Equal("I am a Sudan Car that carries 4 passengers, travels at a speed of 60mph and I have 4 wheels.  It is True that I have a steering wheel to control me.", phrase);
        }

        [Fact]
        public void TestIPropellerInheritanceThroughRecreationalBoat()
        {
            RecreationalBoat recreationalboat = new RecreationalBoat();
            string phrase = recreationalboat.Description();
            Assert.Equal("I am a Recreational Boat that carries 8 passengers and travel at a speed of 15mph.  It is True that I have a steering wheel to control me.  I have 2 propellers to go and steer.", phrase);
        }
        
    }
}
