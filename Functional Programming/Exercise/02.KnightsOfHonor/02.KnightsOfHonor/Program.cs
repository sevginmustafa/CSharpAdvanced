using System;

namespace _02.KnightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split();

            Action<string> printer = x => Console.WriteLine($"Sir {x}");

            for (int i = 0; i < names.Length; i++)
            {
                printer(names[i]);
            }
        }
    }
}
