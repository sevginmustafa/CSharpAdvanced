using System;
using System.Linq;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            MergeSort<int>.Sort(input);

            Console.WriteLine(string.Join(" ", input));

        }
    }
}
