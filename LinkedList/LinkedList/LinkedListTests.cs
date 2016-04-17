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
        public void IsEnumerable()
        {
            var list = new List<int>();
            Assert.Equal(new int[0], list);
        }

        [Fact]
        public void NewElementsCanBeAdded()
        {
            var list = new List<int> { 3, 5, 7 };
            Assert.Equal(3, list.Count);
            Assert.Equal(new[] { 3, 5, 7 }, list);
        }

        [Fact]
        public void ShouldReturnCount()
        {
            var list = new List<int> { 5, 1, 0 };
            Assert.Equal(3, list.Count);
        }

        [Fact]
        public void ContainReturnsTrueIfTheElementExists()
        {
            var list = new List<int> { 2, 1 };
            Assert.True(list.Contains(1));
        }
        [Fact]
        public void ContainsReturnsFalseIfTheElementDoesNotExist()
        {
            var list = new List<int> { 3, 4, 5 };
            Assert.False(list.Contains(1));
        }

        [Fact]
        public void ShouldReturnIndex()
        {
            var list = new List<int> { 3, 2 };
            Assert.Equal(1, list.IndexOf(2));
            Assert.Equal(-1, list.IndexOf(6));
        }

        [Fact]
        public void CanRemoveAllElements()
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
        [Fact]
        public void RemoveReturnsFalseIfTheElementDoesNotExist()
        {
            var list = new List<int> { 7, 2, 4, 15, 10 };
            Assert.True(list.Remove(4));
            Assert.False(list.Remove(20));
            Assert.False(list.Remove(6));
        }

        [Fact]
        public void NewElementsCanBeAddedAtTheBegining()
        {
            var list = new List<int> { 3, 5, 7 };
            list.AddFirst(9);
            Assert.Equal(4, list.Count);
            Assert.Equal(new[] { 9, 3, 5, 7 }, list);
        }

        [Fact]
        public void NewElementsCanBeAddedAtTheEnd()
        {
            var list = new List<int> { 3, 5, 7 };
            list.AddLast(9);
            Assert.Equal(4, list.Count);
            Assert.Equal(new[] { 3, 5, 7, 9 }, list);
        }

        [Fact]
        public void ShouldCopyElements()
        {
            var list = new List<int> { 4, 5, 6 };
            int[] array = { 1, 2, 3 };
            list.CopyTo(array, 1);
            Assert.Equal(new int[] { 1, 4, 5 }, array);
        }
    }
}
