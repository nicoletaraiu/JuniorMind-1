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
            Assert.AreEqual(true, EndsWithEightEightEight(45888));
        }
        [TestMethod]
        public void lastThreeDigitsCheckFail()
        {
            Assert.AreEqual(false, EndsWithEightEightEight(45788));
        }
        [TestMethod]
        public void lastThreeDigitsCheckFail2()
        {
            Assert.AreEqual(false, EndsWithEightEightEight(88));
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
        [TestMethod]
        public void ExtractTheThirdNumber()
        {
            int number = ourNumber(3);
            Assert.AreEqual(692, number);
        }
        [TestMethod]
        public void ExtractTheFourthNumber()
        {
            int number = ourNumber(4);
            Assert.AreEqual(942, number);
        }
        bool EndsWithEightEightEight (int number)
        {
            return (number % 1000 == 888);      
        }
        int ourNumber (int k)
        {
            int number = 0;
            int allNumbers = 0;
            while (allNumbers < k)
            {
                number++;
                if (EndsWithEightEightEight(number * number * number))
                    allNumbers++;
            }
            return number;
        }
        
    }
}
