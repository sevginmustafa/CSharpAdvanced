using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FindEvensOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            var ranges = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();

            int start = ranges[0];
            int end = ranges[1];

            Func<int, int, List<int>> generateList = (start, end) =>
            {
                List<int> nums = new List<int>();

                for (int i = start; i <= end; i++)
                {
                    nums.Add(i);
                }

                return nums;
            };

            List<int> numbers = generateList(start, end);

            Predicate<int> checkEven = x => x % 2 == 0;

            if (command == "odd")
            {
                checkEven = x => x % 2 != 0;
            }

            numbers = MyWhere(numbers, checkEven);

            Console.WriteLine(string.Join(' ', numbers));
        }

        static List<int> MyWhere(List<int> nums, Predicate<int> checkEven)
        {
            List<int> result = new List<int>();

            foreach (var num in nums)
            {
                if (checkEven(num))
                {
                    result.Add(num);
                }
            }

            return result;
        }
    }
}
