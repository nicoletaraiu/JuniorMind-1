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
        int CalculateRedMushrooms(int total, int ratio)
        {
            int white = total / (ratio + 1);
            return white * ratio;
        }
    }
}
