using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.PartyReservationFilterModule
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().ToList();
            string input = string.Empty;

            List<string> filteredNames = new List<string>();

            while ((input = Console.ReadLine()) != "Print")
            {
                string[] splittedInput = input.Split(";");

                string command = splittedInput[0];
                string filter = splittedInput[1];
                string parameter = splittedInput[2];

                var predicate = GetPredicate(filter, parameter);

                if (command == "Add filter")
                {
                    var temp = names.FindAll(predicate);

                    filteredNames.AddRange(temp);
                }
                else if (command == "Remove filter")
                {
                    filteredNames.RemoveAll(predicate);
                }
            }

            for (int i = 0; i < filteredNames.Count; i++)
            {
                names.Remove(filteredNames[i]);
            }

            Console.WriteLine(string.Join(' ', names));
        }

        static Predicate<string> GetPredicate(string filter, string parameter)
        {
            switch (filter)
            {
                case "Starts with": return x => x.StartsWith(parameter);
                case "Ends with": return x => x.EndsWith(parameter);
                case "Length": return x => x.Length == int.Parse(parameter);
                default: return x => x.Contains(parameter);
            }
        }
    }
}
