using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vector
{
    [TestClass]
    public class VectorTests
    {
        Vector<int> vector = new Vector<int>();
        [TestMethod]
        public void ShouldCountElements()
        {
            vector.Add(5);
            vector.Add(7);
            vector.Add(9);
            Assert.AreEqual(3, vector.Count);
        }
        [TestMethod]
        public void ShouldClearVector()
        {
            vector.Add(10);
            vector.Add(7);
            vector.Clear();
            Assert.AreEqual(0, vector.Count);
        }
        [TestMethod]
        public void ShouldCheckPresenceAndReturnIndex()
        {
            vector.Add(10);
            vector.Add(8);
            vector.Add(5);
            Assert.AreEqual(true, vector.Contains(8));
            Assert.IsFalse(vector.Contains(6));
            Assert.AreEqual(1, vector.IndexOf(8));
            Assert.AreEqual(2, vector.IndexOf(5));
            Assert.AreEqual(-1, vector.IndexOf(12));
        }
    }
}
