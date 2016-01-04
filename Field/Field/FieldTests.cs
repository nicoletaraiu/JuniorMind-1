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
            float initialArea = CalculateInitialArea(1, 6);
            Assert.AreEqual(2, initialArea);
        }
        float CalculateInitialArea (int newWidth, int finalArea)
        {
            
            double solution1 = 0;
            /// finalArea = initialWidth * initialWidth + newWidth * initialWidth;
            int discriminant = newWidth * newWidth + 4 * finalArea;
            if (discriminant > 0)
            {
                solution1 = (- newWidth + Math.Sqrt(discriminant)) / 2;
                return (float)solution1;
            }
            else return 0;
        }
    }
}
