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
        public void ShouldReturnAverageSpeedOfEachCyclist()
        {
            var Ion = new Cyclist("Ion", 0.7, new Records[] { new Records(4, 1), new Records(3, 2), new Records(2, 3) });
            Assert.AreEqual(6.594, CalculateAverageSpeed(Ion));
            var Raul = new Cyclist("Raul", 0.5, new Records[] { new Records(2, 1), new Records(6, 2), new Records(3, 3) });
            Assert.AreEqual(5.756, CalculateAverageSpeed(Raul), 0.001);
            var Mihai = new Cyclist("Mihai", 0.8, new Records[] { new Records(5, 1), new Records(5, 2), new Records(5, 3) });
            Assert.AreEqual(12.56, CalculateAverageSpeed(Mihai), 0.001);
            var Darius = new Cyclist("Darius", 0.6, new Records[] { new Records(3, 1), new Records(2, 2), new Records(1, 3) });
            Assert.AreEqual(3.768, CalculateAverageSpeed(Darius), 0.001);
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
            new Cyclist("Raul", 0.5, new Records[] { new Records(2, 1), new Records(6, 2), new Records(3, 3) }) ,
            new Cyclist("Mihai", 0.8, new Records[] { new Records(5, 1), new Records(5, 2), new Records(5, 3) }),
            new Cyclist("Darius", 0.6, new Records[] { new Records(3, 1), new Records(2, 2), new Records(1, 3)}) };
            Assert.AreEqual(12.56, CalculateBestAverageSpeed(cyclists), 0.0001);
            Assert.AreEqual(cyclists[3], FindCyclistWithBestAverageSpeed(cyclists));
            Assert.AreEqual(0, GetMaxSpeedOfTheRace(cyclists));
        }
        [TestMethod]
        public void ShouldReturnMaxSpeedOfOneCyclist()
        {
            var Darius = new Cyclist("Darius", 0.6, new Records[] { new Records(3, 1), new Records(2, 2), new Records(1, 3) });
            Assert.AreEqual(5.652, CalculateMaxSpeedOfOneCyclist(Darius), 0.0001);
            var Raul = new Cyclist("Raul", 0.5, new Records[] { new Records(2, 1), new Records(6, 2), new Records(3, 3) });
            Assert.AreEqual(9.42, CalculateMaxSpeedOfOneCyclist(Raul));
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

        double CalculateMaxSpeedOfOneCyclist(Cyclist cyclist)
        {
            double maxSpeed = 0;
            double distance = 3.14 * cyclist.diameter;
            for (int i = 0; i < cyclist.records.Length; i++)
            {
                double speed = distance * cyclist.records[i].rotations;
                if (speed > maxSpeed)
                    maxSpeed = speed;
            }
            return maxSpeed;
        }

        double GetMaxSpeedOfTheRace(Cyclist[] cyclists)
        {
            double maxSpeed = 0;
            for (int i = 0; i < cyclists.Length; i++)
            {
                 double speed = CalculateMaxSpeedOfOneCyclist(cyclists[i]);
                if (speed > maxSpeed)
                    maxSpeed = speed;
            }
            return maxSpeed;
        }

    }
}
