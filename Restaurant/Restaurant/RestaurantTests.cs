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
        int FindMeetingDay(int whenMyFriendGoes, int whenIGo)
        {
            int auxiliar1, auxiliar2;
            if (whenMyFriendGoes > whenIGo)
            {
                auxiliar1 = whenMyFriendGoes;
                auxiliar2 = whenIGo;
            }
            else
            {
                auxiliar1 = whenIGo;
                auxiliar2 = whenMyFriendGoes;
            }

            for (int i = 1; i <= auxiliar2; i++)
            {
                if ((auxiliar1 * i) % auxiliar2 == 0)
                {
                    return i * auxiliar1 + 1;
                }
            }
            return auxiliar2 + 1;
        }
    }
}
