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
            var alarmToBeChecked = new Alarm(Days.Wednesday, 6, 0);
            Assert.AreEqual(1, CheckAlarmStatus(alarms, alarmToBeChecked));
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
            var alarmToBeChecked = new Alarm(Days.Wednesday, 15, 0);
            Assert.AreEqual(0, CheckAlarmStatus(alarms, alarmToBeChecked));
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
            var alarmToBeChecked = new Alarm(Days.Sunday, 8, 0);
            Assert.AreEqual(1, CheckAlarmStatus(alarms, alarmToBeChecked));
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
            var alarmToBeChecked = new Alarm(Days.Saturday, 6, 0);
            Assert.AreEqual(0, CheckAlarmStatus(alarms, alarmToBeChecked));
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

        static int CheckAlarmStatus(Alarm[] alarms, Alarm alarmToBeChecked)
        {
            int status = 0;
            for (int i = 0; i < alarms.Length; i++)
            {
                if ((alarms[i].day == alarmToBeChecked.day) && (alarms[i].hour == alarmToBeChecked.hour) && (alarms[i].minute == alarmToBeChecked.minute))
                    status = 1;
            }
            return status;
        }
    }
}
