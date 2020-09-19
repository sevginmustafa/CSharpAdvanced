using System;
using System.Collections.Generic;

namespace _08.BalancedParenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> stack = new Stack<char>();

            char[] input = Console.ReadLine().ToCharArray();

            if (input.Length % 2 == 1)
            {
                Console.WriteLine("NO");
                return;
            }

            bool isBalanced = true;

            for (int i = 0; i < input.Length; i++)
            {
                char current = input[i];

                if (current == '(' || current == '{' || current == '[')
                {
                    stack.Push(current);
                }
                else
                {
                    if (current == ')' && stack.Peek() == '(')
                    {
                        stack.Pop();
                    }
                    else if (current == '}' && stack.Peek() == '{')
                    {
                        stack.Pop();
                    }
                    else if (current == ']' && stack.Peek() == '[')
                    {
                        stack.Pop();
                    }
                    else
                    {
                        isBalanced = false;
                        break;
                    }
                }
            }

            if (isBalanced)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
