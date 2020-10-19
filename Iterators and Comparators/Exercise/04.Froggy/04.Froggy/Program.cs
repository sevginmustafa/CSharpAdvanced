using System;
using System.Linq;
using System.Text;

namespace _04.Froggy
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            Lake lake = new Lake(nums.ToList());

            Console.WriteLine(string.Join(", ",lake));
        }
    }
}
