using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.KeyRevolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int barrelSize = int.Parse(Console.ReadLine());
            var bullets = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var locks = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int intelligenceValue = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>(bullets);
            Queue<int> queue = new Queue<int>(locks);

            int barrelCounter = barrelSize;

            while (true)
            {
                while (barrelCounter > 0 && stack.Count > 0)
                {
                    intelligenceValue -= bulletPrice;
                    barrelCounter--;

                    if (stack.Pop() <= queue.Peek())
                    {
                        Console.WriteLine("Bang!");
                        queue.Dequeue();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Ping!");
                    }
                }

                if (barrelCounter == 0 && stack.Count > 0)
                {
                    barrelCounter = barrelSize;
                    Console.WriteLine("Reloading!");
                }
                if (queue.Count == 0)
                {
                    Console.WriteLine($"{stack.Count} bullets left. Earned ${intelligenceValue}");
                    return;
                }
                if (stack.Count == 0)
                {
                    Console.WriteLine($"Couldn't get through. Locks left: {queue.Count}");
                    return;
                }
            }
        }
    }
}
