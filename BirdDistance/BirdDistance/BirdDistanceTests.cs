using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BirdDistance
{
    [TestClass]
    public class BirdDistanceTests
    {
        [TestMethod]
        public void BirdDistanceForAHundredMetersBetweenTrains()
        {
            decimal birdDistance = CalculateBirdDistance(200, 100);
            Assert.AreEqual(50, birdDistance);
        }
        decimal CalculateBirdDistance(decimal trainSpeed, decimal distanceBetweenTrains)
        {
            return distanceBetweenTrains / 2;
        }

        
    }
}
