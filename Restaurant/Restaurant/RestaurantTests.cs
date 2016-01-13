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
        int GreatCommonDivisor(int whenMyFriendGoes, int whenIGo)
        {
            while (whenIGo != 0)
            {
                int aux = whenIGo;
                whenIGo = whenMyFriendGoes % whenIGo;
                whenMyFriendGoes = aux;
            }
            return whenMyFriendGoes;
        }
        int FindMeetingDay(int whenMyFriendGoes, int whenIGo)
        {
            return (whenMyFriendGoes * whenIGo) / GreatCommonDivisor(whenMyFriendGoes, whenIGo) + 1;
        }
    }
}