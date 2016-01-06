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
        float CalculatePenalty(float monthlyCost, int additionalDays)
        {
            float penalty = 0;
            float smallPenalty = 0.02f * monthlyCost * additionalDays;
            float mediumPenalty = 0.05f * monthlyCost * additionalDays;
            float highPenalty = 0.1f * monthlyCost * additionalDays;
            if ((additionalDays >= 1) && (additionalDays <= 10))
                penalty = smallPenalty;
            else if ((additionalDays >= 11) && (additionalDays <= 30))
                penalty = mediumPenalty;
            else if ((additionalDays >= 31) && (additionalDays <= 40))
                penalty = highPenalty;
            else return 0;
            return (float)(monthlyCost + penalty);
        }
    }
}
