using System;
using System.Collections.Generic;
using Xunit;
namespace Vector
{
    public class VectorTests
    {
        Vector<int> vector = new Vector<int>();
        [Fact]
        public void ShouldCountElementsAndRemoveElement()
        {
            vector.Add(5);
            vector.Add(7);
            vector.Add(9);
            Assert.Equal(3, vector.Count);
            vector.RemoveAt(1);
            Assert.Equal(1, vector.IndexOf(9));
            Assert.True(vector.Remove(5));
            Assert.False(vector.Remove(10));
        }
        [Fact]
        public void ShouldClearVector()
        {
            vector.Add(10);
            vector.Add(7);
            vector.Clear();
            Assert.Equal(0, vector.Count);
        }
        [Fact]
        public void MultipleTests()
        {
            vector.Add(10);
            vector.Add(8);
            vector.Add(5);
            Assert.Equal(true, vector.Contains(8));
            Assert.False(vector.Contains(6));
            Assert.Equal(1, vector.IndexOf(8));
            Assert.Equal(2, vector.IndexOf(5));
            Assert.Equal(-1, vector.IndexOf(12));
            Assert.False(vector.IsReadOnly);
            int[] target = new int[3];
            vector.CopyTo(target, 0);
            Assert.Equal(new int[] { 10, 8, 5 }, target);
            int[] secondTarget = new int[5];
            vector.CopyTo(secondTarget, 2);
            Assert.Equal(new int[] { 0, 0, 10, 8, 5 }, secondTarget);
        }
        [Fact]
        public void ShouldDoubleSize()
        {
            vector.Add(10);
            vector.Add(8);
            vector.Add(5);
            vector.Add(6);
            vector.Add(3);
            vector.Add(7);
            vector.Add(2);
            Assert.Equal(6, vector.IndexOf(2));
            vector.Insert(2, 15);
            Assert.Equal(2, vector.IndexOf(15));
            vector.Insert(5, 40);
            Assert.Equal(5, vector.IndexOf(40));
        }
        [Fact]
        public void GetEnumerator()
        {   
            vector.Add(10);
            vector.Add(8);
            vector.Add(5);
            vector.Add(6);
            vector.Add(3);
            IEnumerator<int> list = vector.GetEnumerator();
            Assert.Equal(new int[] { 10, 8, 5, 6, 3 }, vector);
        }
    }
}
