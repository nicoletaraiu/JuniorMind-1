using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class List<T> : IEnumerable<T>, ICollection<T>
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

        public bool IsReadOnly
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public new void AddLast(T item)
        {
            Node<T> current = new Node<T>(item) { Previous = sentinel.Previous, Next = sentinel };
            Node<T> saved = sentinel.Previous;
            sentinel.Previous = current;
            saved.Next = current;
            count++;
        }

        public new void AddFirst(T item)
        {
            var current = new Node<T>(item) { Previous = sentinel, Next = sentinel.Next };
            Node<T> saved = sentinel.Next;
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
            Node<T> node = GetNodeOfValue(element);
            if (!(node.Equals(sentinel)))
                return true;
            return false;
        }

        public int IndexOf(T element)
        {
            Node<T> node = GetNodeOfValue(element);
            Node<T> current = sentinel.Next;
            int i = 0;
            while (!current.Equals(sentinel))
            {
                if (current.Element.Equals(node.Element))
                    return i;
                current = current.Next;
                i++;
            }
            return -1;
        }

        public void RemoveAt(int index)
        {
            Node<T> toBeRemoved = GetNodeAtIndex(index);
            RemoveNode(toBeRemoved);
        }

        private void RemoveNode(Node<T> toBeRemoved)
        {
            Node<T> prevSaved = toBeRemoved.Previous;
            Node<T> nextSaved = toBeRemoved.Next;
            prevSaved.Next = nextSaved;
            nextSaved.Previous = prevSaved;
            count--;
        }

        public bool Remove(T item)
        {
            Node<T> toBeRemoved = GetNodeOfValue(item);
            if (toBeRemoved.Equals(sentinel))
                return false;
            RemoveNode(toBeRemoved);
            return true;
        }

        public void Add(T item)
        {
            AddLast(item);
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node<T> node = sentinel.Next;
            while (node != sentinel)
            {
                yield return node.Element;
                node = node.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            Node<T> node = sentinel.Next;
            for (int i = arrayIndex; i < array.Length; i++)
            {
                if (!node.Equals(sentinel))
                {
                    array.SetValue(node.Element, i);
                    node = node.Next;
                }
                else throw new IndexOutOfRangeException();
            }
        }

        bool ICollection<T>.Remove(T item)
        {
            throw new NotImplementedException();
        }

        public Node<T> GetNodeAtIndex(int index)
        {
            Node<T> node = sentinel.Next;
            if (index <= count)
            {
                for (int i = 0; i < index; i++)
                {
                    node = node.Next;
                }
                return node;
            }
            throw new IndexOutOfRangeException();
        }

        public Node<T> GetNodeOfValue(T value)
        {
            Node<T> node = sentinel.Next;
            while (node != sentinel)
            {
                if (node.Element.Equals(value))
                    return node;
                node = node.Next;
            }
            return sentinel;
        }
    }
}
