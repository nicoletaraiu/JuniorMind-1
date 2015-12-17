using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sportsman
{
    [TestClass]
    public class SportsmanTests
    {
        [TestMethod]
        public void SixteenRepetitions()
        {
            int repetitionsNumber = CalculateRepetitionsNumber(4);
            Assert.AreEqual(16, repetitionsNumber);
        }
        int CalculateRepetitionsNumber(int top)
        {
            return top * top;
        }
    }
}
