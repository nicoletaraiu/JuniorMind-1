using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Strings
{
    [TestClass]
    public class StringsTests
    {
        [TestMethod]
        public void FirstTest()
        {
            string prefix = StringComparison("aaab", "aaaabbaa");
            Assert.AreEqual("aaa", prefix);
        }
        [TestMethod]
        public void SecondTest()
        {
            string prefix = StringComparison("abcdefgh", "abceefgh");
            Assert.AreEqual("abc", prefix);
        }
        [TestMethod]
        public void ThirdTest()
        {
            string prefix = StringComparison("animalemici", "animalemari");
            Assert.AreEqual("animalem", prefix);
        }
        string StringComparison(string firstString, string secondString)
        {
            string prefix = "";
            for (int i = 0; i < firstString.Length; i++)
            {
                if (firstString[i] == secondString[i])
                {

                    prefix = prefix + firstString[i];
                }
                else break;
            }
            return prefix;
        }
    }
}

