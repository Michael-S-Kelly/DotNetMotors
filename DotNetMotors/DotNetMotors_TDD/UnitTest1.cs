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
    }
}
