using System;
using System.Collections.Generic;
using System.Text;


namespace DoubleLinkedListLibrary1
{
   public class Node<T>
    {
        public T Value;

        public Node<T> next;
        public Node<T> Behind;
        public Node()
        {
            this.next = null;
            this.Behind = null;
        }
    }
}
