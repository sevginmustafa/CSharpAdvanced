using System;
using System.Collections.Generic;
using System.Linq;

namespace SetCover
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(": ");
            string[] input2 = Console.ReadLine().Split(": ");

            List<int> universe = input[1].Split(", ").Select(int.Parse).ToList();
            int numOfSets = int.Parse(input2[1]);

            List<List<int>> sets = new List<List<int>>();
            List<List<int>> result = new List<List<int>>();

            for (int i = 0; i < numOfSets; i++)
            {
                List<int> set = Console.ReadLine().Split(", ").Select(int.Parse).ToList();

                sets.Add(set);
            }

            while (universe.Count > 0)
            {
                List<int> set = sets.OrderByDescending(x => x.Count(universe.Contains)).First();

                result.Add(set);
                sets.Remove(set);

                for (int i = 0; i < set.Count; i++)
                {
                    for (int j = 0; j < universe.Count; j++)
                    {
                        if (universe[j] == set[i])
                        {
                            universe.Remove(set[i]);
                            break;
                        }
                    }
                }
            }

            Console.WriteLine($"Sets to take ({result.Count}):");
            foreach (var item in result)
            {
                Console.WriteLine("{ " + string.Join(", ", item) + " }");
            }
        }
    }
}
