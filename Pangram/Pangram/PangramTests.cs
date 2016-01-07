using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Pangram
{
    [TestClass]
    public class PangramTests
    {
        [TestMethod]
        public void FirstTest()
        {
            Assert.AreEqual(true, IsPangram("The quick brown fox jumps over the lazy dog"));
        }
        [TestMethod]
        public void SecondTest()
        {
            Assert.AreEqual(false, IsPangram("Not Pangram"));
        }
        bool IsPangram(string word) {
            char[] letters = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            int[] numbers = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            /// string allLetters = new string(letters);
            char[] newString = word.ToCharArray();
            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < 26; j++)
                {
                    if (newString[i] == letters[j])
                        numbers[j] = numbers[j] + 1;
                }
            }
           int counter = 0;
            for (int i = 0; i < 26; i++)
            {
                if (numbers[i] == 0)
                    counter++; 
            }
            if (counter == 0)
                return true;
            else return false;
        }
    }
}
