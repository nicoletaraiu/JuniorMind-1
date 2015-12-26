using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Melon
{
    [TestClass]
    public class MelonTests
    {
        [TestMethod]
        public void FourKilosMelon()
        {
            Assert.AreEqual("DA", VerifyDivisibility(4));
        }
        [TestMethod]
        public void NineKilosMelon()
        {
            Assert.AreEqual("NU", VerifyDivisibility(9));
        }
        [TestMethod]
        public void FifteenKilosMelon()
        {
            Assert.AreEqual("NU", VerifyDivisibility(15));
        }
        [TestMethod]
        public void SmallerThanFourWeight()
        {
            Assert.AreEqual("NU", VerifyDivisibility(3));
        }
        string VerifyDivisibility(int weight)
        {
            string output = "";
            if ((weight >= 4) && (weight % 2 == 0)) output = "DA";
            else output = "NU"; 
            return output;
        }
    }
}
