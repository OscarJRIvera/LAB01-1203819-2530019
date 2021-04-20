using System;
using System.Collections;
using System.Collections.Generic;



namespace DoubleLinkedListLibrary1
{
    public class DoubleLinkedList<T>:IEnumerable<T>
    {
        Node<T> start;
        Node<T> end;
        int count;
        int eleminados=0;

        public DoubleLinkedList()
        {
            start = null;
            end = null;
            count = 0;
        }

        bool IsEmpty()
        {
            if (count - eleminados == 0)
            {
                return true;
            }
            return false;
        }
        
        public void Add(T dato)
        {
            Node<T> new_node= new Node<T>();
            new_node.Value = dato;

            if (IsEmpty())
            {
                start = new_node;
                end = new_node;
            }
            else
            {
                end.next = new_node;
                new_node.Behind = end;
                end = new_node;
            }

            count++;
            return;
        }

        public void RemoveAt(int index)
        {
            
            Node<T> actual;
            Node<T> anterior;
            actual = start;
            int i = 1;
            while (actual != null && i < index)
            {
                anterior = actual;
                actual = actual.next;
                i++;

            }
            if (actual == start)
            {
                if (start.next == null){
                    start = start.next;
                    eleminados++;
                }
                else{
                    start = start.next;
                    start.Behind = null;
                    eleminados++;
                }
            }
            else if (actual == end)
            {
                end = end.Behind;
                end.next = null;
                eleminados++;
            }
            else
            {
                actual.Behind.next = actual.next;
                actual.next.Behind = actual.Behind;
                eleminados++;
            }
        }
        public void Posi(int index,T model)
        {
            Node<T> actual;
            if (index == 1)
            {
                start.Value = model;
            }
            else
            {
                actual = start;
                for (int i = 1; i < index; i++)
                {

                    actual = actual.next;

                }
                actual.Value = model;
            }
        }
        public int Find2(Predicate<T> match)
        {
            Node<T> actual;
            actual = start;
            int i = 0;
            while (!match.Invoke(actual.Value))
            {
                i++;
                actual = actual.next;
            }
            return i;
        }
        public T Find(Predicate<T> match)
        {
            Node<T> actual;
            actual = start;
            int i = 1;
            while (actual != null)
            {
                if (match.Invoke(actual.Value)) //match es un delegado que verifica una condición
                {
                    return actual.Value;
                }
                actual = actual.next;
                i++;
            }
            return default(T);
        }
        public DoubleLinkedList<T> FindAll(Predicate<T> match)
        {
            DoubleLinkedList<T> resultados = new DoubleLinkedList<T>();
            Node<T> actual;
            actual = start;
            int i = 1;
            while (actual != null)
            {
                if (match.Invoke(actual.Value)) //match es un delegado que verifica una condición
                {
                    resultados.Add(actual.Value);
                }
                actual = actual.next;
                i++;
            }
            return resultados;
        }

        public int Count()
        {

            return count-eleminados;
        }
        public int Count2()
        {

            return count;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var Node = start;
            while (Node != null)
            {
                yield return Node.Value;
                Node = Node.next;
            }
        }
       IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
