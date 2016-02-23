using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Alarm
{
    [TestClass]
    public class AlarmTests
    {
        [TestMethod]
        public void FirstCheck()
        {
            var workingDays = Days.Monday | Days.Tuesday | Days.Wednesday | Days.Thursday | Days.Friday;
            var weekendDays = Days.Saturday | Days.Sunday;
            Assert.AreEqual(true, CheckAlarmStatus(Days.Wednesday, 6, 0));
        }
        [TestMethod]
        public void SecondCheck()
        {
            var workingDays = Days.Monday | Days.Tuesday | Days.Wednesday | Days.Thursday | Days.Friday;
            var weekendDays = Days.Saturday | Days.Sunday;
            Assert.AreEqual(false, CheckAlarmStatus(Days.Wednesday, 15, 0));
        }
        [TestMethod]
        public void ThirdCheck()
        {
            var workingDays = Days.Monday | Days.Tuesday | Days.Wednesday | Days.Thursday | Days.Friday;
            var weekendDays = Days.Saturday | Days.Sunday;
            Assert.AreEqual(true, CheckAlarmStatus(Days.Sunday, 8, 0));
        }
        [TestMethod]
        public void FourthCheck()
        {
            var workingDays = Days.Monday | Days.Tuesday | Days.Wednesday | Days.Thursday | Days.Friday;
            var weekendDays = Days.Saturday | Days.Sunday;
            Assert.AreEqual(false, CheckAlarmStatus(Days.Saturday, 6, 0));
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

        static bool CheckAlarmStatus(Days day, int hour, int minute)
        {
            var workingDays = Days.Monday | Days.Tuesday | Days.Wednesday | Days.Thursday | Days.Friday;
            var weekendDays = Days.Saturday | Days.Sunday;

            if (((workingDays & day) == day) && (hour == 6) && (minute == 0))
                return true;
            return (((weekendDays & day) == day) && (hour == 8) && (minute == 0));
        }
    }
}
