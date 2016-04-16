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
            list.Clear();
            Assert.Equal(0, list.Count);
        }
    }
}
