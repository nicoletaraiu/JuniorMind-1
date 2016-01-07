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
        int CalculateAnagramsNumber(string word)
        {
            int anagramsNumber = 0;
            int lettersNumber = 1;
            for (int i = 0; i <= word.Length; i++)
            {
                anagramsNumber += lettersNumber * i;
            }
            return anagramsNumber;
        }
        
    }
}
