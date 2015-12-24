using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz
{
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod]
        public void Fizz()
        {
            int result = VerifyFizz(3);
            Assert.AreEqual(0, result);
        }
        int VerifyFizz(int n)
        {
            return (n%3);
        }

        
    }
}
