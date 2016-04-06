using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vector
{
    [TestClass]
    public class VectorTests
    {
        [TestMethod]
        public void ShouldCountElements()
        {
            Vector<int> vector = new Vector<int>();
            vector.Add(5);
            vector.Add(7);
            vector.Add(9);
            Assert.AreEqual(3, vector.Count);
        }
        [TestMethod]
        public void ShouldClearVector()
        {
            Vector<int> vector = new Vector<int>();
            vector.Add(10);
            vector.Add(7);
            vector.Clear();
            Assert.AreEqual(0, vector.Count);
        }
    }
}
