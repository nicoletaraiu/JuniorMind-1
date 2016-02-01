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
            CollectionAssert.AreEqual(new byte[] { 0, 0, 1, 1, 1, 0 }, NotOperator(new byte[] { 1, 1, 0, 0, 0, 1 }));
        }
        [TestMethod]
        public void SecondNotOperatorTest()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 1, 1, 0, 0, 1 }, NotOperator(new byte[] { 1, 0, 0, 1, 1, 0 }));
        }
        [TestMethod]
        public void ThirdNotOperatorTest()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 0, 0, 0, 1, 1, 1, 0, 1, 1, 0, 1, 1, 1, 1, 1, 1 }, NotOperator(new byte[] { 1, 1, 1, 1, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0 }));
        }
        [TestMethod]
        public void FirstOrOperatorTest()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 1, 1 }, OrOperator(new byte[] { 1, 0, 1 }, new byte[] { 1, 1, 0 }));
        }
        [TestMethod]
        public void ToBinary()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 1 }, ToBinary(3));
        }
        /*[TestMethod]
        public void SecondOrOperatorTest()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 1, 1}, OrOperator(5, 3));
        }*/
        [TestMethod]
        public void FirstAndOperatorTest()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 0, 0, 0, 0, 0 }, AndOperator(new byte[] { 1, 1, 0, 0, 0, 1 }, new byte[] { 1, 0, 0, 1, 1, 0 }));
        }
        [TestMethod]
        public void FirstXorOperatorTest()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 1, 0, 1, 1, 1}, XorOperator(new byte[] { 1, 1, 0, 0, 0, 1 }, new byte[] { 1, 0, 0, 1, 1, 0 }));
        }
        [TestMethod]
        public void RightShift()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 0, 1 }, RightShift( new byte[] { 0, 1, 0 } , 1));
        }


        byte[] RightShift(byte[] firstByte, int shiftingNumber)
        {
            byte[] secondByte = new byte[firstByte.Length];
            while (shiftingNumber > 0)
            {
                for (int i = 1; i < firstByte.Length; i++)
                {
                    secondByte[i] = firstByte[i - 1];
                }
                secondByte[0] = 0;
                shiftingNumber--;
            }
            return secondByte;
        }

        byte[] XorOperator(byte[] firstByte, byte[] secondByte)
        {
            byte[] wantedByte = new byte[secondByte.Length];
            for (int i = 0; i < secondByte.Length; i++)
            {
                wantedByte[i] = (byte)((((firstByte[i] == 1) && (secondByte[i] == 0)) || ((firstByte[i] == 0) && (secondByte[i] == 1))) ? 1 : 0);
            } 
            return wantedByte;
        }

        byte[] AndOperator(byte[] firstByte, byte[] secondByte)
        {
            byte[] wantedByte = new byte[secondByte.Length];
            for (int i = 0; i < secondByte.Length; i++)
            {
                wantedByte[i] = (byte)(((firstByte[i] == 1) && (secondByte[i] == 1)) ? 1 : 0);
            } 
            return wantedByte;
        }

        byte[] OrOperator(byte[] firstByte, byte[] secondByte)
        {
            byte[] wantedByte = new byte[secondByte.Length];
            for (int i = 0; i < secondByte.Length; i++)
            {
                wantedByte[i] = (byte)(((firstByte[i] == 0) && (secondByte[i] == 0)) ? 0 : 1);
            } 
            return wantedByte;
        }

        byte[] NotOperator(byte[] firstByte)
        {
            byte[] wantedByte = new byte[firstByte.Length];
            for (int i = 0; i < firstByte.Length; i++)
            {
                wantedByte[i] = (byte)((firstByte[i] == 0) ? 1 : 0); 
            }
            return wantedByte;
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
