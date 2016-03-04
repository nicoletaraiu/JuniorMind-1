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
           /* Assert.AreEqual(new Point(0, 1), FindTheFirstIntersection(new Point(0, 0), new Instructions[] { new Instructions(true, false, false, false)}));
            Assert.AreEqual(new Point(1, 4), FindTheFirstIntersection(new Point(2, 3), new Instructions[] { new Instructions(true, false, false, true) })); */
        }
        [TestMethod]
        public void ShouldReturnTheFirstIntersection()
        {
           /* Assert.AreEqual(new Point(0, 1), FindTheFirstIntersection(new Point(0, 0), new Instructions[] {
                new Instructions(true, false, false, false),
                new Instructions(false, false, true, false),
                new Instructions(true, false, false, false),
                new Instructions(false, false, false, true),
                new Instructions(false, true, false, false),
                new Instructions(true, false, false, false),
                new Instructions(false, false, true, false)})); */
        }
        [TestMethod]
        public void ShouldReturnFirstPoint()
        {
           /* Assert.AreEqual(new Point(0, 0), FindTheFirstIntersection(new Point(0, 0), new Instructions[]
            {
                new Instructions(false, false, true, false),
                new Instructions(true, false, false, false),
                new Instructions(false, false, false, true),
                new Instructions(false, true, false, false),
                new Instructions(false, false, false, true)})); */
        }
        [TestMethod]
        public void CheckPresence()
        {
            Assert.AreEqual(true, CheckPresence(new Point(1, 0), new Point[] { new Point(2, 0), new Point(1, 0), new Point(1, 1) }));
            Assert.AreEqual(false, CheckPresence(new Point(1, 0), new Point[] { new Point(2, 0), new Point(1, 0), new Point(1, 1) }));
        }


        public enum Instructions
        {
            up,
            down,
            right,
            left
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

            static Point FindTheFirstIntersection(Point point, Instructions[] instructions)
            {
            Point[] savedPoints = new Point[instructions.Length];
            for (int i = 0; i < instructions.Length; i++)
            {
                if (instructions[i] == Instructions.up) savedPoints[i].y += 1;
                if (instructions[i] == Instructions.down) savedPoints[i].y -= 1;
                if (instructions[i] == Instructions.right) savedPoints[i].x += 1;
                if (instructions[i] == Instructions.left) savedPoints[i].x -= 1;
                savedPoints[i] = new Point(point.x, point.y);
            }
            return point;
            }
           static bool CheckPresence(Point point, Point[] savedPoints)
        {
            return true;
        }
        }
    }
