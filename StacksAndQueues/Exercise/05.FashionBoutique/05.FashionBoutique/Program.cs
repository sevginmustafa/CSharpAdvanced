using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rackCapacity = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>(array);

            int counter = 1;
            int sum = rackCapacity;

            while (stack.Count > 0)
            {
                if (sum - stack.Peek() >= 0)
                {
                    sum -= stack.Pop();
                }
                else
                {
                    counter++;
                    sum = rackCapacity;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
