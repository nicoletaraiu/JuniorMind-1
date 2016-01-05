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
            if ((additionalDays >= 1) && (additionalDays <= 10))
                penalty = (float)0.02 * monthlyCost * additionalDays;
            else if ((additionalDays >= 11) && (additionalDays <= 30))
                penalty = (float)0.05 * monthlyCost * additionalDays;
            else if ((additionalDays >= 31) && (additionalDays <= 40))
                penalty = (float)0.1 * monthlyCost * additionalDays;
            else return 0;
            return (float)(monthlyCost + penalty);
        }
    }
}
