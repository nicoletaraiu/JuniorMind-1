using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Columns
{ 
    [TestClass]
    public class ColumnsTests
    {
        [TestMethod]
        public void FirstArea()
        {
        float area = CalculateArea(1, 1, 1, 1, 1, 1);
        Assert.AreEqual(0, area);
        }
         float CalculateArea(float firstX, float firstY, float secondX, float secondY, float thirdX, float thirdY)
        {
            return 0;
        }
    }
}
