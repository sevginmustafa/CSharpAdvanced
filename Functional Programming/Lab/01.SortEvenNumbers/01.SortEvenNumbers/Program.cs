using System;
using System.Linq;

namespace _01.SortEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            Console.WriteLine(string.Join(", ", nums));
        }
    }
}
