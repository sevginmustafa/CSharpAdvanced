using System;
using System.Collections.Generic;
using System.Text;

namespace CustomLinkedList
{
    public class LinkedList
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }

        public void AddFirst(Node newHead)
        {
            if (Head == null)
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
        }

        public void AddLast(Node newTail)
        {
            if (Tail == null)
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
        }

        public void ForEach(Action<Node> action)
        {
            Node node = Head;
            while (node != null)
            {
                action(node);
                node = node.Next;
            }
        }

        public void Print()
        {
            ForEach(x => Console.WriteLine(x));
        }

        public void ReversedPrint()
        {
            Node node = Tail;

            while (node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Previous;
            }
        }

        public int Peek()
        {
            return Head.Value;
        }

        public Node RemoveFirst()
        {
            Node oldHead = Head;
            Head = oldHead.Next;
            Head.Previous = null;
            return oldHead;
        }

        public Node RemoveLast()
        {
            Node oldTail = Tail;
            Tail = oldTail.Previous;
            Tail.Next = null;
            return oldTail;
        }

        public Node[] ToArray()
        {
            List<Node> list = new List<Node>();

            ForEach(x => list.Add(x));

            return list.ToArray();
        }

    }
}
