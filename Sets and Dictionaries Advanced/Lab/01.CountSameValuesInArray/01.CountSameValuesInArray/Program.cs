using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountSameValuesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

            Dictionary<double, int> dictionary = new Dictionary<double, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (!dictionary.ContainsKey(numbers[i]))
                {
                    dictionary.Add(numbers[i], 0);
                }

                dictionary[numbers[i]] += 1;
            }

            foreach (var pair in dictionary)
            {
                Console.WriteLine($"{pair.Key} - {pair.Value} times");
            }
        }
    }
}
