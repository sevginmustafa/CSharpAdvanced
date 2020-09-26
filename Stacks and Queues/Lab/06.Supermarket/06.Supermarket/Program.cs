using System;
using System.Collections.Generic;

namespace _06.Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();

            string name = Console.ReadLine();

            int counter = 0;

            while (name != "End")
            {
                if (name == "Paid")
                {
                    counter = 0;
                    while (queue.Count > 0)
                    {
                        Console.WriteLine(queue.Dequeue());
                    }
                }
                else
                {
                    counter++;
                    queue.Enqueue(name);
                }

                name = Console.ReadLine();
            }

            Console.WriteLine($"{counter} people remaining.");
        }
    }
}
