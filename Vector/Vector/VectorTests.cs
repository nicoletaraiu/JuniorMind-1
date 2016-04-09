using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vector
{
    [TestClass]
    public class VectorTests
    {
        Vector<int> vector = new Vector<int>();
        [TestMethod]
        public void ShouldCountElementsAndRemoveElement()
        {
            vector.Add(5);
            vector.Add(7);
            vector.Add(9);
            Assert.AreEqual(3, vector.Count);
            vector.RemoveAt(1);
            Assert.AreEqual(1, vector.IndexOf(9));
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
        public void MultipleTests()
        {
            vector.Add(10);
            vector.Add(8);
            vector.Add(5);
            Assert.AreEqual(true, vector.Contains(8));
            Assert.IsFalse(vector.Contains(6));
            Assert.AreEqual(1, vector.IndexOf(8));
            Assert.AreEqual(2, vector.IndexOf(5));
            Assert.AreEqual(-1, vector.IndexOf(12));
            Assert.IsFalse(vector.IsReadOnly);
            int[] target = new int[3];
            vector.CopyTo(target, 0);
            CollectionAssert.AreEqual(new int[] { 10, 8, 5 }, target);
            int[] secondTarget = new int[5];
            vector.CopyTo(secondTarget, 2);
            CollectionAssert.AreEqual(new int[] { 0, 0, 10, 8, 5 }, secondTarget);
        }
        [TestMethod]
        public void ShouldDoubleSize()
        {
            vector.Add(10);
            vector.Add(8);
            vector.Add(5);
            vector.Add(6);
            vector.Add(3);
            vector.Add(7);
            vector.Add(2);
            Assert.AreEqual(6, vector.IndexOf(2));
            vector.Insert(2, 15);
            Assert.AreEqual(2, vector.IndexOf(15));
            vector.Insert(5, 40);
            Assert.AreEqual(5, vector.IndexOf(40));
        }
    }
}
