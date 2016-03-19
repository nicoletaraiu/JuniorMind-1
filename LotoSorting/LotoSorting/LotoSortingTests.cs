using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LotoSorting
{
    [TestClass]
    public class LotoSortingTests
    {
        [TestMethod]
        public void ShouldReturnSortedArray()
        {
            CollectionAssert.AreEqual(new int[] { 49, 40, 39, 30, 19, 10 }, Sort(new int[] { 30, 40, 39, 49, 10, 19 }));
        }
        [TestMethod]
        public void ShouldReturnLargestNumber()
        {
            Assert.AreEqual(49, GetLargest(new int[] { 30, 40, 39, 49, 10, 19 }));
            Assert.AreEqual(50, GetLargest(new int[] { 42, 50, 49, 38 }));
        }

        int[] Sort(int[] winningNumbers)
        {
            int[] sorted = new int[winningNumbers.Length];
            return sorted;
        }

        int GetLargest(int[] winningNumbers)
        {
            int largest = winningNumbers[0];
            for (int i = 1; i < winningNumbers.Length; i++)
            {
                if (winningNumbers[i] > largest)
                    largest = winningNumbers[i];
            }
            return largest;
        }
    }
}
