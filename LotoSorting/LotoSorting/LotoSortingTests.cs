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
