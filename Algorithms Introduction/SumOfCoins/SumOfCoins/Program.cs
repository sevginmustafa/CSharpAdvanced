using System;
using System.Collections.Generic;
using System.Linq;

namespace SumOfCoins
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(": ");
            string[] input2 = Console.ReadLine().Split(": ");

            int[] nums = input[1].Split(", ").Select(int.Parse).OrderByDescending(x => x).ToArray();
            int sum = int.Parse(input2[1]);

            Dictionary<int, int> result = new Dictionary<int, int>();

            while (sum > 0)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (sum >= nums[i])
                    {
                        if (!result.ContainsKey(nums[i]))
                        {
                            result.Add(nums[i], 0);
                        }

                        result[nums[i]]++;
                        sum -= nums[i];
                        break;
                    }
                    if (i == nums.Length - 1)
                    {
                        Console.WriteLine("Error");
                        return;
                    }
                }
            }

            Console.WriteLine($"Number of coins to take: {result.Sum(x => x.Value)}");

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Value} coin(s) with value {item.Key}");
            }
        }
    }
}
