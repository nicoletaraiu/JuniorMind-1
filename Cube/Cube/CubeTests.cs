using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cube
{
    [TestClass]
    public class CubeTests
    {
        [TestMethod]
        public void lastThreeDigitsCheckPass()
        {
            Assert.AreEqual(true, IsEightEightEight(45888));
        }
        [TestMethod]
        public void lastThreeDigitsCheckFail()
        {
            Assert.AreEqual(false, IsEightEightEight(45788));
        }
        [TestMethod]
        public void lastThreeDigitsCheckFail2()
        {
            Assert.AreEqual(false, IsEightEightEight(88));
        }
        [TestMethod]
        public void ExtractOurNumber()
        {
            int number = ourNumber(1);
            Assert.AreEqual(192, number);
        }
        [TestMethod]
        public void ExtractTheSecondNumber()
        {
            int number = ourNumber(2);
            Assert.AreEqual(442, number);
        }
        bool IsEightEightEight (int number)
        {
            return ((((number % 1000) / 100) == 8) && (((number % 100) / 10) == 8) && ((number % 10) == 8));      
        }
        int ourNumber (int k)
        {
            int number = 0;
            int allNumbers = 0;
            while (allNumbers < k)
            {
                number++;
                if (IsEightEightEight(number * number * number))
                    allNumbers++;
            }
            return number;
        }
        
    }
}
