using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Password
{
    [TestClass]
    public class PasswordTests
    {
        [TestMethod]
        public void CheckTheLengthOfUppercasePassword()
        {
            var password = GetUppercase(new PasswordSettings(5, 2, 1));
            Assert.AreEqual(true, CheckTheLength(password, 5));
        }
        [TestMethod]
        public void CheckTheLengthOfDigitsString()
        {
            var password = GetDigits(new PasswordSettings(10, 5, 8));
            Assert.AreEqual(true, CheckTheLength(password, 10));
        }
       

        public struct PasswordSettings
        {
            public int chosenLength;
            public int uppercaseLetters;
            public int digits;

            public PasswordSettings(int chosenLength, int uppercaseLetters, int digits)
            {
                this.chosenLength = chosenLength;
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
                for (int i = 0; i < password.chosenLength; i++)
                {
                    uppercaseString += ReturnRandomUppercaseLetter();
                }
            return uppercaseString;
        }

        string GetDigits(PasswordSettings password)
        {
            string digitString = string.Empty;
            for (int i = 0; i < password.chosenLength; i++)
            {
                digitString += ReturnRandomDigit();
            }
            return digitString;
        }

        string GetLowercase(PasswordSettings password)
        {
            string lowercaseString = string.Empty;
            for (int i = 0; i < password.chosenLength; i++)
            {
                lowercaseString += ReturnRandomLowercaseLetter();
            }
            return lowercaseString;
        }

        bool CheckTheLength(string password, int chosenLength)
        {
            return (password.Length == chosenLength);
        }
    }
}
