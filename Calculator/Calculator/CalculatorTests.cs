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
            int i = 0;
            Assert.AreEqual(1, Compute("1", ref i));
        }
        [TestMethod]
        public void ShouldReturn12()
        {
            int i = 0;
            Assert.AreEqual(12, Compute("* 3 4", ref i));
        }

        double Compute(string s, ref int i)
        {
            string[] elements = s.Split(' ');
            string currentElement = elements[i++];

            double result = 0;
            if (double.TryParse(currentElement, out result))
            {
                return result;
            }

            switch (currentElement)
            {
                case "+": return Compute(s, ref i) + Compute(s, ref i);
                case "-": return Compute(s, ref i) - Compute(s, ref i);
                case "*": return Compute(s, ref i) * Compute(s, ref i);
                default: return Compute(s, ref i) / Compute(s, ref i);
            }
        }
    }
}
