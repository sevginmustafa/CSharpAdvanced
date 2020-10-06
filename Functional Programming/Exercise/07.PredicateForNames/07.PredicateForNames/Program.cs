using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var input = Console.ReadLine().Split().ToList();

            Func<int, List<string>, List<string>> func = (length, names) =>
            {
                List<string> result = new List<string>();

                for (int i = 0; i < names.Count; i++)
                {
                    if (length >= names[i].Length)
                    {
                        result.Add(names[i]);
                    }
                }

                return result;
            };

            Action<List<string>> print = x => Console.WriteLine(string.Join(Environment.NewLine, x));

            print(func(n, input));
        }
    }
}
