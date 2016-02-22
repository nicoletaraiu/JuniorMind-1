using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Password
{
    [TestClass]
    public class PasswordTests
    {
        [TestMethod]
        public void TestMethod1()
        {
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

        static Password ReturnNeededPassword(int number)
        {
            string[] neededPassword = new string[10]; ;
            for (int i = 0; i < neededPassword.Length; i++)
            {
                neededPassword[i].lowercaseLetters = ReturnRandomLowercaseLetter;
            }
        }
    }
}
