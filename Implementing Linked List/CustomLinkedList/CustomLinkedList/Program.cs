using System;

namespace CustomLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();

            for (int i = 1; i <= 10; i++)
            {
                linkedList.AddLast(new Node(i));
            }

            linkedList.RemoveFirst();

            linkedList.Print();
        }
    }
}
