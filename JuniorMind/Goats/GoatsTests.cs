using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Goats
{
    [TestClass]
    public class GoatsTests
    {
        [TestMethod]
        public void TwoGoatsOneDay()
        {
            int resultedKilos = CalculateHayAmount(1, 1, 1, 2, 1);
            Assert.AreEqual(2, resultedKilos);
        }

        [TestMethod]
        public void FourGoatsTwoDays()
        {
            int resultedKilos = CalculateHayAmount(1, 1, 1, 4, 2);
            Assert.AreEqual(8, resultedKilos);
        }

        int CalculateHayAmount(int InitialGoats, int initialKilos, int initialDays, int newGoats, int newDays)
        {
            return (newGoats * initialKilos * newDays) / (InitialGoats * initialDays);
        }
    }
}
