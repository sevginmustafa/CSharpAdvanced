using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.ListyIterator
{
    public class ListyIterator<T>
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
                Console.WriteLine("Invalid Operation!");
            }
            else
            {
                Console.WriteLine(list[index]);
            }
        }
    }
}
