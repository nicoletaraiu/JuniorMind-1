using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RentalCosts
{
    [TestClass]
    public class RentalCostsTests
    {
        [TestMethod]
        public void OneDayLate()
        {
            float totalCost = CalculatePenalty(100, 1);
            Assert.AreEqual(102, totalCost);
        }
        [TestMethod]
        public void SevenDaysLate()
        {
            float totalCost = CalculatePenalty(100, 7);
            Assert.AreEqual(114, totalCost);
        }
        [TestMethod]
        public void FifteenDaysLate()
        {
            float totalCost = CalculatePenalty(253, 15);
            Assert.AreEqual(442.75, totalCost);
        }
        [TestMethod]
        public void ThirtySixDaysLate()
        {
            float totalCost = CalculatePenalty(450, 36);
            Assert.AreEqual(2070, totalCost);
        }
        [TestMethod]
        public void FortyFiveDaysLate()
        {
            float totalCost = CalculatePenalty(100, 45);
            Assert.AreEqual(0, totalCost);
        }
       bool IsInRange (int additionalDays, int smallestLimit, int highestLimit)
        {
            bool b = false;
            if ((additionalDays >= smallestLimit) && (additionalDays <= highestLimit))
                b = true;
            else b = false;
            return b;
        }


        float CalculatePenalty(float monthlyCost, int additionalDays)
        {
            float penaltyPercentage = 0;
            if (IsInRange(additionalDays, 1, 10) == true)
                penaltyPercentage = 0.02f; 
            else if (IsInRange(additionalDays, 11, 30) == true)
                penaltyPercentage = 0.05f;
            else if (IsInRange(additionalDays, 31, 40) == true)
                penaltyPercentage = 0.1f;
            else return 0;
            float penalty = monthlyCost * additionalDays * penaltyPercentage;
            return (float)(monthlyCost + penalty);
        }
    }
}
