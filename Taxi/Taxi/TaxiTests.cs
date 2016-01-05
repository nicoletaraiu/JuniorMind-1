using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Taxi
{
    [TestClass]
    public class TaxiTests
    {
        [TestMethod]
        public void FirstSimpleTest()
        {
            int cost = CalculateCost(8, 15);
            Assert.AreEqual(75, cost);
        }
        [TestMethod]
        public void SecondSimpleTest()
        {
            int cost = CalculateCost(8, 35);
            Assert.AreEqual(140, cost);
        }
        int CalculateCost(int daytime, int distance)
        {
            int cost = 0;
           
            {
                if ((distance >= 1) && (distance <= 20)) cost = 5;
                else if ((distance >= 21) && (distance <= 60)) cost = 4;
                else if ((distance >= 60)) cost = 3;
                return cost * distance;
            }
           
        }
    }
}
