using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Password
{
    [TestClass]
    public class PasswordTests
    {
        [TestMethod]
        public void CheckTheLength()
        {
            Assert.AreEqual(true, CheckTheLength(ReturnNeededPassword(15, 10), 15, 10));
        }

        public struct Password
        {
            public int lowercaseLetters;
            public int uppercaseLetters;
            public int digits;

            public Password(int lowercaseLetters, int uppercaseLetters, int digits)
            {
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

        public static char ReturnRandomLowerCaseLetter()
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

        static string ReturnNeededPassword(int chosenLength, int howManyUppercaseLetters)
        {
            int howManyLowercaseLetters = chosenLength - howManyUppercaseLetters;
            string neededPassword = string.Empty;
                for (int i = 0; i < chosenLength; i++)
                {
                    neededPassword += ReturnRandomUppercaseLetter();
                }
                while (howManyLowercaseLetters > 0)
            { 
                    neededPassword += ReturnRandomLowerCaseLetter();
                howManyLowercaseLetters--;
            }
            return neededPassword;
        }

        static bool CheckTheLength(string password, int chosenLength, int howManyUppercaseLetters)
        {
            string neededPassword = ReturnNeededPassword(chosenLength, howManyUppercaseLetters);
            return (neededPassword.Length == chosenLength);
        }

    }
}
