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

        public string ReplaceChar(string s, char toReplace, string toReplaceWith)
        {
            return s;
        }

    }
}
