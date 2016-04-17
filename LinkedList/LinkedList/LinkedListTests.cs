using System;
using System.Collections.Generic;
using Xunit;

namespace LinkedList
{
    public class LinkedListTests
    {
        [Fact]
        public void EmptyListHasZeroElements()
        {
            var list = new List<int>();
            Assert.Equal(0, list.Count);
        }
        [Fact]
        public void ShouldReturnCount()
        {
            List<int> list = new List<int>();
            list.AddLast(5);
            list.AddLast(1);
            list.AddLast(0);
            Assert.Equal(3, list.Count);
        }
        [Fact]
        public void ShouldCheckExistence()
        {
            List<int> list = new List<int>();
            list.AddLast(2);
            list.AddLast(1);
            Assert.True(list.Contains(1));
            Assert.False(list.Contains(0));
        }
        [Fact]
        public void ShouldReturnIndex()
        {
            var list = new List<int> { 3, 2 };
            Assert.Equal(1, list.IndexOf(2));
            Assert.Equal(-1, list.IndexOf(6));
        }
        [Fact]
        public void ShouldClear()
        {
            var list = new List<int> { 3, 2 };
            list.Clear();
            Assert.Equal(0, list.Count);
        }
        [Fact]
        public void ShouldAddFirst()
        {
            var list = new List<int> { 5, 3, 2 };
            Assert.Equal(0, list.IndexOf(5));
        }
        [Fact]
        public void ShouldAddLast()
        {
            var list = new List<int> { 1, 2, 3 };
            Assert.Equal(2, list.IndexOf(3));
        }
        [Fact]
        public void TheFirstElementCanBeRemoved()
        {
            var list = new List<int> { 7, 2, 4, 15, 10 };
            Assert.Equal(0, list.IndexOf(7));
            list.RemoveAt(0);
            Assert.Equal(0, list.IndexOf(2));
        }
        [Fact]
        public void TheLastElementCanBeRemoved()
        {
            var list = new List<int> { 7, 2, 4, 15, 10 };
            Assert.Equal(4, list.IndexOf(10));
            list.RemoveAt(4);
            Assert.False(list.Contains(10));
        }
        [Fact]
        public void CanRemoveAnElementWithGivenValue()
        {
            var list = new List<int> { 7, 2, 4, 15, 10 };
            Assert.True(list.Contains(4));
            list.Remove(4);
            Assert.False(list.Contains(4));
        }
    }
}
