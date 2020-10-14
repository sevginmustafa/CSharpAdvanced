using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomStack
{
    public class MyStack
    {
        private const int INITIAL_CAPACITY = 4;
        private int[] items { get; set; }
        private int count { get; set; }

        public MyStack()
        {
            items = new int[INITIAL_CAPACITY];
        }

        public int Count
        {
            get
            {
                return count;
            }
        }

        public void Resize()
        {
            int[] copy = new int[items.Length * 2];

            for (int i = 0; i < items.Length; i++)
            {
                copy[i] = items[i];
            }

            items = copy;
        }

        public void Shrink()
        {
            int[] copy = new int[items.Length / 2];

            for (int i = 0; i < count; i++)
            {
                copy[i] = items[i];
            }

            items = copy;
        }

        public void Push(int item)
        {
            if (count == items.Length)
            {
                Resize();
            }

            items[count] = item;
            count++;
        }

        public int Pop()
        {
            if (count == 0)
            {
                throw new InvalidOperationException("CustomStack is empty");
            }

            if (count <= items.Length / 4)
            {
                Shrink();
            }

            int item = items[count - 1];
            items[count - 1] = default;

            count--;
            return item;
        }

        public int Peek()
        {
            if (count == 0)
            {
                throw new InvalidOperationException("CustomStack is empty");

            }

            return items[count - 1];
        }
    }
}
