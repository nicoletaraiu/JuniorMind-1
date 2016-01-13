using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cube
{
    [TestClass]
    public class CubeTests
    {
        [TestMethod]
        public void lastThreeDigitsCheck()
        {
            Assert.AreEqual(true, IsEightEightEight(45888));
        }
        
        bool IsEightEightEight (int result)
        {
            return (bool)((((result % 1000) / 100) == 8) && (((result % 100) / 10) == 8) && ((result % 10) == 8));      
        }

    }
}
