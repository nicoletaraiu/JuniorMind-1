using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ReplaceCharsWithStrings
{
    [TestClass]
    public class ReplaceCharsTests
    {
        [TestMethod]
        public void FirstTest()
        {
            Assert.AreEqual("abcghief", ReplaceChar("abcde", 'd', "ghi"));
        }
        [TestMethod]
        public void SecondTest()
        {
            Assert.AreEqual("JuniorMind", ReplaceChar("Juniormind", 'm', "M"));
        }
        [TestMethod]
        public void ShouldReturnTheOtherChar()
        {
            Assert.AreEqual("nopq", ReplaceChar("m", 'm', "nopq"));
        }
        [TestMethod]
        public void ShouldReturnTheString()
        {
            Assert.AreEqual("m", ReplaceChar("m", 'n', "o"));
        }

        public string ReplaceChar(string s, char toReplace, string toReplaceWith)
        {
            if (s.Length < 2)
            {
                if (s[0] == toReplace) return toReplaceWith.ToString();
                else return s;
            }
            return s[0] + ReplaceChar(s.Substring(1, s.Length - 1), toReplace, toReplaceWith);
        }

    }
}
