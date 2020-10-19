using System;
using System.Collections.Generic;

namespace _05.ComparingObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "END")
            {
                string[] info = input.Split();

                string name = info[0];
                int age = int.Parse(info[1]);
                string town = info[2];

                people.Add(new Person(name, age, town));
            }

            int position = int.Parse(Console.ReadLine());

            int countOfMatches = 0;

            for (int i = 0; i < people.Count; i++)
            {
                if (people[position - 1].CompareTo(people[i]) == 0)
                {
                    countOfMatches++;
                }
            }

            if (countOfMatches <= 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{countOfMatches} {people.Count - countOfMatches} {people.Count}");
            }
        }
    }
}
