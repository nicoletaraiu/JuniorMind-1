using Hashtable;
using System;
using Xunit;
using System.Collections.Generic;
 
namespace Dictionary
{
    public class DictionaryTests
    {
        [Fact]
        public void ShouldCheckKeysPresence()
        {
            HashTable<int, string> table = new HashTable<int, string>();
            Assert.False(table.ContainsKey(5));
        }
        [Fact]
        public void ShouldCheckPairsPresence()
        {
            HashTable<int, string> table = new HashTable<int, string>();
            Assert.False(table.Contains(new KeyValuePair <int, string> (1, "abecedar")));
        }
    }
}
