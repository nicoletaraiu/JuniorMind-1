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
        string WantedColumn (int position)
        {
            return ((char)('A' + position - 1)).ToString();
        }
    }
}
