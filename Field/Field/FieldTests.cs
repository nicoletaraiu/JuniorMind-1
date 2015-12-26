using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Field
{
    [TestClass]
    public class FieldTests
    {
        [TestMethod]
        public void InitialAreaForASimpleScenario()
        {
            float initialArea = CalculateInitialArea(2, 6);
            Assert.AreEqual(4, initialArea);
        }
        float CalculateInitialArea (int newWidth, int finalArea)
        {
            return 0;
        }
    }
}
