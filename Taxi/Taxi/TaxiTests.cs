using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Taxi
{
    [TestClass]
    public class TaxiTests
    {
        [TestMethod]
        public void FirstDayTest()
        {
            int cost = CalculateCost(8, 15);
            Assert.AreEqual(75, cost);
        }
        [TestMethod]
        public void SecondDayTest()
        {
            int cost = CalculateCost(10, 35);
            Assert.AreEqual(280, cost);
        }
       [TestMethod]
        public void ImpossibleScenarioTest()
        {
            int cost = CalculateCost(25, 10);
            Assert.AreEqual(0, cost);
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
        bool IsInRange (int daytime, int smallestLimit, int highestLimit)
        {
            bool b = true;
            if ((daytime >= smallestLimit) && (daytime <= highestLimit))
                b = true;
            else b = false;
            return b;
        }
        bool IsInDistanceRange (int distance, int smallestLimit, int highestLimit)
        {
            bool b = true;
            if ((distance >= smallestLimit) && (distance <= highestLimit))
                b = true;
            else b = false;
            return IsInDistanceRange (distance, smallestLimit, highestLimit);
        }
        int CalculateCost(int daytime, int distance)
        {
            int cost = 0;
            if ((IsInRange(daytime, 8, 21) == true)) 
                {
                    if ((IsInDistanceRange (distance, 1, 20))) cost = 5;
                    else if ((IsInDistanceRange (distance, 21, 60))) cost = 8;
                    else if ((distance >= 60)) cost = 6;
                } 
            else if ((IsInRange (daytime, 1, 7)) || ((IsInRange (daytime, 21, 24))))
            {
                if ((IsInDistanceRange (distance, 1, 20))) cost = 7;
                else if ((IsInDistanceRange (distance, 21, 60))) cost = 10;
                else if ((distance >= 60)) cost = 8;
            }
            else return 0;
            return cost * distance;
        }
    }
}
