using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.CupsAndBottles
{
    class Program
    {
        static void Main(string[] args)
        {
            var cupsCapaciyty = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var filledBottles = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> bottles = new Stack<int>(filledBottles);
            Queue<int> cups = new Queue<int>(cupsCapaciyty);

            int wastedWater = 0;

            while (cups.Count > 0 && bottles.Count > 0)
            {
                if (bottles.Peek() >= cups.Peek())
                {
                    wastedWater += bottles.Pop() - cups.Dequeue();
                }
                else
                {
                    int check = 0;

                    while (true)
                    {
                        check += bottles.Pop();

                        if (check >= cups.Peek())
                        {
                            wastedWater += check - cups.Dequeue();
                            break;
                        }
                    }
                }
            }

            if (cups.Count == 0)
            {
                Console.WriteLine($"Bottles: {string.Join(" ", bottles)}");
                Console.WriteLine($"Wasted litters of water: {wastedWater}");
            }
            else
            {
                Console.WriteLine($"Cups: {string.Join(" ", cups)}");
                Console.WriteLine($"Wasted litters of water: {wastedWater}");
            }
        }
    }
}
