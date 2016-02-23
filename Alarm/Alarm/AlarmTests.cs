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
            var alarms = new Alarm[]
                 { new Alarm(Days.Monday, 6, 0),
              new Alarm(Days.Tuesday, 6, 0),
              new Alarm(Days.Wednesday, 6, 0),
              new Alarm(Days.Thursday, 6, 0),
              new Alarm(Days.Friday, 6, 0),
              new Alarm(Days.Saturday, 8, 0),
              new Alarm(Days.Sunday, 8, 0) };
            Assert.AreEqual(true, CheckAlarmStatus(alarms, Days.Wednesday, 6, 0));
        }
        [TestMethod]
        public void SecondCheck()
        {
            var alarms = new Alarm[]
                 { new Alarm(Days.Monday, 6, 0),
              new Alarm(Days.Tuesday, 6, 0),
              new Alarm(Days.Wednesday, 6, 0),
              new Alarm(Days.Thursday, 6, 0),
              new Alarm(Days.Friday, 6, 0),
              new Alarm(Days.Saturday, 8, 0),
              new Alarm(Days.Sunday, 8, 0) };
            Assert.AreEqual(false, CheckAlarmStatus(alarms, Days.Wednesday, 15, 0));
        }
        [TestMethod]
        public void ThirdCheck()
        {
            var alarms = new Alarm[]
                 { new Alarm(Days.Monday, 6, 0),
              new Alarm(Days.Tuesday, 6, 0),
              new Alarm(Days.Wednesday, 6, 0),
              new Alarm(Days.Thursday, 6, 0),
              new Alarm(Days.Friday, 6, 0),
              new Alarm(Days.Saturday, 8, 0),
              new Alarm(Days.Sunday, 8, 0) };
            Assert.AreEqual(true, CheckAlarmStatus(alarms, Days.Sunday, 8, 0));
        }
        [TestMethod]
        public void FourthCheck()
        {
            var alarms = new Alarm[]
                 { new Alarm(Days.Monday, 6, 0),
              new Alarm(Days.Tuesday, 6, 0),
              new Alarm(Days.Wednesday, 6, 0),
              new Alarm(Days.Thursday, 6, 0),
              new Alarm(Days.Friday, 6, 0),
              new Alarm(Days.Saturday, 8, 0),
              new Alarm(Days.Sunday, 8, 0) };
            Assert.AreEqual(false, CheckAlarmStatus(alarms, Days.Saturday, 6, 0));
        }
        [TestMethod]
        public void FifthCheck()
        {
            var alarms = new Alarm[]
                 { new Alarm(Days.Monday, 6, 0),
              new Alarm(Days.Tuesday, 6, 0),
              new Alarm(Days.Wednesday, 6, 0),
              new Alarm(Days.Thursday, 6, 0),
              new Alarm(Days.Friday, 6, 0),
              new Alarm(Days.Saturday, 8, 0),
              new Alarm(Days.Sunday, 8, 0) };
            Assert.AreEqual(false, CheckAlarmStatus(alarms, Days.Tuesday, 6, 1));
            Assert.AreEqual(true, CheckAlarmStatus(alarms, Days.Tuesday, 6, 0));
        }
        [TestMethod]
        public void DemandedTest()
        {
            var alarms = new Alarm[]
                 {
              new Alarm(Days.Tuesday, 6, 0),
              new Alarm(Days.Friday, 6, 0) };
            Assert.AreEqual(false, CheckAlarmStatus(alarms, Days.Tuesday, 6, 1));
            Assert.AreEqual(false, CheckAlarmStatus(alarms, Days.Saturday, 8, 0));
            Assert.AreEqual(false, CheckAlarmStatus(alarms, Days.Friday, 6, 2));
            Assert.AreEqual(true, CheckAlarmStatus(alarms, Days.Tuesday, 6, 0));
            Assert.AreEqual(true, CheckAlarmStatus(alarms, Days.Friday, 6, 0));
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

        static bool CheckAlarmStatus(Alarm[] alarms, Days day, int hour, int minute)
        {
            bool status = false;
            for (int i = 0; i < alarms.Length; i++)
            {
                if ((alarms[i].day == day) && (alarms[i].hour == hour) && (alarms[i].minute == minute))
                    return true;
            }
            return status;
        }
    }
}
