using System;

namespace _01.ActionPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> printer = x => Console.WriteLine(x);

            string[] input = Console.ReadLine().Split();

            for (int i = 0; i < input.Length; i++)
            {
                printer(input[i]);
            }
        }
    }
}
