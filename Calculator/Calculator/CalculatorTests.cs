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
        [TestMethod]
        public void ShouldReturn12()
        {
            Assert.AreEqual(12, Compute("* 3 4"));
        }

        double Compute(string s)
        {
            string[] elements = s.Split(' ');
            int i = 0;
            return Compute(elements, ref i);
        }

        double Compute(string[] elements, ref int i)
        {
            string currentElement = elements[i++];
            double result = 0;
            if (double.TryParse(currentElement, out result))
            {
                return result;
            }

            switch (currentElement)
            {
                case "+": return Compute(elements, ref i) + Compute(elements, ref i);
                case "-": return Compute(elements, ref i) - Compute(elements, ref i);
                case "*": return Compute(elements, ref i) * Compute(elements, ref i);
                default: return Compute(elements, ref i) / Compute(elements, ref i);
            }
        }
    }
}
