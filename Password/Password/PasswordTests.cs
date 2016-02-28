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
            var password = GetUppercase(new PasswordSettings(7, 2, 2, 1, 2));
            Assert.AreEqual(true, CheckTheLength(password, 2));
        }
        [TestMethod]
        public void CheckTheNumberOfDigits()
        {
            var password = GetDigits(new PasswordSettings(21, 5, 5, 8, 3));
            Assert.AreEqual(true, CheckTheLength(password, 8));
        }
        [TestMethod]
        public void ChechTheNumberOfLowercaseCharacters()
        {
            var password = GetLowercase(new PasswordSettings(22, 4, 12, 1, 5));
            Assert.AreEqual(true, CheckTheLength(password, 12));
        }
        [TestMethod]
        public void CheckTheNumberOfSymbols()
        {
            var password = GetSymbols(new PasswordSettings(20, 2, 2, 3, 13));
            Assert.AreEqual(true, CheckTheLength(password, 13));
        }
        [TestMethod]
        public void CheckTheLengthOfThePassword()
        {
            var password = GetPassword(new PasswordSettings(28, 10, 5, 5, 8));
            Assert.AreEqual(true, CheckTheLength(password, 28));
        }
        
       

        public struct PasswordSettings
        {
            public int chosenLength;
            public int lowercaseLetters;
            public int uppercaseLetters;
            public int digits;
            public int symbols;

            public PasswordSettings(int chosenLength, int uppercaseLetters, int lowercaseLetters, int digits, int symbols)
            {
                this.chosenLength = chosenLength;
                this.lowercaseLetters = lowercaseLetters;
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

        public static char ReturnRandomLowercaseLetter()
        {
            int number = random.Next(0, 26);
            char letter = (char)('a' + number);
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

        string GetLowercase(PasswordSettings password)
        {
            string lowercaseString = string.Empty;
            for (int i = 0; i < password.lowercaseLetters; i++)
            {
                lowercaseString += ReturnRandomLowercaseLetter();
            }
            return lowercaseString;
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
            string neededPassword = string.Empty;
            neededPassword += GetUppercase(password) + GetLowercase(password) + GetDigits(password) + GetSymbols(password);
            return neededPassword;
        }

        bool CheckTheLength(string password, int chosenLength)
        {
            return (password.Length == chosenLength);
        }
    }
}
