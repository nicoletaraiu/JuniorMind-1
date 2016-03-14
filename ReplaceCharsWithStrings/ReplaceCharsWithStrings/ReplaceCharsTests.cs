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
            Assert.AreEqual("abcghief", Replace("abcde", 'd', "ghi"));
        }

       public string ReplaceChar(string s)
        {
            string previous = string.Empty;
            return ReplaceChar(s, ref previous);
        }

        public string ReplaceChar(string s, char toReplace, string toReplaceWith, ref string previous)
        {
            
        }
 

    }
}
