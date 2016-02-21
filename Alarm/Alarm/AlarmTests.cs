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
            Assert.AreEqual(1, CheckAlarmStatus(new Alarm(Days.Monday, 8, 0)));
        }

        struct Alarm
        {
            public Days day;
            public int hour;
            public int minute;

            public Alarm(Days day, int hour, int minute)
            {
                this.day = day;
                this.hour = hour;
                this.minute = minute;
            }
        }
        [Flags]
        public enum Days
        {
            Monday = 1,
            Tuesday = 2,
            Wednesday = 3,
            Thursday = 4,
            Friday = 5,
            Saturday = 6,
            Sunday = 7
        }

        static int CheckAlarmStatus(Alarm alarms)
        {
            int status = 0;
            if (alarms.day != 0) status = 1;

            return status;
        }
    }
}
