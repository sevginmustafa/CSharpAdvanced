using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.ListyIterator
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private List<T> list;

        private int index = 0;

        public ListyIterator(params T[] array)
        {
            this.list = array.ToList();
        }

        public bool Move()
        {
            if (index + 1 < list.Count)
            {
                index++;
                return true;
            }

            return false;
        }

        public bool HasNext()
        {
            if (index + 1 < list.Count)
            {
                return true;
            }

            return false;
        }

        public void Print()
        {
            if (list.Count == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }

            Console.WriteLine(list[index]);
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
