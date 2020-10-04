using System;
using System.Linq;

namespace _03.CountUppercaseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, bool> checkUpper = x => char.IsUpper(x[0]);

            string[] text = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Where(checkUpper).ToArray();

            Console.WriteLine(string.Join(Environment.NewLine, text));
        }
    }
}
