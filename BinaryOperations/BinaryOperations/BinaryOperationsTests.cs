using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BinaryOperations
{
    [TestClass]
    public class BinaryOperationsTests
    {
        [TestMethod]
        public void CalculateArrayLengthTest()
        {
            Assert.AreEqual(6, (CalculateNeededArrayLength(49)));
        }
        [TestMethod]
        public void TransformIntoByteArrayTest()
        {
            Assert.AreEqual(110001, (TransformIntoByteArray(49)));
        }
         byte[] TransformIntoByteArray(byte number)
       {
           byte[] binaryVersion = new byte[CalculateNeededArrayLength(number)];
           while (number > 0)
           {
               binaryVersion[CalculateNeededArrayLength(number) - 1] = (byte)(number % 2);
               number = (byte)(number / 2);
           }
           return binaryVersion;

       } 

        int CalculateNeededArrayLength(int number)
        {
            int length = 0;
            while (number > 0)
            {
                number /= 2;
                length += 1;
            }
            return length;
        }
    }
}
