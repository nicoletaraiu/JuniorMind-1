using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Pascal_s_triangle
{
    [TestClass]
    public class PascalTests
    {
        [TestMethod]
        public void SecondLine()
        {
            CollectionAssert.AreEqual(new int[] { 1, 1 }, Triangle(2));
        }
        [TestMethod]
        public void ThirdLine()
        {
            CollectionAssert.AreEqual(new int[] { 1, 2, 1 }, Triangle(3));
        }
        [TestMethod]
        public void FourthLine()
        {
            CollectionAssert.AreEqual(new int[] { 1, 3, 3, 1 }, Triangle(4));
        }
        [TestMethod]
        public void FifthLine()
        {
            CollectionAssert.AreEqual(new int[] { 1, 4, 6, 4, 1 }, Triangle(5));
        }
        [TestMethod]
        public void SixthLine()
        {
            CollectionAssert.AreEqual(new int[] { 1, 5, 10, 10, 5, 1 }, Triangle(6));
        }
        [TestMethod]
        public void SeventhLine()
        {
            CollectionAssert.AreEqual(new int[] { 1, 6, 15, 20, 15, 6, 1 }, Triangle(7));
        }

        public int[] Triangle(int n)
        {
            int[] result = new int[n];
            result[0] = 1;
            result[result.Length - 1] = 1;
            if (n < 3) return result;
            int[] previous = Triangle(n - 1);
            for (int i = 1; i < previous.Length; i++)
            {
                result[i] = previous[i - 1] + previous[i];
            }
            return result;
        }

    }
}
