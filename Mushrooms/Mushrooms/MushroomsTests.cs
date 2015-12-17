using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mushrooms
{
    [TestClass]
    public class MushroomsTests
    {
        [TestMethod]
        public void RedMushrooms()
        {
            int redMushrooms = CalculateRedMushrooms(99, 2);
            Assert.AreEqual(66, redMushrooms);
        }

        [TestMethod]
        public void MoreRedMushrooms()
        {
            int redMushrooms = CalculateRedMushrooms(453, 7);
            Assert.AreEqual(392, redMushrooms);
        }

        int CalculateRedMushrooms(int total, int ratio)
        {
            int white = total / (ratio + 1);
            return white * ratio;
        }
    }
}
