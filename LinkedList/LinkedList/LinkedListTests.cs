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
            list.AddLast(7);
            list.AddLast(2);
            list.AddLast(4);
            Assert.Equal(3, list.Count);
            Assert.True(list.Contains(2));
            Assert.False(list.Contains(5));
            Assert.Equal(1, list.IndexOf(2));
            Assert.Equal(-1, list.IndexOf(5));
            Assert.Equal(0, list.IndexOf(4));
            Assert.Equal(-1, list.IndexOf(14));
            list.Clear();
            Assert.Equal(0, list.Count);
        }
    }
}
