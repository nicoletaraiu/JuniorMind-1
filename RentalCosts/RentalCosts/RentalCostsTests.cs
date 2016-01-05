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
        float CalculatePenalty(float monthlyCost, int additionalDays)
        {
            float penalty = 0;
            if ((additionalDays >= 1) && (additionalDays <= 10))
                penalty = (float)0.02 * monthlyCost;
            else if ((additionalDays >= 11) && (additionalDays <= 30))
                penalty = (float)0.05 * monthlyCost;
            else if ((additionalDays >= 31) && (additionalDays <= 40))
                penalty = (float)0.1 * monthlyCost;
            return (float)(monthlyCost + penalty);
        }
    }
}
