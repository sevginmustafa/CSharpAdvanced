using System;
using System.Linq;

namespace _03.Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            Stack<int> stack = new Stack<int>();

            while ((input = Console.ReadLine()) != "END")
            {
                string[] command = input.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "Push")
                {
                    stack.Push(command.Skip(1).Select(int.Parse).ToArray());
                }
                else
                {
                    try
                    {
                        stack.Pop();
                    }
                    catch (InvalidOperationException io)
                    {
                        Console.WriteLine(io.Message);
                    }
                }
            }

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
