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
            Assert.AreEqual("A", WantedColumn(1));
        }
        [TestMethod]
        public void FourthColumnTest()
        {
            Assert.AreEqual("D", WantedColumn(4));
        }
        [TestMethod]
        public void LastColumnOfTheFirstSetTest()
        {
            Assert.AreEqual("Z", WantedColumn(26));
        }
        [TestMethod]
        public void Column27Test()
        {
            Assert.AreEqual("AA", WantedColumn(27));
        }
        string WantedColumn (int position)
        {
            return ((char)('A' + position - 1)).ToString();
        }
        string FinalColumn(int columnNumber)
        {
            string column = "";
            while (columnNumber > 0)
            {   
                column += WantedColumn((columnNumber % 26));
                columnNumber /= 26;
            }
            return column;
        }
    }
}
