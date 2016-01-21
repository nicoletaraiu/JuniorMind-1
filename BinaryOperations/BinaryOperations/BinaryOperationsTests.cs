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
        public void FirstToBinaryTest()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 1, 0, 0, 0, 1 }, ToBinary(49));
        }
        [TestMethod]
        public void SecondToBinaryTest()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 0, 0, 1, 1, 0 }, ToBinary(38));
        }
        [TestMethod]
        public void ThirdToBinaryTest()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 1, 1, 1, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0 }, ToBinary(123456));
        }
        [TestMethod]
        public void FirstNotOperatorTest()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 0, 1, 1, 1, 0 }, NotOperator(49));
        }
        [TestMethod]
        public void SecondNotOperatorTest()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 1, 1, 0, 0, 1 }, NotOperator(38));
        }
        [TestMethod]
        public void ThirdNotOperatorTest()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 0, 0, 0, 1, 1, 1, 0, 1, 1, 0, 1, 1, 1, 1, 1, 1 }, NotOperator(123456));
        }

        byte[] OrOperator(int firstNumber, int secondNumber)
        {
            byte[] firstByte = ToBinary(firstNumber);
            byte[] secondByte = ToBinary(secondNumber);
            byte[] wantedByte = new byte[CalculateNeededArrayLength(firstNumber)];
            for (int i = 0; i < firstByte.Length; i++)
            {
                for (int j = 0; j < secondByte.Length; j++)
                {
                    if (firstByte[i] == secondByte[j]) wantedByte[i] = 0;
                    else wantedByte[i] = 1;
                }
            }
            return wantedByte;
        }

        byte[] NotOperator(int number)
        {
            byte[] binaryVersion = ToBinary(number);
            for (int i = 0; i < binaryVersion.Length; i++)
            {
                if (binaryVersion[i] == 0) binaryVersion[i] = 1;
                else binaryVersion[i] = 0;
            }
            return binaryVersion;
        }
        byte[] ToBinary(int number)
        {
            byte[] binaryVersion = new byte[CalculateNeededArrayLength(number)];
            while (number > 0)
            {
                binaryVersion[CalculateNeededArrayLength(number) - 1] = (byte)(number % 2);
                number = number / 2;
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
