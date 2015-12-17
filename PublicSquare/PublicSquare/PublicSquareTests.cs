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
            int cubicalStone = CalculateCubicalStoneQuantity(4, 4, 2, 2);
            Assert.AreEqual(4, cubicalStone);
        }
        [TestMethod]
        public void NotPerfectSquareTest()
        {
            int cubicalStone = CalculateCubicalStoneQuantity(5, 5, 2, 2);
            Assert.AreEqual(9, cubicalStone);
        }

      
            int CalculateCubicalStoneQuantity(int publicSquareLength, int publicSquareWidth, int stoneLength, int stoneWidth)
        {
            if ((publicSquareLength % stoneLength) != 0) {
                publicSquareLength = publicSquareLength + stoneLength;
            }
            if ((publicSquareWidth % stoneWidth) != 0)
            {
                publicSquareWidth = publicSquareWidth + stoneWidth;
            }
            return (publicSquareLength / stoneLength) * (publicSquareWidth / stoneWidth);
        }
    }
}
