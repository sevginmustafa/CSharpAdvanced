using System;
using System.Collections.Generic;

namespace _01.ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<char> stack = new Stack<char>();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                stack.Push(input[i]);
                Console.Write(stack.Pop());
            }
        }
    }
}
