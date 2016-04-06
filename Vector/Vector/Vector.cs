using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector
{
    class Vector<T> : IList<T>
    {
        private T[] myList = new T[100];
        private int count = 0;

        public T this[int index]
        {
            get
            {
                return myList[index];
                ///throw new NotImplementedException();
            }

            set
            {
                myList[index] = value;
                ///throw new NotImplementedException();
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
                return false;
            }
        }

        public void Add(T item)
        {
            myList[count] = item;
            count++;
        }

        public void Clear()
        {
            count = 0;
        }

        public bool Contains(T item)
        {
            for (int i = 0; i < count; i++)
            {
                if (myList[i].Equals(item))
                    return true;
            }
            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            int j = arrayIndex;
            for (int i = 0; i < count; i++)
            {
                array.SetValue(myList[i], j);
                j++;
            }
            ///throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int IndexOf(T item)
        {
            for (int i = 0; i < count; i++)
            {
                if (myList[i].Equals(item))
                    return i;
            }
            return -1;
        }

        public void Insert(int index, T item)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
