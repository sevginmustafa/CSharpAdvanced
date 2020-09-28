using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contests = new Dictionary<string, string>();
            Dictionary<string, Dictionary<string, int>> contestants = new Dictionary<string, Dictionary<string, int>>();

            string inputOne = string.Empty;

            while ((inputOne = Console.ReadLine()) != "end of contests")
            {
                string[] splitted = inputOne.Split(':');

                string contest = splitted[0];
                string password = splitted[1];

                if (!contests.ContainsKey(contest))
                {
                    contests.Add(contest, password);
                }

                contests[contest] = password;
            }

            string inputTwo = string.Empty;

            while ((inputTwo = Console.ReadLine()) != "end of submissions")
            {
                string[] splitted = inputTwo.Split("=>");

                string contest = splitted[0];
                string password = splitted[1];
                string username = splitted[2];
                int points = int.Parse(splitted[3]);

                if (contests.ContainsKey(contest))
                {
                    if (contests[contest] == password)
                    {
                        if (!contestants.ContainsKey(username))
                        {
                            contestants.Add(username, new Dictionary<string, int>());
                        }
                        if (!contestants[username].ContainsKey(contest))
                        {
                            contestants[username].Add(contest, points);
                        }
                        if (points > contestants[username][contest])
                        {
                            contestants[username][contest] = points;
                        }
                    }
                }
            }

            string maxContestant = string.Empty;
            int maxPoints = int.MinValue;

            foreach (var contestant in contestants)
            {
                if (contestant.Value.Values.Sum() > maxPoints)
                {
                    maxPoints = contestant.Value.Values.Sum();
                    maxContestant = contestant.Key;
                }
            }

            Console.WriteLine($"Best candidate is {maxContestant} with total {maxPoints} points.");
            Console.WriteLine("Ranking: ");

            foreach (var contestant in contestants.OrderBy(x => x.Key))
            {
                Console.WriteLine(contestant.Key);

                foreach (var contest in contestant.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }
        }
    }
}
