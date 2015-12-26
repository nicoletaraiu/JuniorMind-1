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
        string VerifyDivisibility(int n)
        {
            string output = "";
            if ((n >= 4) && (n % 2 == 0)) output = "DA";
            else output = "NU"; 
            return output;
        }
    }
}
