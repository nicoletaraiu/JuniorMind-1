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
            var password = ReturnNeededPassword(new Password(5, 2, 1));
            Assert.AreEqual(true, CheckTheLength(password, 5));
        }

        public struct Password
        {
            public int chosenLength;
            public int uppercaseLetters;
            public int digits;

            public Password(int chosenLength, int uppercaseLetters, int digits)
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

         string ReturnNeededPassword(Password password)
        {
            string neededPassword = string.Empty;
                for (int i = 0; i < password.chosenLength; i++)
                {
                    neededPassword += ReturnRandomUppercaseLetter();
                }
            return neededPassword;
        }

         bool CheckTheLength(string password, int chosenLength)
        {
            return (password.Length == chosenLength);
        }

    }
}
