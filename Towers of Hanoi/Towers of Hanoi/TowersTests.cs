using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Towers_of_Hanoi
{
    [TestClass]
    public class TowersTests
    {
        [TestMethod]
        public void ThreeDiscs()
        {
            CollectionAssert.AreEqual(new int[] { 3, 2, 1 }, TOH(3, new int[] { 3, 2, 1 }, new int[3], new int[3]));
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
                TOH(disks - 1, B, A, C);
            }
            return C;
        }

        static int[] Move(int diskNumber, int[] from, int[] to)
        {
            to[diskNumber - 1] = from[diskNumber - 1];
            Array.Resize(ref from, from.Length - 1);
            return from;
        }
    }
}
