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
        [TestMethod]
        public void FirstOrOperatorTest()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 1, 0, 1, 1, 1 }, OrOperator(49, 38));
        }
        [TestMethod]
        public void ToBinary()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 1 }, ToBinary(3));
        }
        [TestMethod]
        public void SecondOrOperatorTest()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 1, 1}, OrOperator(5, 3));
        }
        [TestMethod]
        public void FirstAndOperatorTest()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 0, 0, 0, 0, 0 }, AndOperator(49, 38));
        }
        [TestMethod]
        public void FirstXorOperatorTest()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 1, 0, 1, 1, 1}, XorOperator(49, 38));
        }
        [TestMethod]
        public void LeftShift()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 0, 0, 0 }, ShiftLeft(1, 3));
        }

        byte[] ShiftLeft(int number, int shiftingNumber )
        {
            double newNumber = number * Math.Pow(2, shiftingNumber);
            byte[] afterShifting = ToBinary(newNumber);
            return afterShifting;
        }

        byte[] XorOperator(int firstNumber, int secondNumber)
        {
            byte[] firstByte = ToBinary(firstNumber);
            byte[] secondByte = ToBinary(secondNumber);
            byte[] wantedByte = new byte[CalculateNeededArrayLength(firstNumber)];
            for (int i = 0; i < secondByte.Length; i++)
            {
                wantedByte[i] = (byte)((((firstByte[i] == 1) && (secondByte[i] == 0)) || ((firstByte[i] == 0) && (secondByte[i] == 1))) ? 1 : 0);
            } 
            return wantedByte;
        }

        byte[] AndOperator(int firstNumber, int secondNumber)
        {
            byte[] firstByte = ToBinary(firstNumber);
            byte[] secondByte = ToBinary(secondNumber);
            byte[] wantedByte = new byte[CalculateNeededArrayLength(firstNumber)];
            for (int i = 0; i < secondByte.Length; i++)
            {
                wantedByte[i] = (byte)(((firstByte[i] == 1) && (secondByte[i] == 1)) ? 1 : 0);
            } 
            return wantedByte;
        }

        byte[] OrOperator(int firstNumber, int secondNumber)
        {
            byte[] firstByte = ToBinary(firstNumber);
            byte[] secondByte = ToBinary(secondNumber);
            byte[] wantedByte = new byte[CalculateNeededArrayLength(firstNumber)];
            for (int i = 0; i < secondByte.Length; i++)
            {
                wantedByte[i] = (byte)(((firstByte[i] == 0) && (secondByte[i] == 0)) ? 0 : 1);
            } 
            return wantedByte;
        }

        byte[] NotOperator(int number)
        {
            byte[] binaryVersion = ToBinary(number);
            for (int i = 0; i < binaryVersion.Length; i++)
            {
                binaryVersion[i] = (byte)((binaryVersion[i] == 0) ? 1 : 0); 
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
