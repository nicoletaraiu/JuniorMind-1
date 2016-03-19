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

        int[] Sort(int[] winningnumbers)
        {
            return winningnumbers;
        }
    }
}
