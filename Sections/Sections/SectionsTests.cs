using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sections
{
    [TestClass]
    public class SectionsTests
    {
        [TestMethod]
        public void FindTheEndOfTheSection()
        {
            Assert.AreEqual(new Point(0, 1), FindTheEndOfTheSection(new Point(0, 0), new Instructions(true, false, false, false)));
        }

        public struct Instructions
        {
            public bool up;
            public bool down;
            public bool right;
            public bool left;
          
            public Instructions(bool up, bool down, bool right, bool left)
            {
                this.up = up;
                this.down = down;
                this.right = right;
                this.left = left;
            }
        }
          
        public struct Point
        {
            public int x;
            public int y;

            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        static Point FindTheEndOfTheSection(Point point, Instructions instructions)
        {

            if (instructions.up) point.y += 1;
            if (instructions.down) point.y -= 1;
            if (instructions.right) point.x += 1;
            if (instructions.left) point.x -= 1;
            return point;
        }
    }
}
