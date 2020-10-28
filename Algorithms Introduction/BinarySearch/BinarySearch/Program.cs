using System;
using System.Linq;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(Search(nums, n));
        }

        static int Search(int[] nums, int key)
        {
            int start = 0;
            int end = nums.Length - 1;

            while (start <= end)
            {
                int middle = (end + start) / 2;

                if (key < nums[middle])
                {
                    end = middle - 1;
                }
                else if (key > nums[middle])
                {
                    start = middle + 1;
                }
                else
                {
                    return middle;
                }
            }

            return -1;
        }
    }
}
