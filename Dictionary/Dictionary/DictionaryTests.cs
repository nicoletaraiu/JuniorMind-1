using Hashtable;
using System;
using Xunit;
 
namespace Dictionary
{
    public class DictionaryTests
    {
        [Fact]
        public void NewEntriesCanBeAdded()
        {
            HashTable<int, string> table = new HashTable<int, string>();
            Assert.False(table.ContainsKey(5));
        }
    }
}
