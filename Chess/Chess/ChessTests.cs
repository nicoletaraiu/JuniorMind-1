using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Chess
{
    [TestClass]
    public class ChessTests
    {
        [TestMethod]
        public void TwoByTwoTable()
        {
            int squaresNumber = CalculateSquaresNumber(2);
            Assert.AreEqual(5, squaresNumber);
        }
        int CalculateSquaresNumber (int side)
        {
            int squaresNumber = 0;
            while (side != 0)
            {
                squaresNumber = squaresNumber + side * side;
                side = side - 1;
            }
            return squaresNumber;
        }
    }
}
