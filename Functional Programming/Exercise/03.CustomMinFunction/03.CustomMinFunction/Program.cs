using System;
using System.Linq;

namespace _03.CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Func<int[], int> printer = x => x.Min();

            Console.WriteLine(printer(nums));
        }
    }
}
