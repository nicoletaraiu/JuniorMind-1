using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sections
{
    [TestClass]
    public class SectionsTests
    {
        [TestMethod]
        public void EightSections() { 
            var firstIntersection = new Section(0, 1);
            var sections = new Section[] {
             new Section(0, 1),
             new Section(1, 0),
             new Section(1, 0),
             new Section(0, 1),
             new Section(-1, 0),
             new Section(0, 1),
             new Section(-1, 0),
             new Section(0, -1),
             new Section(0, -1) };
            Assert.AreEqual(firstIntersection, GetSection(sections));
        }

        public struct Section
        {
            public int x;
            public int y;
          
            public Section(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        public Section GetSection(Section[] sections)
        {
            int totalX = 0;
            int totalY = 0;
            for (int i = 0; i < sections.Length; i++)
            {
                totalX += sections[i].x;
                totalY += sections[i].y;
            }
            return new Section(totalX, totalY);
        }

    }
}
