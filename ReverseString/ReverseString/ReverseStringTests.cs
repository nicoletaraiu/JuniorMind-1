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
            Assert.AreEqual("", ReverseString("Champions League"));
        }

        public string ReverseString(string word)
        {
            string previous = string.Empty;
            return ReverseString(word, ref previous);
        }

        public string ReverseString(string word, ref string previous)
        {
            string reversed = string.Empty;
            if (word.Length < 2) return word;
            int length = word.Length;
            while (length > 0)
            {
                reversed += word[length - 1] + ReverseString(previous);
                length--;
            }
            return reversed;
        }

    }
}
