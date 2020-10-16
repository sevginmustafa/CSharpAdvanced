using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.GenericSwapMethodString
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> list = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                list.Add(input);
            }

            int[] command = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Box.Swap(list, command[0], command[1]);

            foreach (var item in list)
            {
                Console.WriteLine($"{item.GetType().FullName}: {item}");
            }
        }
    }
}
