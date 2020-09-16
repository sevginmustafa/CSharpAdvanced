using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>();

            List<int> output = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                queue.Enqueue(nums[i]);

                if (nums[i] % 2 == 0)
                {
                    output.Add(nums[i]);
                }
            }

            Console.WriteLine(string.Join(", ", output));
        }
    }
}
