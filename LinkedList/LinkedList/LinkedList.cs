using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class List<T>
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

        public new void AddLast(T item)
        {
             Node<T> current = new Node<T>(item);
             Node<T> saved = sentinel.Previous;
             current.Previous = sentinel.Previous;
             current.Next = sentinel;
             sentinel.Previous = current;
             saved.Next = current;
             count++;
        }

        public new void AddFirst(T item)
        {
            Node<T> current = new Node<T>(item);
            Node<T> saved = sentinel.Next;
            current.Previous = sentinel;
            current.Next = sentinel.Next;
            sentinel.Next = current;
            saved.Previous = current;
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

        public int IndexOf(T element)
        {
            Node<T> current = sentinel.Next;
            int i = 0;
            while (i != count)
            {
                if (current.Element.Equals(element))
                    return i;
                current = current.Next;
                i++;
            }
            return -1;
        } 

        public void RemoveAt(int index)
        {
            Node<T> toBeRemoved = sentinel.Next;
            for (int i = 0; i < index; i++)
            {
                toBeRemoved = toBeRemoved.Next;
            }
            Node<T> prevSaved = toBeRemoved.Previous;
            Node<T> nextSaved = toBeRemoved.Next;
            prevSaved.Next = nextSaved;
            nextSaved.Previous = prevSaved;
            count--;
        }
        public void Remove(T item)
        {
            Node<T> toBeRemoved = sentinel.Next;
            for (int i = 0; i < count; i++)
            {
                if (toBeRemoved.Element.Equals(item))
                {
                    Node<T> prev = toBeRemoved.Previous;
                    Node<T> next = toBeRemoved.Next;
                    prev.Next = next;
                    next.Previous = prev;
                }
                toBeRemoved = toBeRemoved.Next;
            }
        }
    }
}
