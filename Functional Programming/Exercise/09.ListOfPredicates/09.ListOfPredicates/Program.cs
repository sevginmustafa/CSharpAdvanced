using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

            Func<int, List<int>, bool> func = (number, dividers) =>
            {
                foreach (var divider in dividers)
                {
                    if (number % divider != 0)
                    {
                        return false;
                    }
                }

                return true;
            };

            Func<int, List<int>> generateList = x =>
            {
                List<int> numbers = new List<int>();

                for (int i = 1; i <= x; i++)
                {
                    if (func(i, input))
                    {
                        numbers.Add(i);
                    }
                }

                return numbers;
            };

            List<int> result = generateList(n);

            Console.WriteLine(string.Join(' ', result));
        }
    }
}
