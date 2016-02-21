using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Alarm
{
    [TestClass]
    public class AlarmTests
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        struct Alarm
        {
            public Day day;
            public int hour;
            public int minute;

            public Alarm(Day day, int hour, int minute)
            {
                this.day = day;
                this.hour = hour;
                this.minute = minute;
            }
        }

        enum Day
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        /*static bool CheckAlarmStatus(Alarm alarm)
        {
            
        }*/
    }
}
