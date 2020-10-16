using System;
using System.Collections.Generic;

namespace _05.GenericCountMethodString
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

            Box<string> box = new Box<string>(list);

            string compare = Console.ReadLine();

            Console.WriteLine(box.Compare(compare));
        }
    }
}
