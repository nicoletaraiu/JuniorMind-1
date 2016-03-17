using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Towers_of_Hanoi
{
    [TestClass]
    public class TowersTests
    {
        [TestMethod]
        public void MoreTests()
        {
            CollectionAssert.AreEqual(new int[] { 3, 2, 1 }, TOH(3, new int[] { 3, 2, 1 }, new int[3], new int[3]));
            CollectionAssert.AreEqual(new int[] { 4, 3, 2, 1 }, TOH(4, new int[] { 4, 3, 2, 1 }, new int[4], new int[4]));
            CollectionAssert.AreEqual(new int[] { 7, 6, 5, 4, 3, 2, 1 }, TOH(7, new int[] { 7, 6, 5, 4, 3, 2, 1, 0 }, new int[7], new int[7]));
        }
        [TestMethod]
        public void ShouldGenerateNumbersArray()
        {
            CollectionAssert.AreEqual(new int[] { 5, 4, 3, 2, 1 }, Generate(5));
            CollectionAssert.AreEqual(new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 }, Generate(10));
        }

        static int[] TOH(int disks, int[] A, int[] B, int[] C)
        {
            if (disks == 1)
            {
                return Move(disks, A, C);
            }
            else
            {
                TOH(disks - 1, A, B, C);
                Move(disks, A, C);
                TOH(disks - 1, B, C, A);
            }
            return C;
        }

        static int[] Move(int diskNumber, int[] from, int[] to)
        {
            to[diskNumber - 1] = from[diskNumber - 1];
            Array.Resize(ref from, from.Length - 1);
            return from;
        }

        static int[] Generate(int numbers)
        {
            int keeper = numbers;
            int[] generated = new int[numbers];
            for (int i = 0; i < keeper; i++)
            {
                generated[i] = numbers;
                numbers--;
            }
            return generated;
        }
    }
}
