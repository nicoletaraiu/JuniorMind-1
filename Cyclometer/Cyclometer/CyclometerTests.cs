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
            Assert.AreEqual(5.652, CalculateTotalDistance(new Cyclist[] {
            new Cyclist("Ion", 0.7),
            new Cyclist("Gheorghe", 0.6),
            new Cyclist("Raul", 0.5)}));
        }

        public struct Cyclist {
            public string name;
            public double diameter;

            public Cyclist(string name, double diameter)
            {
                this.name = name;
                this.diameter = diameter;
            }
        }

        double CalculateTotalDistance(Cyclist[] bikes)
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
