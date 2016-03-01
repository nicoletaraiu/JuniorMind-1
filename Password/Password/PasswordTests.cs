﻿using System;
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
            var password = GetPassword(new PasswordSettings(50, 10, 20, 5), "l1Io0O");
            Assert.AreEqual(true, Count(password, 50));
            var uppercase = GetUppercase(new PasswordSettings(50, 10, 20, 5), "l1Io0O");
            Assert.AreEqual(true, Count(uppercase,10));
            var digits = GetDigits(new PasswordSettings(50, 10, 20, 5), "l1Io0O");
            Assert.AreEqual(true, Count(digits, 20));
            var symbols = GetSymbols(new PasswordSettings(50, 10, 20, 5), "{}[]()/\'~,;.<>\"");
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

        public static int ReturnRandomCharacter(int lowerBound, int upperBound)
        {
            return random.Next(lowerBound, upperBound);
        }

        public static char ReturnRandomUppercaseLetter()
        {
            return (char)(ReturnRandomCharacter('A', 'Z'));
        }

        public static char ReturnRandomSymbol()
        {
            string symbols = "!@#$%^&*()-=_+[{}];:'<,>.?/";
            int i = random.Next(0, symbols.Length - 1);
            return symbols[i];
        }

        public static int ReturnRandomDigit()
        {
            return ReturnRandomCharacter(0, 9);
        }

         string GetUppercase(PasswordSettings password, string similar = "l1Io0O")
        {
            string uppercaseString = string.Empty;
            int i = 0;
            while (i < password.uppercaseLetters)
            {
                char randomUppercase = (char)ReturnRandomCharacter('A', 'Z');
                var doesContain = similar.Contains(randomUppercase.ToString());
                if (!doesContain)
                {
                    uppercaseString += randomUppercase;
                    i++;
                }
            }
            return uppercaseString;
        }

        string GetDigits(PasswordSettings password, string similar = "l1Io0O")
        {
            string digitString = string.Empty;
            int i = 0;
            while (i < password.digits)
            {
                int randomDigit = ReturnRandomCharacter(0, 9);
                var doesContain = similar.Contains(randomDigit.ToString());
                if (!doesContain)
                {
                    digitString += randomDigit;
                    i++;
                }
            }
            return digitString;
        }

        string GetSymbols(PasswordSettings password, string ambiguous = "{}[]()/\'~,;.<>\"")
        {
            string symbols = string.Empty;
            int i = 0;
            while (i < password.symbols)
            {
                char randomSymbol = ReturnRandomSymbol();
                var doesContain = ambiguous.Contains(randomSymbol.ToString());
                if (!doesContain)
                {
                    symbols += randomSymbol;
                    i++;
                }
            }
            return symbols;
        }

        string GetPassword(PasswordSettings password, string similar = "l1Io0O")
        {
            int lowercase = password.chosenLength - password.uppercaseLetters - password.digits - password.symbols;
            string neededPassword = string.Empty;
            int i = 0;
            while (i < lowercase)
            {
                char randomLowercase = (char)ReturnRandomCharacter('a', 'z');
                var doesContain = similar.Contains(randomLowercase.ToString());
                if (!doesContain)
                {
                    neededPassword += randomLowercase;
                    i++;
                }
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
