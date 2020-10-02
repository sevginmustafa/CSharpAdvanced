using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = File.ReadAllText("../../../words.txt").ToLower().Split();
            string text = File.ReadAllText("../../../text.txt").ToLower();

            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];

                MatchCollection matches = Regex.Matches(text, $@"\b{word}\b");

                if (matches[0].Success)
                {
                    dictionary.Add(word, matches.Count);
                }
            }

            List<string> result = new List<string>();

            foreach (var item in dictionary.OrderByDescending(x => x.Value))
            {
                result.Add($"{item.Key} - {item.Value}");
            }

            File.WriteAllLines("../../../result.txt", result);
        }
    }
}
