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
            CollectionAssert.AreEqual(new byte[] { 0, 0, 1 }, RightShift(new byte[] { 0, 1, 0 }, 1));
        }
        [TestMethod]
        public void SecondRightShiftTest()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 0, 1 }, RightShift(new byte[] { 1, 1, 0 }, 2));
        }
        [TestMethod]
        public void ThirdRightShiftTest()
        {
            CollectionAssert.AreEqual(ToBinary(2), LeftShift(ToBinary(1), 1));
        }
        [TestMethod]
        public void LessThanTest()
        {
            CollectionAssert.AreEqual(ToBinary(8), LessThan(ToBinary(49), ToBinary(8)));
        }
        [TestMethod]
        public void SecondLessThanTest()
        {
            CollectionAssert.AreEqual(ToBinary(38), LessThan(ToBinary(49), ToBinary(38)));
        }
        [TestMethod]
        public void ThirdLessThanTest()
        {
            CollectionAssert.AreEqual(ToBinary(48), LessThan(ToBinary(48), ToBinary(49)));
        }
        [TestMethod]
        public void GreaterThanTest()
        {
            CollectionAssert.AreEqual(ToBinary(49), GreaterThan(ToBinary(49), ToBinary(13)));
        }
        [TestMethod]
        public void SecondGreaterThanTest()
        {
            CollectionAssert.AreEqual(ToBinary(49), GreaterThan(ToBinary(49), ToBinary(38)));
        }
        [TestMethod]
        public void ThirdGreaterThanTest()
        {
            CollectionAssert.AreEqual(ToBinary(49), GreaterThan(ToBinary(48), ToBinary(49)));
        }
        [TestMethod]
        public void FourthGreaterThanTest()
        {
            CollectionAssert.AreEqual(ToBinary(49), GreaterThan(ToBinary(49), ToBinary(48)));
        }

        byte GetAt(byte[] byteArray, int i)
        {
            if (i >= byteArray.Length) return 0;
            else return byteArray[byteArray.Length - 1 - i];
        }

        byte[] GreaterThan(byte[] firstByte, byte[] secondByte)
        {
            if (firstByte.Length == secondByte.Length)
            {
                for (int i = 1; i < firstByte.Length; i++)
                {
                    if (firstByte[i] > secondByte[i])
                        return firstByte;
                    else return secondByte;
                }
            }
            if (firstByte.Length > secondByte.Length)
                return firstByte;
            else return secondByte;
        }

        byte[] LessThan(byte[] firstByte, byte[] secondByte)
        {   
            if (firstByte.Length == secondByte.Length)
                {
                 for (int i = 1; i < firstByte.Length; i++)
                {
                    if (firstByte[i] > secondByte[i])
                        return secondByte;
                    else return firstByte;
                }
                }
            if (firstByte.Length > secondByte.Length)
                return secondByte;
            else return firstByte;
        }
        /// 49 -> 110001
        /// 48 -> 110000
        /// 38 -> 100110

        byte[] LeftShift(byte[] firstByte, int shiftingNumber)
        {
            byte[] secondByte = new byte[firstByte.Length + shiftingNumber];
            for (int i = 0; i < firstByte.Length; i++)
            {
                secondByte[i] = firstByte[i];
            }
            return secondByte;
        }

        byte[] RightShift(byte[] firstByte, int shiftingNumber)
        {   
            byte[] secondByte = firstByte;
            while (shiftingNumber > 0)
            {
                for (int i = secondByte.Length - 1; i > 0; i--)
                {
                    secondByte[i] = secondByte[i - 1];
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
