using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Anagram
{
    [TestClass]
    public class AnagramTests
    {
        [TestMethod]
        public void ThreeLettersWord()
        {
            Assert.AreEqual(6, (CalculateAnagramsNumber("abc")));
        }
        [TestMethod]
        public void FourLettersWord()
        {
            Assert.AreEqual(24, (CalculateAnagramsNumber("abcd")));
        }
        [TestMethod]
        public void FiveLettersWord()
        {
            Assert.AreEqual(120, (CalculateAnagramsNumber("abcde")));
        }
        int CalculateAnagramsNumber(string word)
        {
            int anagramsNumber = word.Length;
            for (int i = 1; i < word.Length; i++)
            {
                anagramsNumber = anagramsNumber * i;
            }
            return anagramsNumber;
        }
        
    }
}
