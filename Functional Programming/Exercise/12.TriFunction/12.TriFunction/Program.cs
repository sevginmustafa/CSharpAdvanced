using System;
using System.Linq;

namespace _12.TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var input = Console.ReadLine().Split();

            Func<string, int, bool> firstValidName = (name, sum) =>
              {
                  int sumOfChars = 0;

                  for (int i = 0; i < name.Length; i++)
                  {
                      sumOfChars += name[i];
                  }

                  return sum <= sumOfChars;
              };

            Func<string[], int, Func<string, int, bool>, string> result = (names, sum, func) =>
             {
                 return names.FirstOrDefault(x => func(x, sum));
             };

            Console.WriteLine(result(input, n, firstValidName));
        }
    }
}
