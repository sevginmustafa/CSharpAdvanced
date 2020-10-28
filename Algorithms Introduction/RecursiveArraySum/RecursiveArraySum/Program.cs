using System;
using System.Linq;

namespace RecursiveArraySum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Console.WriteLine(SumOfArray(nums, 0));
        }

        static int SumOfArray(int[] nums, int index)
        {
            if (index == nums.Length)
            {
                return 0;
            }

            return nums[index] + SumOfArray(nums, index + 1);
        }
    }
}
