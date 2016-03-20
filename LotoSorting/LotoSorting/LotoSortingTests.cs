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
            CollectionAssert.AreEqual(new int[] { 10, 19, 30, 39, 40, 49 }, Sort(new int[] { 30, 40, 39, 49, 10, 19 }));
            CollectionAssert.AreEqual(new int[] { 1, 2, 3, 4, 5, 6 }, Sort(new int[] { 5, 3, 1, 6, 4, 2 }));
            CollectionAssert.AreEqual(new int[] { 10, 20, 30, 40, 41, 42 }, Sort(new int[] { 42, 41, 40, 30, 10, 20 }));
        }

        int[] Sort(int[] winningNumbers)
        {
            for (int i = 0; i < winningNumbers.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (winningNumbers[j - 1] > winningNumbers[j])
                        Swap(ref winningNumbers[j - 1], ref winningNumbers[j]);
                }
            }
            return winningNumbers;
        }

        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
