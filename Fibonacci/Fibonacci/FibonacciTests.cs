using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fibonacci
{
    [TestClass]
    public class FibonacciTests
    {
        [TestMethod]
        public void ShouldReturnFive()
        {
            Assert.AreEqual(13, Fibonacci(7));
            Assert.AreEqual(21, Fibonacci(8));
            Assert.AreEqual(34, Fibonacci(9));
        }

        public int Fibonacci(int number)
        {
            int previous = 0;
            return Fibonacci(number, ref previous);
        }
    
        public int Fibonacci(int number, ref int previous)
        {
            if (number < 2) return number;
            int beforePrevious = 0;
            previous = Fibonacci(number - 1, ref beforePrevious);
            return previous + beforePrevious;
        }
    }
}

