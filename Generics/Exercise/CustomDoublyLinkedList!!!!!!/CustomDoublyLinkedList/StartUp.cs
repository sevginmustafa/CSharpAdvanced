using System;

namespace CustomDoublyLinkedList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            LinkedList<string> list = new LinkedList<string>();

            list.AddFirst(new Node<string>("Sevgin"));
            list.AddFirst(new Node<string>("Sezgin"));
            list.AddFirst(new Node<string>("Mustafa"));


            list.Print();
            Console.WriteLine(list.RemoveLast());
        }
    }
}
