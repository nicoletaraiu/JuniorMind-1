using System;
using System.Collections.Generic;
using Xunit;

namespace LinkedList
{
    public class LinkedListTests
    {
        List<int> list = new List<int>();
        [Fact]
        public void ShouldAddElement()
        {
            list.Add(7);
            list.Add(2);
            list.Add(4);
            Assert.Equal(3, list.Count);
        }
    }
}
