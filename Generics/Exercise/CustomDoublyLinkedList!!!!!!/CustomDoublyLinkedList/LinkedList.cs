using System;
using System.Collections.Generic;
using System.Text;

namespace CustomDoublyLinkedList
{
    public class LinkedList<T>
    {
        public Node<T> Head { get; set; }

        public Node<T> Tail { get; set; }

        public int Count { get; private set; }

        public void AddFirst(Node<T> newHead)
        {
            if (Count == 0)
            {
                Head = newHead;
                Tail = newHead;
            }
            else
            {
                newHead.Next = Head;
                Head.Previous = newHead;
                Head = newHead;
            }
            Count++;
        }

        public void AddLast(Node<T> newTail)
        {
            if (Count == 0)
            {
                Head = newTail;
                Tail = newTail;
            }
            else
            {
                newTail.Previous = Tail;
                Tail.Next = newTail;
                Tail = newTail;
            }
            Count++;
        }

        public T RemoveFirst()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("The list is empty");
            }

            T old = Head.Value;
            Head = Head.Next;
            if (Head != null)
            {
                Head.Previous = null;
            }
            else
            {
                Tail = null;
            }
            Head.Previous = null;
            Count--;
            return old;
        }

        public T RemoveLast()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("The list is empty");
            }

            T old = Tail.Value;
            Tail = Tail.Previous;
            if (Tail != null)
            {
                Tail.Next = null;
            }
            else
            {
                Head = null;
            }
            Tail.Next = null;
            Count--;
            return old;
        }

        public void ForEach(Action<Node<T>> action)
        {
            Node<T> node = Head;

            while (Head != null)
            {
                action(node);
                node = node.Next;
            }
        }

        public Node<T>[] ToArray()
        {
            List<Node<T>> list = new List<Node<T>>();

            ForEach(x => list.Add(x));

            return list.ToArray();
        }

        public void Print()
        {
            Node<T> node = Head;

            while (node != null)
            {
                Console.WriteLine(node.Value);

                node = node.Next;
            }
        }

        public void PrintReversed()
        {
            Node<T> node = Tail;

            while (node != null)
            {
                Console.WriteLine(node.Value);

                node = node.Previous;
            }
        }
    }
}
