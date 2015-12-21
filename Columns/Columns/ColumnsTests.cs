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
        [TestMethod]
        public void SecondArea()
        {
            float area = CalculateArea(2, 2, 3, 3, 1, 2);
            Assert.AreEqual(0.5, area);
        }
        [TestMethod]
        public void NegativeDeterminantTry()
        {
            float area = CalculateArea(7, 6, 3, 4, 2, 5);
            Assert.AreEqual(3, area);
        }
         float CalculateArea(float Xa, float Ya, float Xb, float Yb, float Xc, float Yc)
        { 
            float determinant = Xa * Yb + Xb * Yc + Ya * Xc - Yb * Xc - Yc * Xa - Ya * Xb;
            float positiveDeterminant = Math.Abs(determinant);
            float area = 0.5f * positiveDeterminant;
            return area;
        } 
    }
}
