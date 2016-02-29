using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Password
{
    [TestClass]
    public class PasswordTests
    {
        [TestMethod]
        public void CheckTheNumberOfUppercaseCharacters()
        {
            var password = GetUppercase(new PasswordSettings(5, 2, 1, 2));
            Assert.AreEqual(true, Count(password, 2));
        }
        [TestMethod]
        public void CheckTheNumberOfDigits()
        {
            var password = GetDigits(new PasswordSettings(16, 5, 8, 3));
            Assert.AreEqual(true, Count(password, 8));
        }
        [TestMethod]
        public void CheckTheNumberOfSymbols()
        {
            var password = GetSymbols(new PasswordSettings(18, 2, 3, 13));
            Assert.AreEqual(true, Count(password, 13));
        }
        [TestMethod]
        public void CheckTheLengthOfThePassword()
        {
            var password = GetPassword(new PasswordSettings(23, 10, 5, 8));
            Assert.AreEqual(true, Count(password, 23));
        }
        [TestMethod]
        public void ShouldCountLowercaseCharacters()
        {
            var password = GetPassword(new PasswordSettings(25, 5, 4, 3));
            Assert.AreEqual(13, CountLowercase(password));
        }
        [TestMethod]
        public void ShouldCountLowercaseChars()
        {
            var password = GetPassword(new PasswordSettings(15, 2, 1, 3));
            Assert.AreEqual(9, CountLowercase(password));
        }
        [TestMethod]
        public void MoreComplexTest()
        {
            var password = GetPassword(new PasswordSettings(50, 10, 20, 5));
            Assert.AreEqual(true, Count(password, 50));
            var uppercase = GetUppercase(new PasswordSettings(50, 10, 20, 5));
            Assert.AreEqual(true, Count(uppercase,10));
            var digits = GetDigits(new PasswordSettings(50, 10, 20, 5));
            Assert.AreEqual(true, Count(digits, 20));
            var symbols = GetSymbols(new PasswordSettings(50, 10, 20, 5));
            Assert.AreEqual(true, Count(symbols, 5));
            Assert.AreEqual(15, CountLowercase(password));
        }
       

        public struct PasswordSettings
        {
            public int chosenLength;
            public int uppercaseLetters;
            public int digits;
            public int symbols;

            public PasswordSettings(int chosenLength, int uppercaseLetters, int digits, int symbols)
            {
                this.chosenLength = chosenLength;
                this.uppercaseLetters = uppercaseLetters;
                this.digits = digits;
                this.symbols = symbols;
            }
        }

        static Random random = new Random();
        public static char ReturnRandomUppercaseLetter()
        {   
            int number = random.Next(0, 26);
            char letter = (char)('A' + number);
            return letter;
        }

        public static char ReturnRandomSymbol()
        {
            string symbols = "!@#$%^&*()-=_+[{}];:'<,>.?/";
            int i = random.Next(0, symbols.Length - 1);
            return symbols[i];
        }

        public static int ReturnRandomDigit()
        {
            int digit = random.Next(0, 9);
            return digit;
        }

         string GetUppercase(PasswordSettings password)
        {
            string uppercaseString = string.Empty;
                for (int i = 0; i < password.uppercaseLetters; i++)
                {
                    uppercaseString += ReturnRandomUppercaseLetter();
                }
            return uppercaseString;
        }

        string GetDigits(PasswordSettings password)
        {
            string digitString = string.Empty;
            for (int i = 0; i < password.digits; i++)
            {
                digitString += ReturnRandomDigit();
            }
            return digitString;
        }

        string GetSymbols(PasswordSettings password)
        {
            string symbols = string.Empty;
            for (int i = 0; i < password.symbols; i++)
            {
                symbols += ReturnRandomSymbol();
            }
            return symbols;
        }

        string GetPassword(PasswordSettings password)
        {
            int lowercase = password.chosenLength - password.uppercaseLetters - password.digits - password.symbols;
            string neededPassword = string.Empty;
            for (int i = 0; i < lowercase; i ++)
            {
                neededPassword += (char)('a' + random.Next(0, 26));
            }
            neededPassword += GetUppercase(password) + GetDigits(password) + GetSymbols(password);
            return neededPassword;
        }

        int CountLowercase(string password)
        {
            int counter = 0;
            foreach (char c in password)
            {
                if (Char.IsLower(c))
                    counter++;
            }
            return counter;
        }

        bool Count(string password, int toBeCounted)
        {
            return (password.Length == toBeCounted);
        }
    }
}
