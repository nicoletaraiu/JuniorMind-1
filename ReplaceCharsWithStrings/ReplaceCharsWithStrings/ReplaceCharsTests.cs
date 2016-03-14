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
            string result = 
            if (s.Length < 2) return s;
            foreach (char c in s)
                if (c == toReplace)
                {
                    Array.Resize(ref result, result.Length + toReplaceWith.Length);

                }
        }
 

    }
}
