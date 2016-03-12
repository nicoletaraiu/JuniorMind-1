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

        public int[] Triangle(int n)
        {
            int[] previous = new int[n - 1];
            return Triangle(n, ref previous);
        }

        public int[] Triangle(int n, ref int[] previous)
        {
            int[] result = new int[n];
            result[0] = 1;
            result[result.Length - 1] = 1;
            if (n < 3) return result;
            previous = Triangle(n - 1);
            for (int i = 1; i < previous.Length; i++)
            {
                result[i] = previous[i - 1] + previous[i];
            }
            return result;
        }

    }
}
