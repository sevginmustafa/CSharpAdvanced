using System;
using System.Collections.Generic;

namespace _05.CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            SortedDictionary<char, int> result = new SortedDictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {
                if (!result.ContainsKey(text[i]))
                {
                    result.Add(text[i], 0);
                }

                result[text[i]]++;
            }

            foreach (var symbol in result)
            {
                Console.WriteLine($"{symbol.Key}: {symbol.Value} time/s");
            }
        }
    }
}
