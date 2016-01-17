using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExcelColumns
{
    [TestClass]
    public class ExcelColumnsTests
    {
        [TestMethod]
        public void FirstColumnTest()
        {
            Assert.AreEqual("A", FinalColumn(1));
        }
        [TestMethod]
        public void FourthColumnTest()
        {
            Assert.AreEqual("D", FinalColumn(4));
        }
        [TestMethod]
        public void LastColumnOfTheFirstSetTest()
        {
            Assert.AreEqual("Z", FinalColumn(26));
        }
        [TestMethod]
        public void Column27Test()
        {
            Assert.AreEqual("AA", FinalColumn(27));
        }
        [TestMethod]
        public void Column52Test()
        {
            Assert.AreEqual("AZ", FinalColumn(52));
        }
        string WantedColumn (int position)
        {
            return ((char)('A' + position)).ToString();
        }
        string FinalColumn(int columnNumber)
        {
            string column = "";
            while (columnNumber > 0)
            {
                columnNumber = columnNumber - 1;
                column += WantedColumn((columnNumber % 26));
                columnNumber /= 26;
            }
            return column;
        }
    }
}
