using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Loto
{
    [TestClass]
    public class LotoTests
    {
        [TestMethod]
        public void FactorialTest()
        {
            Assert.AreEqual(120, CalculateFactorial(5));
        }
        float CalculateFactorial(int number)
        {
            int factorial = 1;
            while (number > 0)
            {
                factorial *= number;
                number--;
            }
            return factorial;
        }
    }
}
