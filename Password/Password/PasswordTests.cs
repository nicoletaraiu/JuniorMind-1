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
            var password = GetUppercase(new PasswordSettings(5, 2, 2, 1));
            Assert.AreEqual(true, CheckTheLength(password, 2));
        }
        [TestMethod]
        public void CheckTheNumberOfDigits()
        {
            var password = GetDigits(new PasswordSettings(18, 5, 5, 8));
            Assert.AreEqual(true, CheckTheLength(password, 8));
        }
        [TestMethod]
        public void ChechTheNumberOfLowercaseCharacters()
        {
            var password = GetLowercase(new PasswordSettings(17, 4, 12, 1));
            Assert.AreEqual(true, CheckTheLength(password, 12));
        }
        [TestMethod]
        public void CheckTheLengthOfThePassword()
        {
            var password = GetPassword(new PasswordSettings(20, 10, 5, 5));
            Assert.AreEqual(true, CheckTheLength(password, 20));
        }
        
       

        public struct PasswordSettings
        {
            public int chosenLength;
            public int lowercaseLetters;
            public int uppercaseLetters;
            public int digits;

            public PasswordSettings(int chosenLength, int uppercaseLetters, int lowercaseLetters, int digits)
            {
                this.chosenLength = chosenLength;
                this.lowercaseLetters = lowercaseLetters;
                this.uppercaseLetters = uppercaseLetters;
                this.digits = digits;
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

        string GetPassword(PasswordSettings password)
        {
            string neededPassword = string.Empty;
            neededPassword += GetUppercase(password) + GetLowercase(password) + GetDigits(password);
            return neededPassword;
        }

        bool CheckTheLength(string password, int chosenLength)
        {
            return (password.Length == chosenLength);
        }
    }
}
