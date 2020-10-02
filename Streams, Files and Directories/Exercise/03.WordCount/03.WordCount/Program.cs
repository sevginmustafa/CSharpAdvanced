using System;
using System.Collections;
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
            string[] readerOne = File.ReadAllLines("../../../words.txt");
            string readerTwo = File.ReadAllText("../../../text.txt").ToLower();

            string[] actualResult = new string[readerOne.Length];
            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            for (int i = 0; i < readerOne.Length; i++)
            {
                MatchCollection matches = Regex.Matches(readerTwo, $@"\b{readerOne[i]}\b");

                if (matches[0].Success)
                {
                    actualResult[i] = $"{readerOne[i]} - {matches.Count}";
                }
            }

            File.WriteAllLines("../../../actualResult.txt", actualResult);

            for (int i = 0; i < actualResult.Length; i++)
            {
                string[] current = actualResult[i].Split(" - ");

                dictionary.Add(current[0], int.Parse(current[1]));
            }

            List<string> expectedResult = new List<string>();

            foreach (var item in dictionary.OrderByDescending(x => x.Value))
            {
                expectedResult.Add($"{item.Key} - {item.Value}");
            }

            File.WriteAllLines("../../../expectedResult.txt", expectedResult);
        }
    }
}
