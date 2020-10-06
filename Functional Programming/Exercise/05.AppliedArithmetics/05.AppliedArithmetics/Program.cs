using System;
using System.Linq;

namespace _05.AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string command = Console.ReadLine();

            Func<int, int> add = x => x + 1;
            Func<int, int> multiply = x => x * 2;
            Func<int, int> subtract = x => x - 1;
            Action<int[]> print = x => Console.WriteLine(string.Join(' ', x));

            while (command != "end")
            {
                if (command == "add")
                {
                    nums = nums.Select(add).ToArray();
                }
                else if (command == "multiply")
                {
                    nums = nums.Select(multiply).ToArray();
                }
                else if (command == "subtract")
                {
                    nums = nums.Select(subtract).ToArray();
                }
                else if (command == "print")
                {
                    print(nums);
                }

                command = Console.ReadLine();
            }
        }
    }
}
