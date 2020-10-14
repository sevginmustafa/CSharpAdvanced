using System;

namespace CustomStack
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack stack = new MyStack();

            for (int i = 0; i < 4; i++)
            {
                stack.Push(i);
            }

            stack.Pop();
            stack.Pop();
            stack.Pop();
            stack.Pop();
            Console.WriteLine(stack.Peek());
        }
    }
}
