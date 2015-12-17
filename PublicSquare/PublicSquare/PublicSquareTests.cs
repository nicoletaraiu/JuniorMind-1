using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PublicSquare
{
    [TestClass]
    public class PublicSquareTests
    {
        [TestMethod]
        public void PerfectSquareTest()
        {
            float cubicalStone = CalculateCubicalStoneQuantity(4, 4, 2, 2);
            Assert.AreEqual(4, cubicalStone);
        }
        float CalculateCubicalStoneQuantity(int publicSquareLength, int publicSquareWidth, int stoneLength, int stoneWidth)
        {
            return (publicSquareLength / stoneLength) * (publicSquareWidth / stoneWidth);
        }
    }
}
