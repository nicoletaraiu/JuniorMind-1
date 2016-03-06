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
            Assert.AreEqual(5.652, CalculateRotationDistance(new Bike[] {
            new Bike(0.7),
            new Bike(0.6),
            new Bike(0.5)}));
        }

        public struct Bike {
            public double diameter;

            public Bike(double diameter)
            {
                this.diameter = diameter;
            }
        }

        double CalculateRotationDistance(Bike[] bikes)
        {
            double totalDistance = 0;
            for (int i = 0; i < bikes.Length; i++)
            {
                totalDistance += 3.14 * bikes[i].diameter;
            }
            return totalDistance;
        }

    }
}
