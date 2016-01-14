using System;
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
        [TestMethod]
        public void SecondOddsTest()
        {
            double odds = CalculateOdds(3, 3, 6);
            Assert.AreEqual(0.05, odds);
        }
        [TestMethod]
        public void FactorialZero()
        {
            Assert.AreEqual(1, CalculateFactorial(0));
        }
        [TestMethod]
        public void SixOutOfFortyNine()
        {
            double odds = CalculateOdds(6, 6, 49);
            Assert.AreEqual(0.0000000715, odds);
        }
        double CalculateFactorial(int number)
        {
            double factorial = 1;
            while (number > 0)
            {
                factorial *= number;
                number--;
            }
            return factorial;
        }
        double CalculateCombinations(int firstNumber, int secondNumber)
        {
            double combinations = (CalculateFactorial(firstNumber) / (CalculateFactorial(secondNumber) * (CalculateFactorial(firstNumber - secondNumber))));
            return combinations;
        }
        double CalculateOdds(int matchingNumbers, int numbersOnTicket, int totalNumbers)
        {
            double odds = ((CalculateCombinations(numbersOnTicket, matchingNumbers) * CalculateCombinations((totalNumbers - numbersOnTicket), (numbersOnTicket - matchingNumbers))) / CalculateCombinations(totalNumbers, numbersOnTicket));
            return odds;
        }
    }
}
