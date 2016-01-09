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
        [TestMethod]
        public void TrickyWord()
        {
            Assert.AreEqual(3, (CalculateAnagramsNumber("aab")));
        }
        [TestMethod]
        public void SecondTrickyWord()
        {
            Assert.AreEqual(20, (CalculateAnagramsNumber("aabac")));
        }
        int CalculateAnagramsNumber(string word)
        {
            int allOccurrences = 1;
            for (int i = 'a'; i <= 'z'; i++)
            {
                allOccurrences *= Factorial(CalculateOccurrencesNumber((char)i, word));
            }
            return (Factorial(word.Length)) / allOccurrences;
        }
        int CalculateOccurrencesNumber(char letter, string word)
        {
            int occurrencesNumber = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (letter == word[i])
                    occurrencesNumber++;
            }
            return occurrencesNumber;
        }
        int Factorial (int number)
        {
            int result = 1;
            while (number > 0)
            {
                result *= number;
                number--;
            }
            return result;
        }
        }
    }

