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
            Node<T> current = new Node<T>(item);
            current.Previous = sentinel;
            current.Next = sentinel.Next;
            sentinel.Next = current;
            current.Previous.Previous = current;
            count++;
        }

        public void Clear()
        {
            this.count = 0;
        }

        public bool Contains(T element)
        {
            Node<T> current = sentinel.Next;
            while (!(current.Equals(sentinel)))
            {
                if (current.Element.Equals(element))
                    return true;
                current = current.Next;
            }
            return false;
        } 
    }
}
