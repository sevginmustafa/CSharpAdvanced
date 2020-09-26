using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int n = array[0];
            int s = array[1];
            int x = array[2];

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < n; i++)
            {
                queue.Enqueue(numbers[i]);
            }
            for (int i = 0; i < s; i++)
            {
                queue.Dequeue();
            }

            if (queue.Count > 0)
            {
                int minValue = queue.Min();

                for (int i = 0; i < queue.Count; i++)
                {
                    if (x == queue.Dequeue())
                    {
                        Console.WriteLine("true");
                        return;
                    }
                }
                Console.WriteLine(minValue);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
