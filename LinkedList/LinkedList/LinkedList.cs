using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class List<T> : LinkedList<T>
    {
        private Node<T> sentinel;
        private int count;

        public List()
        {
            sentinel = new Node<T>(default(T));
            sentinel.Next = sentinel;
            sentinel.Previous = sentinel;
            this.count = 0;
        }

        public int Count
        {
            get { return this.count; }
        }

        public T this[int index]
        {
            get
            {
                if (index >= count || index < 0)
                {
                    throw new ArgumentOutOfRangeException("Out of range.");
                }
                Node<T> currentNode = this.sentinel;
                for (int i = 0; i < index; i++)
                {
                    currentNode = currentNode.Next;
                }
                return currentNode.Element;
            }
            set
            {
                if (index >= count || index < 0)
                {
                    throw new ArgumentOutOfRangeException("Out of range.");
                }
                Node<T> currentNode = this.sentinel;
                for (int i = 0; i < index; i++)
                {
                    currentNode = currentNode.Next;
                }
                currentNode.Element = value;
            }
        }

        public void AddLast(T item)
        {
            count++;
        }

        public void Clear()
        {
            this.count = 0;
        }

        {
            int index = 0;
            Node<T> currentItem = this.head;
            while (currentItem != null)
            {
                if (((currentItem != null) && (item.Equals(currentItem.Element))) ||
                    ((currentItem.Element == null) && (item == null)))
                {
                    return index;
                }
                index++;
                currentItem = currentItem.Next;
            }
            return -1;
        }

        public bool Contains(T element)
        {
            int index = IndexOf(element);
            bool contains = (index != -1);
            return contains;
    }
}
