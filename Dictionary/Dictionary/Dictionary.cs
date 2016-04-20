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
        public int[] buckets = new int[10];
        public HashTable()
        {
            for (int i = 0; i < buckets.Length; i++)
            {
                buckets[i] = -1;
            }
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
            int index = key.GetHashCode();
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
            int i = item.Key.GetHashCode();
            if (item.Key.Equals(entries[i].key) && (item.Value.Equals(entries[i].value)))
                return true;
            return false;
        }

        public bool ContainsKey(TKey key)
        {
            int index = key.GetHashCode();
            if (buckets[index] > -1)
                return true;
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
    }
}
