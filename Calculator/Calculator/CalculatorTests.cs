using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void ShouldReturnOne()
        {
            Assert.AreEqual(1, Compute("1"));
        }

        double Compute(string s)
        {
            double result = 0;
            if (double.TryParse(s, out result))
                return result;
            return result;
        }
    }
}
