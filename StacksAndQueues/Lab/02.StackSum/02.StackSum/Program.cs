using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> stack = new Stack<int>(nums);

            string input = string.Empty;

            while ((input = Console.ReadLine().ToLower()) != "end")
            {
                string[] command = input.Split();

                if (command[0] == "add")
                {
                    int first = int.Parse(command[1]);
                    int second = int.Parse(command[2]);

                    stack.Push(first);
                    stack.Push(second);
                }
                else
                {
                    if (int.Parse(command[1]) <= stack.Count)
                    {
                        for (int i = 0; i < int.Parse(command[1]); i++)
                        {
                            stack.Pop();
                        }
                    }
                }
            }

            Console.WriteLine($"Sum: {stack.Sum()}");
        }
    }
}
