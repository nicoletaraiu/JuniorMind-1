﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Loto
{
    [TestClass]
    public class LotoTests
    {
        [TestMethod]
        public void FactorialTest()
        {
            Assert.AreEqual(120, CalculateFactorial(5));
        }
        [TestMethod]
        public void CombinationsTest()
        {
            Assert.AreEqual(4, CalculateCombinations(4, 3));
        }
        [TestMethod]
        public void OddsTest()
        {
            double odds = CalculateOdds(1, 1, 4);
            Assert.AreEqual(0.25, odds);
        }
        int CalculateFactorial(int number)
        {
            int factorial = 1;
            while (number > 0)
            {
                factorial *= number;
                number--;
            }
            return factorial;
        }
        float CalculateCombinations(int firstNumber, int secondNumber)
        {
            int combinations = (CalculateFactorial(firstNumber) / (CalculateFactorial(secondNumber) * (CalculateFactorial(firstNumber - secondNumber))));
            return combinations;
        }
        double CalculateOdds(int matchingNumbers, int numbersOnTicket, int totalNumbers)
        {
            double odds = ((CalculateCombinations(numbersOnTicket, matchingNumbers) * CalculateCombinations((totalNumbers - numbersOnTicket), (numbersOnTicket - matchingNumbers))) / CalculateCombinations(totalNumbers, numbersOnTicket));
            return odds;
        }
    }
}
