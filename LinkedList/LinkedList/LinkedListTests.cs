using System;
using System.Collections.Generic;
using Xunit;

namespace LinkedList
{
    public class LinkedListTests
    {
        List<int> list = new List<int>();
        [Fact]
        public void MultipleTests()
        {
            list.AddFirst(7);
            list.AddFirst(2);
            list.AddFirst(4);
            Assert.Equal(3, list.Count);
            Assert.True(list.Contains(2));
            Assert.False(list.Contains(5));
            Assert.Equal(1, list.IndexOf(2));
            Assert.Equal(-1, list.IndexOf(5));
            Assert.Equal(0, list.IndexOf(4));
            Assert.Equal(-1, list.IndexOf(14));
            list.AddFirst(9);
            Assert.Equal(0, list.IndexOf(9));
            list.AddFirst(15);
            Assert.Equal(0, list.IndexOf(15));
            Assert.Equal(1, list.IndexOf(9));
            list.Clear();
            Assert.Equal(0, list.Count);
        }
    }
}
