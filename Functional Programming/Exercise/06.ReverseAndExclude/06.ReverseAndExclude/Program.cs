using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            int n = int.Parse(Console.ReadLine());

            Func<List<int>, List<int>> reverse = numbers =>
            {
                List<int> reversed = new List<int>();

                for (int i = input.Count - 1; i >= 0; i--)
                {
                    reversed.Add(input[i]);
                }

                return reversed;
            };

            Action<List<int>> print = x => Console.WriteLine(string.Join(' ', x.Where(num => num % n != 0).ToList()));

            print(reverse(input));
        }
    }
}
