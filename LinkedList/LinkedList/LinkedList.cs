using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class List<T> : LinkedList<T>
    {
        private Node<T> head;
        private Node<T> tail;
        private int count;

        public List()
        {
            this.head = null;
            this.tail = null;
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
                Node<T> currentNode = this.head;
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
                Node<T> currentNode = this.head;
                for (int i = 0; i < index; i++)
                {
                    currentNode = currentNode.Next;
                }
                currentNode.Element = value;
            }
        }

        public void Add(T item)
        {
            if (this.head == null)
            {
                this.head = new Node<T>(item);
                this.tail = this.head;
            }
            else
            {
                Node<T> newItem = new Node<T>(item, tail);
                this.tail = newItem;
            }
            count++;
        }

        public void Clear()
        {
            this.head = null;
            this.tail = null;
            this.count = 0;
        }

        public int IndexOf(T item)
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
}
