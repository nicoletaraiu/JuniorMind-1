using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cyclometer
{
    [TestClass]
    public class CyclometerTests
    {
        [TestMethod]
        public void ShouldReturnTotalDistanceOfOneCyclist()
        {
            var cyclist = new Cyclist("Ion", 0.7, new Records[] { new Records(4, 1), new Records(3, 2), new Records(2, 3) });
            Assert.AreEqual(19.782, CalculateTotalDistanceOfOneCyclist(cyclist));
        }
        [TestMethod]
        public void ShouldReturnTotalDistance()
        {
            var cyclists = new Cyclist[] {
            new Cyclist("Ion", 0.7, new Records[] { new Records(4, 1), new Records(3, 2), new Records(2, 3) }),
            new Cyclist("Gheorghe", 0.6, new Records[] { new Records(3, 1), new Records(4, 2), new Records(5, 3) }),
            new Cyclist("Raul", 0.5, new Records[] { new Records(2, 1), new Records(6, 2), new Records(3, 3) }) };
            Assert.AreEqual(59.66, CalculateTotalDistance(cyclists));
        }
        [TestMethod]
        public void ShouldReturnAverageSpeedOneCyclist()
        {
            var cyclist = new Cyclist("Gheorghe", 0.6, new Records[] { new Records(3, 1), new Records(4, 2), new Records(5, 3) });
            Assert.AreEqual(7.536, CalculateAverageSpeed(cyclist), 0.00001);
        }
        [TestMethod]
        public void ShouldReturnBestAverageSpeed()
        {
            var cyclists = new Cyclist[] {
            new Cyclist("Ion", 0.7, new Records[] { new Records(4, 1), new Records(3, 2), new Records(2, 3) }),
            new Cyclist("Gheorghe", 0.6, new Records[] { new Records(3, 1), new Records(4, 2), new Records(5, 3) }),
            new Cyclist("Raul", 0.5, new Records[] { new Records(2, 1), new Records(6, 2), new Records(3, 3) }) };
            Assert.AreEqual(7.536, CalculateBestAverageSpeed(cyclists), 0.0001);
        }
        [TestMethod]
        public void ShouldReturnCyclistWithBestAverageSpeed()
        {
            var cyclists = new Cyclist[] {
            new Cyclist("Ion", 0.7, new Records[] { new Records(4, 1), new Records(3, 2), new Records(2, 3) }),
            new Cyclist("Gheorghe", 0.6, new Records[] { new Records(3, 1), new Records(4, 2), new Records(5, 3) }),
            new Cyclist("Raul", 0.5, new Records[] { new Records(2, 1), new Records(6, 2), new Records(3, 3) }) };
            Assert.AreEqual(new Cyclist("Gheorghe", 0.6, new Records[] { new Records(3, 1), new Records(4, 2), new Records(5, 3) }), FindCyclistWithBestAverageSpeed(cyclists));
        }

        public struct Cyclist {
            public string name;
            public double diameter;
            public Records[] records;

            public Cyclist(string name, double diameter, Records[] records)
            {
                this.name = name;
                this.diameter = diameter;
                this.records = records;
            }
        }

        public struct Records
        {
            public int rotations;
            public int second;

            public Records(int rotations, int second)
            {
                this.rotations = rotations;
                this.second = second;
            }
        }

        double CalculateTotalDistanceOfOneCyclist(Cyclist cyclist)
        {
            double totalDistance = 0;
            for (int i = 0; i < cyclist.records.Length; i++)
            {
                totalDistance += 3.14 * cyclist.diameter * cyclist.records[i].rotations;
            }
            return totalDistance;
        }
        
        double CalculateTotalDistance(Cyclist[] cyclists)
        {
            double totalDistance = 0;
            for (int i = 0; i < cyclists.Length; i++)
            {
                totalDistance += CalculateTotalDistanceOfOneCyclist(cyclists[i]);
            }
            return totalDistance;
        }

        double CalculateAverageSpeed(Cyclist cyclist)
        {
            double distance = CalculateTotalDistanceOfOneCyclist(cyclist);
            double averageSpeed = 0;
            int totalTime = 0;
            for (int i = 0; i < cyclist.records.Length; i++)
            {
                totalTime = cyclist.records[i].second;
            }
            averageSpeed += distance / totalTime;
            return averageSpeed;
        }

        double CalculateBestAverageSpeed(Cyclist[] cyclists)
        {
            double bestAverageSpeed = CalculateAverageSpeed(cyclists[0]);
            for (int i = 0; i < cyclists.Length; i++)
            {
                double speed = CalculateAverageSpeed(cyclists[i]);
                if (speed > bestAverageSpeed)
                    bestAverageSpeed = speed; 
            }
            return bestAverageSpeed;
        }

        Cyclist FindCyclistWithBestAverageSpeed(Cyclist[] cyclists)
        {
            Cyclist bestCyclist = cyclists[0];
            double bestAverageSpeed = CalculateAverageSpeed(cyclists[0]);
            for (int i = 0; i < cyclists.Length; i++)
            {
                double speed = CalculateAverageSpeed(cyclists[i]);
                if (speed > bestAverageSpeed)
                {
                    bestAverageSpeed = speed;
                    bestCyclist = cyclists[i];
                }
            }
            return bestCyclist;
        }

    }
}
