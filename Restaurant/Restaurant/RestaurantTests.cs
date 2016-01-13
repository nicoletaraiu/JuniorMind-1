using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Restaurant
{
    [TestClass]
    public class RestaurantTests
    {
        [TestMethod]
        public void TestForGivenCase()
        {
            Assert.AreEqual(13, FindMeetingDay(4, 6));
        }
        [TestMethod]
        public void TestForRichPeople()
        {
            Assert.AreEqual(2, FindMeetingDay(1, 1));
        }
        [TestMethod]
        public void TestForGCD()
        {
            Assert.AreEqual(2, GreatCommonDivisor(4, 6));
        }
        int GreatCommonDivisor(int a, int b)
        {
            while (b != 0)
            {
                int aux = b;
                b = a % b;
                a = aux;
            }
            return a;
        }
        int FindMeetingDay(int a, int b)
        {
            return (a * b) / GreatCommonDivisor(a, b) + 1;
        }
    }
}