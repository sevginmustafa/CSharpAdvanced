using System;
using System.Linq;

namespace _04.AddVAT
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, double> func = ParseAndAddVat;

            var nums = Console.ReadLine().Split(", ").Select(func).ToArray();

            foreach (var num in nums)
            {
                Console.WriteLine($"{num:f2}");
            }
        }

        public static double ParseAndAddVat(string num)
        {
            return double.Parse(num) * 1.2;
        }
    }
}
