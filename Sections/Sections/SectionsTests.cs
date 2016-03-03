using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sections
{
    [TestClass]
    public class SectionsTests
    {
        [TestMethod]
        public void ShouldReturnTheEndOfTheSection()
        { 
            Assert.AreEqual(new Point(0, 1), FindTheEndOfTheSection(new Point(0, 0), new Instructions[] { new Instructions(true, false, false, false)}));
            Assert.AreEqual(new Point(1, 4), FindTheEndOfTheSection(new Point(2, 3), new Instructions[] { new Instructions(true, false, false, true) }));
        }
        [TestMethod]
        public void ShouldReturnTheFirstIntersection()
        {
            Assert.AreEqual(new Point(0, 1), FindTheEndOfTheSection(new Point(0, 0), new Instructions[] {
                new Instructions(true, false, false, false),
                new Instructions(false, false, true, false),
                new Instructions(true, false, false, false),
                new Instructions(false, false, false, true),
                new Instructions(false, true, false, false),
                new Instructions(true, false, false, false),
                new Instructions(false, false, true, false)}));
        }
        [TestMethod]
        public void ShouldReturnFirstPoint()
        {
            Assert.AreEqual(new Point(0, 0), FindTheEndOfTheSection(new Point(0, 0), new Instructions[]
            {
                new Instructions(false, false, true, false),
                new Instructions(true, false, false, false),
                new Instructions(false, false, false, true),
                new Instructions(false, true, false, false) }));
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

            static Point FindTheEndOfTheSection(Point point, Instructions[] instructions)
            {
            Point[] savedPoints = new Point[instructions.Length];
            for (int i = 0; i < instructions.Length; i++)
            {
                
                if (instructions[i].up) point.y += 1;
                if (instructions[i].down) point.y -= 1;
                if (instructions[i].right) point.x += 1;
                if (instructions[i].left) point.x -= 1;
                savedPoints[i] = new Point(point.x, point.y);
                if (point.x == savedPoints[i].x && point.y == savedPoints[i].y)
                    break;

            }
            return point;
            }
        }
    }
