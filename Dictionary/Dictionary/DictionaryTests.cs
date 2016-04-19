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
        public void ShouldCheckKeysPresence()
        {
            Assert.False(table.ContainsKey(5));
        }

        [Fact]
        public void ShouldCheckPairsPresence()
        {
            Assert.False(table.Contains(new KeyValuePair <int, string> (1, "abecedar")));
        }

        [Fact]
        public void NewElementsCanBeAdded()
        {
            table.Add(1, "abecedar");
            table.Add(2, "roman");
            table.Add(3, "nuvela");
            table.Add(1, "balada");
            table.Add(2, "poezie");
            table.Add(5, "drama");
            table.Add(3, "thriller");
            table.Add(3, "politist");
            table.Add(4, "SF");
            table.Add(5, "electronica");
            Assert.Equal(10, table.Count);
        }
    }
}
