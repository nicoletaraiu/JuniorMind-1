using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Node<T>
    {
        private T element;
        private Node<T> next;
        private Node<T> previous;

        public Node(T element)
        {
            this.element = element;
            this.next = null;
            this.previous = null;
        }

        public Node(T element, Node<T> previousNode)
        {
            this.element = element;
            this.previous = previousNode;
            previousNode.next = this;
        }

        public T Element
        {
            get { return this.element; }
            set { this.element = value; }
        }

        public Node<T> Next
        {
            get { return this.next; }
            set { this.next = value; }
        }

        public Node<T> Previous
        {
            get { return this.previous; }
            set { this.previous = value; }
        }
    }
}
