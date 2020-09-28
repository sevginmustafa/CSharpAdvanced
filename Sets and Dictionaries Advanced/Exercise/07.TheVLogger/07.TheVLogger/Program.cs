using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.TheVLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Vloger> vloggers = new Dictionary<string, Vloger>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Statistics")
            {
                string[] splittedInput = input.Split();

                string vloggerName = splittedInput[0];
                string command = splittedInput[1];
                string vloggerName2 = splittedInput[2];

                if (command == "joined")
                {
                    if (!vloggers.ContainsKey(vloggerName))
                    {
                        vloggers.Add(vloggerName, new Vloger());
                        vloggers[vloggerName].Followers = new List<string>();
                        vloggers[vloggerName].Following = new List<string>();
                    }
                }
                else if (command == "followed")
                {
                    if (vloggers.ContainsKey(vloggerName) && vloggers.ContainsKey(vloggerName2))
                    {
                        if (vloggerName != vloggerName2)
                        {
                            if (!vloggers[vloggerName2].Followers.Contains(vloggerName))
                            {
                                vloggers[vloggerName2].Followers.Add(vloggerName);
                                vloggers[vloggerName].Following.Add(vloggerName2);
                            }
                        }
                    }
                }
            }

            int counter = 0;

            Console.WriteLine($"The V-Logger has a total of {vloggers.Count} vloggers in its logs.");

            foreach (var vlogger in vloggers.OrderByDescending(x => x.Value.Followers.Count).ThenBy(x => x.Value.Following.Count))
            {
                counter++;

                Console.WriteLine($"{counter}. {vlogger.Key} : {vlogger.Value.Followers.Count} followers, {vlogger.Value.Following.Count} following");

                if (counter == 1)
                {
                    foreach (var item in vlogger.Value.Followers.OrderBy(x => x))
                    {
                        Console.WriteLine("*  " + item);
                    }
                }
            }
        }

        public class Vloger
        {
            public List<string> Followers { get; set; }

            public List<string> Following { get; set; }
        }
    }
}
