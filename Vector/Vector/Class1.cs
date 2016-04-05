using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector
{
    class IVector<T> : IList<T>
    {
        private IList<T> myList = new List<T>();
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
                return myList.Count;
                ///throw new NotImplementedException();
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
                ///throw new NotImplementedException();
            }
        }

        public void Add(T item)
        {
            myList.Add(item);
            ///throw new NotImplementedException();
        }

        public void Clear()
        {
            myList.Clear();
            ///throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            return (myList.Contains(item));
            ///throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            ///throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int IndexOf(T item)
        {
            throw new NotImplementedException();
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
