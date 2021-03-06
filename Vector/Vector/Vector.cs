﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector
{
    class Vector<T> : IList<T>
    {
        private T[] list = new T[5];
        private int count = 0;

        public T this[int index]
        {
            get
            {
                return list[index];
                ///throw new NotImplementedException();
            }

            set
            {
                list[index] = value;
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
            
            if (count == list.Length)
                Array.Resize(ref list, list.Length * 2);
            list[count] = item;
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
                if (list[i].Equals(item))
                    return true;
            }
            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            int j = arrayIndex;
            for (int i = 0; i < count; i++)
            {
                array.SetValue(list[i], j);
                j++;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
                yield return list[i];
        }

        public int IndexOf(T item)
        {
            for (int i = 0; i < count; i++)
            {
                if (list[i].Equals(item))
                    return i;
            }
            return -1;
        }

        public void Insert(int index, T item)
        {
            for (int i = 0; i < count; i++)
            {
                if (i == index)
                list[i] = item;
            }
        }

        public bool Remove(T item)
        {
            for (int i = 0; i < count; i++)
            {
                if (list[i].Equals(item))
                {
                    RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        public void RemoveAt(int index)
        {
            for (int i = index; i < count; i++)
            {
                list[i] = list[i + 1]; 
            }
            Array.Resize(ref list, list.Length - 1);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }
    }
}
