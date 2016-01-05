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
            int cost = CalculateCost(10, 35);
            Assert.AreEqual(280, cost);
        }
        [TestMethod]
        public void FirstNightTest()
        {
            int cost = CalculateCost(7, 10);
            Assert.AreEqual(70, cost);
        }
        [TestMethod]
        public void SecondNightTest()
        {
            int cost = CalculateCost(23, 41);
            Assert.AreEqual(410, cost);
        }
        [TestMethod]
        public void ThirdNightTest()
        {
            int cost = CalculateCost(1, 80);
            Assert.AreEqual(640, cost);
        }
        int CalculateCost(int daytime, int distance)
        {
            int cost = 0;
            if ((daytime >= 8) && (daytime <= 21))
            {
                if ((distance >= 1) && (distance <= 20)) cost = 5;
                else if ((distance >= 21) && (distance <= 60)) cost = 8;
                else if ((distance >= 60)) cost = 6;
            } 
            else {
                if ((distance >= 1) && (distance <= 20)) cost = 7;
                else if ((distance >= 21) && (distance <= 60)) cost = 10;
                else if ((distance >= 60)) cost = 8;
             }
            return cost * distance;
        }
    }
}
