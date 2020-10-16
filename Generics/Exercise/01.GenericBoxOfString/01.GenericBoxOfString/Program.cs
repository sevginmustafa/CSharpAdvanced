using System;
using System.Xml;

namespace _01.GenericBoxOfString
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                Box<string> box = new Box<string>(input);

                Console.WriteLine(box);
            }
        }
    }
}
