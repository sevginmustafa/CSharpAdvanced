using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MaximumAndMinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split();

                if (int.Parse(command[0]) == 1)
                {
                    stack.Push(int.Parse(command[1]));
                }
                else if (int.Parse(command[0]) == 2 && stack.Count > 0)
                {
                    stack.Pop();
                }
                else if (int.Parse(command[0]) == 3 && stack.Count > 0)
                {
                    Console.WriteLine(stack.Max());
                }
                else if (int.Parse(command[0]) == 4 && stack.Count > 0)
                {
                    Console.WriteLine(stack.Min());
                }
            }

            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
