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
        public int countBuckets = 0;
        public int countEntries = 0;
        public int[] buckets = new int[10];
        public struct Entry
        {
            public TKey key;
            public TValue value;
            public int position;

            public Entry(TKey key, TValue value, int position)
            {
                this.key = key;
                this.value = value;
                this.position = position;
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
            buckets[countBuckets] = index;
            entries[countEntries] = new Entry(key, value, entries[index--].position);
            countBuckets++;
            countEntries++;
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
                if (buckets[key.GetHashCode()].Equals(key.GetHashCode()))
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
