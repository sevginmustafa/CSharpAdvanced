using System;
using System.Collections.Generic;

namespace _07.SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            HashSet<string> vipGuests = new HashSet<string>();
            HashSet<string> guests = new HashSet<string>();

            while ((input = Console.ReadLine()) != "PARTY")
            {
                if (char.IsDigit(input[0]))
                {
                    vipGuests.Add(input);
                }
                else
                {
                    guests.Add(input);
                }
            }

            while ((input = Console.ReadLine()) != "END")
            {
                if (char.IsDigit(input[0]))
                {
                    vipGuests.Remove(input);
                }
                else
                {
                    guests.Remove(input);
                }
            }

            Console.WriteLine(vipGuests.Count + guests.Count);

            if (vipGuests.Count > 0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, vipGuests));
            }
            if (guests.Count > 0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, guests));
            }
        }
    }
}
