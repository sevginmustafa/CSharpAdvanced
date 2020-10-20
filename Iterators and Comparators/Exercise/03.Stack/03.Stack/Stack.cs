using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.Stack
{
    public class Stack<T> : IEnumerable<T>
    {
        private List<T> list;

        public Stack()
        {
            list = new List<T>();
        }

        public void Push(params T[] array)
        {
            list.InsertRange(0, array.Reverse());
        }

        public T Pop()
        {
            if (list.Count == 0)
            {
                throw new InvalidOperationException("No elements");
            }

            T removed = list[0];
            list.RemoveAt(0);

            return removed;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < list.Count; i++)
            {
                yield return list[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
