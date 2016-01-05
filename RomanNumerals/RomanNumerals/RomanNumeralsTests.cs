using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RomanNumerals
{
    [TestClass]
    public class RomanNumeralsTests
    {
        [TestMethod]
        public void FirstTest()
        {
            string roman = ConvertArabicToRoman(1);
            Assert.AreEqual("I", roman);
        }
        string ConvertArabicToRoman(int arabic)
        {
            string output = "";
            if (arabic == 1) output = "I";
            return output;
        }
    }
}
