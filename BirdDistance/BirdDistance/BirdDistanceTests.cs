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
        public void BirdDistanceForAGreaterDecimalDistance()
        {
            decimal birdDistance = CalculateBirdDistance(350, 1345.78m);
            Assert.AreEqual(672.89m, birdDistance);
        }
        decimal CalculateBirdDistance(decimal trainSpeed, decimal distanceBetweenTrains)
        {
            return distanceBetweenTrains / 2;
        }

        
    }
}
