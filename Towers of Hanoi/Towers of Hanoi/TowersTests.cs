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
            CollectionAssert.AreEqual(Generate(3), TOH(3, Generate(3), new int[3], new int[3]));
            CollectionAssert.AreEqual(Generate(4), TOH(4, Generate(4), new int[4], new int[4]));
            CollectionAssert.AreEqual(Generate(7), TOH(7, Generate(7), new int[7], new int[7]));
        }
        [TestMethod]
        public void SixtyThree()
        {
            CollectionAssert.AreEqual(Generate(63), TOH(63, Generate(63), new int[63], new int[63]));
        }
        [TestMethod]
        public void TheSpecialOne()
        {
            CollectionAssert.AreEqual(Generate(64), TOH(64, Generate(64), new int[64], new int[64]));
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
