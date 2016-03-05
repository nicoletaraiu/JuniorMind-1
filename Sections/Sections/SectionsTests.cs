using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sections
{
    [TestClass]
    public class SectionsTests
    {
        [TestMethod]
        public void ShouldReturnTheFirstIntersection()
        {
            Assert.AreEqual(new Point(0, 1), FindTheFirstIntersection(new Point(0, 0), new Instructions[] {
                Instructions.up,
                Instructions.right,
                Instructions.up,
                Instructions.left,
                Instructions.down,
                Instructions.up,
                Instructions.right})); 
        }
        [TestMethod]
        public void ShouldReturnTheSecondPoint()
        {
            Assert.AreEqual(new Point(1, 1), FindTheFirstIntersection(new Point(0, 1), new Instructions[] {
                Instructions.right,
                Instructions.up,
                Instructions.down,
                Instructions.left}));
        }
        [TestMethod]
        public void ShouldReturnTheThirdPoint()
        {
            Assert.AreEqual(new Point(4, 2), FindTheFirstIntersection(new Point(2, 2), new Instructions[] {
                Instructions.right,
                Instructions.right,
                Instructions.right,
                Instructions.left,
                Instructions.up}));
        }
        [TestMethod]
        public void ShouldReturnFirstPoint()
        {
            Assert.AreEqual(new Point(0, 0), FindTheFirstIntersection(new Point(0, 0), new Instructions[]
            {
                Instructions.right,
                Instructions.up,
                Instructions.left,
                Instructions.down,
                Instructions.left})); 
        }
        [TestMethod]
        public void CheckPresence()
        {
            Assert.AreEqual(true, CheckPresence(new Point(1, 0), new Point[] { new Point(2, 0), new Point(1, 0), new Point(1, 1), new Point(1,0) }));
            Assert.AreEqual(false, CheckPresence(new Point(1, 0), new Point[] { new Point(2, 0), new Point(1, 3), new Point(1, 1) }));
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
                
                if (instructions[i] == Instructions.up) point.y += 1;
                if (instructions[i] == Instructions.down) point.y -= 1;
                if (instructions[i] == Instructions.right) point.x += 1;
                if (instructions[i] == Instructions.left) point.x -= 1;
                savedPoints[i] = point;
                if (CheckPresence(point, savedPoints))
                    return point;
            }
            return point;
            }

           static bool CheckPresence(Point point, Point[] savedPoints)
        {
            int counter = 0;
            foreach (var x in savedPoints)
            {
                if (point.x == x.x && point.y == x.y)
                    counter++;
            }
            return (counter > 1);
        }
        }
    }
