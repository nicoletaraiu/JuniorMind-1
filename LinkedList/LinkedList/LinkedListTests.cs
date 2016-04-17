using System;
using System.Collections.Generic;
using Xunit;

namespace LinkedList
{
    public class LinkedListTests
    {
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
            List<int> list = new List<int>();
            list.AddLast(3);
            list.AddLast(2);
            Assert.Equal(1, list.IndexOf(2));
            Assert.Equal(-1, list.IndexOf(6));
        }
        [Fact]
        public void ShouldClear()
        {
            List<int> list = new List<int>();
            list.AddLast(3);
            list.AddLast(2);
            list.Clear();
            Assert.Equal(0, list.Count);
        }
        [Fact]
        public void ShouldAddFirst()
        {
            List < int > list = new List<int>();
            list.AddLast(3);
            list.AddLast(2);
            list.AddFirst(5);
            Assert.Equal(0, list.IndexOf(5));
        }
        [Fact]
        public void ShouldAddLast()
        {
            List<int> list = new List<int>();
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);
            Assert.Equal(2, list.IndexOf(3));
        }
        [Fact]
        public void ShouldRemoveNode()
        {
            List<int> list = new List<int>();
            list.AddLast(7);
            list.AddLast(2);
            list.AddLast(4);
            list.AddLast(15);
            list.AddLast(10);
            list.RemoveAt(3);
            Assert.False(list.Contains(15));
            Assert.True(list.Contains(4));
            list.RemoveAt(2);
            Assert.False(list.Contains(4));
        }
    }
}
