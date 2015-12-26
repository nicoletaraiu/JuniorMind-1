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
            Assert.AreEqual("Fizz", VerifyFizzBuzz(3));
        }
        [TestMethod]
        public void Buzz()
        {
            Assert.AreEqual("Buzz", VerifyFizzBuzz(5));
        }
        [TestMethod]
        public void FizzBuzz()
        {
            Assert.AreEqual("FizzBuzz", VerifyFizzBuzz(15));
        }
        string VerifyFizzBuzz(int n)
        {
            string output = "";
            if (n % 3 == 0) output = "Fizz";
            if (n % 5 == 0) output = "Buzz";
            if ((n % 3 == 0) && (n % 5 == 0)) output = "FizzBuzz";
            return output;
        } 
        }
    }

