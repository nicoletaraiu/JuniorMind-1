using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz
{
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod]
        public void FizzBuzz()
        {
            Assert.AreEqual("Fizz", VerifyFizz(3));
        }
        string VerifyFizz(int n)
        {
            string output = "";
            if (n % 3 == 0) output = "Fizz";
            return output;
            ///else if (n % 5 == 0) output = "Buzz";
            
        }
        }
    }

