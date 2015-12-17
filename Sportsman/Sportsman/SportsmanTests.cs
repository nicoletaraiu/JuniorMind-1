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
        [TestMethod]
        public void ThirtysixRepetitions()
        {
            int repetitionsNumber = CalculateRepetitionsNumber(6);
            Assert.AreEqual(36, repetitionsNumber);
        }
        [TestMethod]
        public void FourHundredRepetitions()
        {
            int repetitionsNumber = CalculateRepetitionsNumber(20);
            Assert.AreEqual(400, repetitionsNumber);
        }
        int CalculateRepetitionsNumber(int top)
        {
            return top * top;
        }
    }
}
