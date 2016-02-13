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
            CollectionAssert.AreEqual(new byte[] { 1, 1, 1 }, ImplementALogicOperator(new byte[] { 1, 0, 1 }, new byte[] { 1, 1, 0 }, "OR"));
        }
        [TestMethod]
        public void ToBinary()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 1 }, ToBinary(3));
        }
        [TestMethod]
        public void SecondOrOperatorTest()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 1, 1 }, ImplementALogicOperator(ToBinary(5), ToBinary(3), "OR"));
        }
        [TestMethod]
        public void FirstAndOperatorTest()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 0, 0, 0, 0, 0 }, ImplementALogicOperator(new byte[] { 1, 1, 0, 0, 0, 1 }, new byte[] { 1, 0, 0, 1, 1, 0 }, "AND"));
        }
        [TestMethod]
        public void FirstXorOperatorTest()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 1, 0, 1, 1, 1 }, ImplementALogicOperator(new byte[] { 1, 1, 0, 0, 0, 1 }, new byte[] { 1, 0, 0, 1, 1, 0 }, "XOR"));
        }
        [TestMethod]
        public void RightShift()
        {
            CollectionAssert.AreEqual(ToBinary(2 >> 2), RightShift(ToBinary(2), 2));
        }
        [TestMethod]
        public void SecondRightShiftTest()
        {
            CollectionAssert.AreEqual(ToBinary(5 >> 2), RightShift(ToBinary(5), 2));
        }
        [TestMethod]
        public void ThirdRightShiftTest()
        {
            CollectionAssert.AreEqual(ToBinary(2), LeftShift(ToBinary(1), 1));
        }
        [TestMethod]
        public void FirstIsNotSmallerThanSecond()
        {
            Assert.AreEqual(false, LessThan(ToBinary(49), ToBinary(8)));
        }
        [TestMethod]
        public void FirstIsNotSMallerThanSecond()
        {
            Assert.AreEqual(false, LessThan(ToBinary(49), ToBinary(38)));
        }
        [TestMethod]
        public void FirstIsSmallerThanSecond()
        {
            Assert.AreEqual(true, LessThan(ToBinary(48), ToBinary(49)));
        }
        [TestMethod]
        public void ThreeIsSmallerThanFour()
        {
            Assert.AreEqual(true, LessThan(ToBinary(3), ToBinary(4)));
        }
        [TestMethod]
        public void FirstIsNotGreaterThanSecond()
        {
            Assert.AreEqual(true, GreaterThan(ToBinary(13), ToBinary(49)));
        }
        [TestMethod]
        public void FirstIsGReaterThanSecond()
        {
            Assert.AreEqual(false, GreaterThan(ToBinary(49), ToBinary(38)));
        }
        [TestMethod]
        public void FirstIsNotGReaterThanSecond()
        {
            Assert.AreEqual(true, GreaterThan(ToBinary(48), ToBinary(49)));
        }
        [TestMethod]
        public void FirstIsGREaterThanSecond()
        {
            Assert.AreEqual(true, GreaterThan(ToBinary(48), ToBinary(49)));
        }
        [TestMethod]
        public void FirstIsGREAterThanSecond()
        {
            Assert.AreEqual(true, GreaterThan(ToBinary(5), ToBinary(1124)));
        }
        [TestMethod]
        public void GetAt0()
        {
            byte[] byteArray = { 3, 2, 1 };
            Assert.AreEqual(1, GetAt(byteArray, 0));
        }
        [TestMethod]
        public void GetAt1()
        {
            byte[] byteArray = { 3, 2, 1 };
            Assert.AreEqual(2, GetAt(byteArray, 1));
        }
        [TestMethod]
        public void GetAt2()
        {
            byte[] byteArray = { 3, 2, 1 };
            Assert.AreEqual(3, GetAt(byteArray, 2));
        }
        [TestMethod]
        public void GetAt3()
        {
            byte[] byteArray = { 3, 2, 1 };
            Assert.AreEqual(0, GetAt(byteArray, 3));
        }
        [TestMethod]
        public void FiveEqualsFive()
        {
            Assert.AreEqual(true, Equal(ToBinary(5), ToBinary(5)));
        }
        [TestMethod]
        public void TwentyEqualsTwenty()
        {
            Assert.AreEqual(true, Equal(ToBinary(20), ToBinary(20)));
        }
        [TestMethod]
        public void ThreeIsNotEqualToFive()
        {
            Assert.AreEqual(true, Equal(ToBinary(3), ToBinary(5)));
        }
        [TestMethod]
        public void FivePlusOne()
        {
            CollectionAssert.AreEqual(ToBinary(5), Add(ToBinary(4), ToBinary(1), 2));
        }
        [TestMethod]
        public void OnePlusTwo()
        {
            CollectionAssert.AreEqual(ToBinary(3), Add(ToBinary(1), ToBinary(2), 2));
        }
        [TestMethod]
        public void AddingGreaterNumbers()
        {
            CollectionAssert.AreEqual(ToBinary(125), Add(ToBinary(83), ToBinary(42), 2));
        }
        [TestMethod]
        public void TwoMinusOne()
        {
            CollectionAssert.AreEqual(new byte[] { 1 }, Subtract(ToBinary(2), ToBinary(1), 2));
        }
        [TestMethod]
        public void EightMinusFive()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 1 }, Subtract(ToBinary(8), ToBinary(5), 2));
        }
        [TestMethod]
        public void LeftShift()
        {
            CollectionAssert.AreEqual(ToBinary(1 << 3), LeftShift(ToBinary(1), 3));
        }
        [TestMethod]
        public void FourMinusOne()
        {
            CollectionAssert.AreEqual(ToBinary(3), Subtract(ToBinary(4), ToBinary(1), 2));
        }
        [TestMethod]
        public void MirrorArray()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 0, 1, 1 }, MirrorArray(new byte[] { 1, 1, 0, 1 }));
        }
        [TestMethod]
        public void SecondMirrorArrayTest()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 1, 0, 0, 1 }, MirrorArray(new byte[] { 1, 0, 0, 1, 0 }));
        }
        [TestMethod]
        public void ImplementLogicOperatorOR()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 1, 1 }, ImplementALogicOperator(new byte[] { 1, 0, 1 }, new byte[] { 1, 1, 0 }, "OR"));
        }
        [TestMethod]
        public void ImplementLogicOperatorAND()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 0, 0, 0, 0, 0 }, ImplementALogicOperator(new byte[] { 1, 1, 0, 0, 0, 1 }, new byte[] { 1, 0, 0, 1, 1, 0 }, "AND"));
        }
        [TestMethod]
        public void ImplementLogicOperatorXOR()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 1, 0, 1, 1, 1 }, ImplementALogicOperator(new byte[] { 1, 1, 0, 0, 0, 1 }, new byte[] { 1, 0, 0, 1, 1, 0 }, "XOR"));
        }
        [TestMethod]
        public void CountZeroes()
        {
            Assert.AreEqual(2, CountZeroes(new byte[] { 0, 0, 1, 1, 0 }));
        }
        [TestMethod]
        public void RemoveZeroes()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 0, 1 }, RemoveZeroes(new byte[] { 0, 0, 0, 1, 0, 1 }));
        }
        [TestMethod]
        public void ThreePlusSeven()
        {
            CollectionAssert.AreEqual(ToBinary(10), Add(ToBinary(3), ToBinary(7), 2));
        }
        [TestMethod]
        public void TwoMultipliedTwoTimes()
        {
            CollectionAssert.AreEqual(ToBinary(4), Multiply(ToBinary(2), ToBinary(2), 2));
        }
        [TestMethod]
        public void TwoMultipliedThreeTimes()
        {
            CollectionAssert.AreEqual(ToBinary(6), Multiply(ToBinary(2), ToBinary(3), 2));
        }
        [TestMethod]
        public void FiveMultipliedSixTimes()
        {
            CollectionAssert.AreEqual(ToBinary(30), Multiply(ToBinary(5), ToBinary(6), 2));
        }
        [TestMethod]
        public void TenDividedByTwo()
        {
            CollectionAssert.AreEqual(ToBinary(5), Divide(ToBinary(10), ToBinary(2), 2));
        }
        [TestMethod]
        public void FifteenDividedByTwo()
        {
            CollectionAssert.AreEqual(ToBinary(3), Divide(ToBinary(15), ToBinary(5), 2));
        }
        [TestMethod]
        public void TwentyInBaseThree()
        {
            CollectionAssert.AreEqual(new byte[] { 2, 0, 2 }, ConvertIntoAnyBase(20, 3));
        }
        [TestMethod]
        public void FiftyInBaseThree()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 2, 1, 2 }, ConvertIntoAnyBase(50, 3));
        }
        [TestMethod]
        public void EightyNineInBaseFive()
        {
            CollectionAssert.AreEqual(new byte[] { 3, 2, 4 }, ConvertIntoAnyBase(89, 5));
        }
        [TestMethod]
        public void SubtractionInBaseFour()
        {
            CollectionAssert.AreEqual(ConvertIntoAnyBase(4 - 1, 4), Subtract(ConvertIntoAnyBase(4, 4), ConvertIntoAnyBase(1, 4), 4));
        }
        [TestMethod]
        public void SubtractInBaseSix()
        {
            CollectionAssert.AreEqual(ConvertIntoAnyBase(255 - 182, 6), Subtract(ConvertIntoAnyBase(255, 6), ConvertIntoAnyBase(182, 6), 6));
        }
        [TestMethod]
        public void SubtractInBaseFive()
        {
            CollectionAssert.AreEqual(ConvertIntoAnyBase(99 - 13, 5), Subtract(ConvertIntoAnyBase(99, 5), ConvertIntoAnyBase(13, 5), 5));
        }
        [TestMethod]
        public void AddInBaseSix()
        {
            CollectionAssert.AreEqual(ConvertIntoAnyBase((75 + 35), 3), Add(ConvertIntoAnyBase(75, 3), ConvertIntoAnyBase(35, 3), 3));
        }
        [TestMethod]
        public void AddInBaseEight()
        {
            CollectionAssert.AreEqual(ConvertIntoAnyBase((280 + 45), 8), Add(ConvertIntoAnyBase(280, 8), ConvertIntoAnyBase(45, 8), 8));
        }
        [TestMethod]
        public void SubtractInBaseSeven()
        {
            CollectionAssert.AreEqual(ConvertIntoAnyBase((67 - 42), 7), Subtract(ConvertIntoAnyBase(67, 7), ConvertIntoAnyBase(42, 7), 7));
        }
        [TestMethod]
        public void RemovingZeroes()
        {
            CollectionAssert.AreEqual(new byte[] { 2, 0, 1 }, RemoveZeroes(ConvertIntoAnyBase(73, 6)));
        }
        [TestMethod]
        public void CountingZeroes()
        {
            Assert.AreEqual(0, CountZeroes(new byte[] { 2, 0 }));
        }
        [TestMethod]
        public void MultiplyInBaseSeven()
        {
            CollectionAssert.AreEqual(ConvertIntoAnyBase((125 * 17), 7), Multiply(ConvertIntoAnyBase(125, 7), ConvertIntoAnyBase(17, 7), 7));
        }
        [TestMethod]
        public void DivideInBaseFour()
        {
            CollectionAssert.AreEqual(ConvertIntoAnyBase((400 / 20), 4), Divide(ConvertIntoAnyBase(400, 4), ConvertIntoAnyBase(20, 4), 4));
        }

        int CalculateNeededArrayLengthForAnyBase(int number, int Base)
        {
            int length = 0;
            while (number > 0)
            {
                number /= Base;
                length += 1;
            }
            return length;
        }

        byte[] ConvertIntoAnyBase(int number, int Base)
        { 
            byte[] resultedNumber = new byte[CalculateNeededArrayLengthForAnyBase(number, Base)];
            while (number > 0)
            {
                resultedNumber[CalculateNeededArrayLengthForAnyBase(number, Base) - 1] = (byte)(number % Base);
                number = number / Base;
            }
            return resultedNumber;
        }

        byte[] Divide(byte[] firstByteArray, byte[] secondByteArray, byte Base)
        {
            byte[] resultedByteArray = { 0 };
            while (!Equal(firstByteArray, new byte[] { 0 }))
            {
                resultedByteArray = Add(resultedByteArray, new byte[] { 1 }, Base);
                firstByteArray = Subtract(firstByteArray, secondByteArray, Base);
            }
            return resultedByteArray;
        }

        byte[] Multiply(byte[] firstByteArray, byte[] secondByteArray, byte Base)
        {
            byte[] resultedByteArray = { 0 };
            while (!Equal(secondByteArray, new byte[] { 0 }))
            {
                resultedByteArray = Add(resultedByteArray, firstByteArray, Base);
                secondByteArray = Subtract(secondByteArray, new byte[] { 1 }, Base);
                
            }
            return resultedByteArray;
        }

        byte[] MirrorArray(byte[] byteArray)
        {
            byte[] resultedByteArray = new byte[byteArray.Length];
            for (int i = 0; i < byteArray.Length; i++)
            {
                resultedByteArray[i] = byteArray[byteArray.Length - 1 - i];
            }
            return resultedByteArray;
        }

        byte[] Subtract(byte[] firstByteArray, byte[] secondByteArray, byte Base)
        {
            byte[] resultedByteArray = new byte[firstByteArray.Length];
            int remainder = 0;
            for (int i = 0; i < firstByteArray.Length; i++)
            {
                int basePlusDigitMinusDigit = (byte)(Base + (GetAt(firstByteArray, i) - GetAt(secondByteArray, i) - remainder));
                resultedByteArray[resultedByteArray.Length - i - 1] = (byte)(basePlusDigitMinusDigit % Base);

                if (basePlusDigitMinusDigit < Base) remainder = 1;
                else remainder = 0;
            }
            resultedByteArray = RemoveZeroes(resultedByteArray);
            return resultedByteArray;
        }

        byte[] Add(byte[] firstByteArray, byte[] secondByteArray, byte Base)
        {
            byte[] resultedByteArray = new byte[Math.Max(firstByteArray.Length, secondByteArray.Length)];
            int remainder = 0;
            for (int i = 0; i < resultedByteArray.Length; i++)
            {
                byte bitsAdder = (byte)(GetAt(firstByteArray, i) + GetAt(secondByteArray, i) + remainder);
                resultedByteArray[resultedByteArray.Length - 1 - i] = (byte)(bitsAdder % Base);
                remainder = (bitsAdder > (Base - 1)) ? 1 : 0; 
            }                          

            if (remainder == 1)
            {
                Array.Resize(ref resultedByteArray, resultedByteArray.Length + 1);
                ShiftRightKeepZeroes(resultedByteArray, 1);
                resultedByteArray[0] = 1;
            }
            return resultedByteArray;
        }

        bool Equal(byte[] firstByteArray, byte[] secondByteArray)
        {
            return ((GreaterThan(firstByteArray, secondByteArray)) && (LessThan(firstByteArray, secondByteArray)));
        }

        byte GetAt(byte[] byteArray, int i)
        {
            if (i >= byteArray.Length) return 0;
            return byteArray[byteArray.Length - 1 - i];
        }

        bool GreaterThan(byte[] firstByteArray, byte[] secondByteArray)
        {
            return LessThan(firstByteArray, secondByteArray);
        }

        bool LessThan(byte[] firstByteArray, byte[] secondByteArray)
        {
            for (int i = Math.Max(firstByteArray.Length, secondByteArray.Length); i >= 0 ; i--)
            {
                if (GetAt(firstByteArray, i) != GetAt(secondByteArray, i))
                    return GetAt(firstByteArray, i) < GetAt(secondByteArray, i);
            }
            return true;
        }

        byte[] LeftShift(byte[] byteArray, int shiftingNumber)
        {
            byte[] resultedByteArray = new byte[byteArray.Length + shiftingNumber];
            for (int i = 0; i < byteArray.Length; i++)
            {
                resultedByteArray[i] = byteArray[i];
            }
            return resultedByteArray;
        }

        byte[] RightShift(byte[] byteArray, int shiftingNumber)
        {
            Array.Resize(ref byteArray, byteArray.Length - shiftingNumber);
            return byteArray;
        }    
        
        int CountZeroes(byte[] byteArray)
        {
            int counter = 0;
            for (int i = 0; i < byteArray.Length; i++)
            {
                if (byteArray[i] == 0) counter++;
                if (byteArray[i] != 0) break;
            }
            return counter;
        }

        byte[] RemoveZeroes(byte[] byteArray)
        {
            int counter = CountZeroes(byteArray);
            while (counter > 0)
            {
                for (int i = 0; i < byteArray.Length - 1; i++)
                {
                    byteArray[i] = byteArray[i + 1];
                }
                counter--;
                Array.Resize<byte>(ref byteArray, byteArray.Length - 1);
            }
            return byteArray;
        }
        byte[] ShiftRightKeepZeroes(byte[] byteArray, int shiftingNumber)
        {
            while (shiftingNumber > 0)
            {
                for (int i = byteArray.Length - 1; i > 0; i--)
                {
                    byteArray[i] = byteArray[i - 1];

                }
                shiftingNumber--;
            }
            return byteArray;
        }
        
        byte[] ImplementALogicOperator(byte[] firstByteArray, byte[] secondByteArray, string choice)
        {
            byte[] wantedByteArray = new byte[Math.Max(firstByteArray.Length, secondByteArray.Length)];
            for (int i = 0; i < wantedByteArray.Length; i++)
            {
                switch (choice)
            {
                    case "AND":
                        wantedByteArray[wantedByteArray.Length - 1 - i] = (byte)(((GetAt(firstByteArray, i) == 1) && (GetAt(secondByteArray, i) == 1)) ? 1 : 0);
                        break;
                    case "OR":
                        wantedByteArray[wantedByteArray.Length - 1 - i] = (byte)((((GetAt(firstByteArray, i) == 0) && ((GetAt(secondByteArray, i) == 0)) ? 0 : 1)));
                        break;
                    case "XOR":
                        wantedByteArray[wantedByteArray.Length - 1 - i] = (byte)((((GetAt(firstByteArray, i) == 1) && (GetAt(secondByteArray, i) == 0)) || ((GetAt(firstByteArray, i) == 0) && (GetAt(secondByteArray, i) == 1))) ? 1 : 0);
                        break;
                }
            }
            return wantedByteArray;
        } 

        byte[] NotOperator(byte[] byteArray)
        {
            byte[] wantedByteArray = new byte[byteArray.Length];
            for (int i = 0; i < byteArray.Length; i++)
            {
                wantedByteArray[wantedByteArray.Length - 1 - i] = (byte)((GetAt(byteArray, i) == 0) ? 1 : 0); 
            }
            return wantedByteArray;
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
