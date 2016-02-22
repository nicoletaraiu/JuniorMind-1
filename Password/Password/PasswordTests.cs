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
            Assert.AreEqual(true, CheckTheLength(ReturnNeededPassword(3), 3));
        }

        public struct Password
        {
            public string lowercaseLetters;
            public string uppercaseLetters;
            public string digits;

            public Password(string lowercaseLetters, string uppercaseLetters, string digits)
            {
                this.lowercaseLetters = lowercaseLetters;
                this.uppercaseLetters = uppercaseLetters;
                this.digits = digits;
            }
        }

        static Random random = new Random();
        public static char ReturnRandomLowercaseLetter()
        {   
            int number = random.Next(0, 26);
            char letter = (char)('a' + number);
            return letter;
        }

        static char[] ReturnNeededPassword(int number)
        {
            char[] neededPassword = new char[number]; ;
            for (int i = 0; i < neededPassword.Length; i++)
            {
                neededPassword[i] = ReturnRandomLowercaseLetter();
            }
            return neededPassword;
        }
        static bool CheckTheLength(char[] password, int number)
        {
            char[] neededPassword = ReturnNeededPassword(number);
            return (neededPassword.Length == number);
        }

    }
}
