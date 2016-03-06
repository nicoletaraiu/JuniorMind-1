using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cyclometer
{
    [TestClass]
    public class CyclometerTests
    {
        [TestMethod]
        public void ShouldReturnOneRotation()
        {
            Assert.AreEqual(2.198, CalculateRotationDistance(0.7));
        }

        double CalculateRotationDistance(double diameter)
        {
            double distance = 3.14 * diameter;
            return distance;
        }

    }
}
