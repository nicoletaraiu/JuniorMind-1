using Hashtable;
using System;
using Xunit;
using System.Collections.Generic;
 
namespace Dictionary
{
    public class DictionaryTests
    {
        HashTable<int, string> table = new HashTable<int, string>();
        
        [Fact]
        public void ShouldCheckPairsPresence()
        {
            Assert.False(table.Contains(new KeyValuePair <int, string> (1, "abecedar")));
        }

        [Fact]
        public void NewElementsCanBeAdded()
        {
            table.Add(1, "Alpha");
            table.Add(2, "Bravo");
            table.Add(3, "Charlie");
            table.Add(11, "Delta");
            table.Add(22, "Echo");
            table.Add(5, "Foxtrot");
            table.Add(33, "Golf");
            table.Add(23, "Hotel");
            table.Add(4, "India");
            table.Add(15, "Juliet");
            Assert.Equal(10, table.Count);
            Assert.True(table.ContainsKey(4));
            Assert.False(table.ContainsKey(8));
        }
        [Fact]
        public void SameKey()
        {
            table.Add(4, "Alpha");
            table.Add(2, "Bravo");
            Assert.Throws<ArgumentException>(() => table.Add(4, "Charlie"));
            Assert.Throws<ArgumentException>(() => table.Add(2, "Juliet"));
        }
    }
}
