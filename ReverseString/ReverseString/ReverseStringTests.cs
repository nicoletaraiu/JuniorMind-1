using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ReverseString
{
    [TestClass]
    public class ReverseStringTests
    {
        [TestMethod]
        public void FiveLetters()
        {
            Assert.AreEqual("edcba", ReverseString("abcde"));
        }
        [TestMethod]
        public void ThreeLetters()
        {
            Assert.AreEqual("cba", ReverseString("abc"));
        }
        [TestMethod]
        public void TwoLetters()
        {
            Assert.AreEqual("ba", ReverseString("ab"));
        }
        [TestMethod]
        public void MoreLetters()
        {
            Assert.AreEqual("eugaeL snoipmahC", ReverseString("Champions League"));
        }

        public string ReverseString(string word)
        {
            string previous = string.Empty;
            return ReverseString(word, ref previous);
        }

        public string ReverseString(string word, ref string previous)
        {
            
            if (word.Length > 0)
                return word[word.Length - 1] + ReverseString(word.Substring(0, word.Length - 1));
            return word;
        }

    }
}
