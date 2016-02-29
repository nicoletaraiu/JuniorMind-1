using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sections
{
    [TestClass]
    public class SectionsTests
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        public struct Intersection
        {
            public int up;
            public int down;
            public int right;
            public int left;

            public Intersection(int up, int down, int right, int left)
            {
                this.up = up;
                this.down = down;
                this.right = right;
                this.left = left;
            }
        }

    }
}
