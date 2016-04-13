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
            list.Add(7);
            list.Add(2);
            list.Add(4);
            Assert.Equal(3, list.Count);
            Assert.Equal(1, list.IndexOf(2));
            Assert.Equal(2, list.IndexOf(4));
            Assert.Equal(-1, list.IndexOf(5));
            list.Clear();
            Assert.Equal(0, list.Count);
        }
    }
}
