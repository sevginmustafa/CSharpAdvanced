using System;
using System.Collections.Generic;

namespace _09.SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Stack<string> stack = new Stack<string>();

            string text = string.Empty;

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split();

                if (command[0] == "1")
                {
                    text += command[1];

                    stack.Push(text);
                }
                else if (command[0] == "2")
                {
                    int deleteCount = int.Parse(command[1]);

                    text = text.Remove(text.Length - deleteCount, deleteCount);

                    stack.Push(text);
                }
                else if (command[0] == "3")
                {
                    Console.WriteLine(text[int.Parse(command[1]) - 1]);
                }
                else if (command[0] == "4")
                {
                    if (stack.Count > 1)
                    {
                        stack.Pop();
                        text = stack.Peek();
                    }
                    else
                    {
                        text = string.Empty;
                    }
                }
            }
        }
    }
}
