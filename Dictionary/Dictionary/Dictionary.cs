using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashtable
{
    class HashTable<TKey, TValue> : IDictionary<TKey, TValue>
    {
        public int countEntries = 0;
        public int[] buckets;
        public HashTable(int capacity = 10)
        {
            buckets = new int[capacity];
            for (int i = 0; i < buckets.Length; i++)
            {
                buckets[i] = -1;
            }
        }
        public Entry[] entries = new Entry[10];
        public int count = 0;

        public TValue this[TKey key]
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public int Count
        {
            get
            {
                return count;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public ICollection<TKey> Keys
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public ICollection<TValue> Values
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Add(KeyValuePair<TKey, TValue> item)
        {
            throw new NotImplementedException();
        }

        public void Add(TKey key, TValue value)
        {
            if (ContainsKey(key))
                throw new ArgumentException();
            int index = key.GetHashCode() % buckets.Length;
            if (buckets[index] >= 0)
            {
                int existingValue = buckets[index];
                entries[existingValue].next = countEntries;
            }
            entries[countEntries] = new Entry(key, value, 0);
            buckets[index] = countEntries++;
            count++;
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(KeyValuePair<TKey, TValue> item)
        {
            int index = item.Key.GetHashCode() % buckets.Length;
            if (buckets[index] > -1)
            {
                if (entries[buckets[index]].value.Equals(item.Value))
                    return true;
            }

            return false;
        }

        public bool ContainsKey(TKey key)
        {
            int index = key.GetHashCode() % buckets.Length;
            if (buckets[index] > -1)
            {
                if (entries[buckets[index]].key.Equals(key))
                    return true;
            }
                
            return false;
        }

        public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool Remove(KeyValuePair<TKey, TValue> item)
        {
            throw new NotImplementedException();
        }

        public bool Remove(TKey key)
        {
            throw new NotImplementedException();
        }

        public bool TryGetValue(TKey key, out TValue value)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public struct Entry
        {
            public TKey key;
            public TValue value;
            public int next;

            public Entry(TKey key, TValue value, int next)
            {
                this.key = key;
                this.value = value;
                this.next = next;
            }
        }
    }
}
