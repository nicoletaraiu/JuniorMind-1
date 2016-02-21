using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Alarm
{
    [TestClass]
    public class AlarmTests
    {
        [TestMethod]
        public void SimpleCheck()
        {
            Assert.AreEqual(1, CheckAlarmStatus(new Alarm(Days.Monday, 6, 0)));
            Assert.AreEqual(0, CheckAlarmStatus(new Alarm(Days.Saturday, 6, 0)));
            Assert.AreEqual(0, CheckAlarmStatus(new Alarm(Days.Tuesday, 8, 0)));
        }
        [TestMethod]
        public void WeekendCheck()
        {
            Assert.AreEqual(1, CheckAlarmStatus(new Alarm(Days.Saturday, 8, 0)));
            Assert.AreEqual(0, CheckAlarmStatus(new Alarm(Days.Sunday, 7, 0)));
            Assert.AreEqual(0, CheckAlarmStatus(new Alarm(Days.Sunday, 8, 45)));
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
            Wednesday = 4,
            Thursday = 8,
            Friday = 16,
            Saturday = 32,
            Sunday = 64
        }

        static int CheckAlarmStatus(Alarm alarms)
        {
            int status = 0;
            if
                (((alarms.day == Days.Monday) || (alarms.day == Days.Tuesday) || (alarms.day == Days.Wednesday) || (alarms.day == Days.Thursday) || (alarms.day == Days.Friday)) && (alarms.hour == 6) && (alarms.minute == 0))
                    status = 1;
            if (((alarms.day == Days.Saturday) || (alarms.day == Days.Sunday)) && (alarms.hour == 8) && (alarms.minute == 0))
                status = 1;

            return status;
        }
    }
}
