using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.PredicateParty_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> people = Console.ReadLine().Split().ToList();
            string input = Console.ReadLine();

            while (input != "Party!")
            {
                string[] command = input.Split();

                var predicate = GetPredicate(command[1], command[2]);

                switch (command[0])
                {
                    case "Remove":
                        people.RemoveAll(predicate);
                        break;
                    case "Double":
                        var matches = people.FindAll(predicate);

                        if (matches.Count > 0)
                        {
                            var findIndex = people.FindIndex(predicate);
                            people.InsertRange(findIndex, matches);
                        }
                        break;
                }

                input = Console.ReadLine();
            }

            if (people.Count > 0)
            {
                Console.WriteLine(string.Join(", ", people) + " are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }

        static Predicate<string> GetPredicate(string criteria, string symbol)
        {
            if (criteria == "StartsWith")
            {
                return name => name.StartsWith(symbol);
            }
            else if (criteria == "EndsWith")
            {
                return name => name.EndsWith(symbol);
            }
            else
            {
                return name => name.Length == int.Parse(symbol);
            }
        }
    }
}
