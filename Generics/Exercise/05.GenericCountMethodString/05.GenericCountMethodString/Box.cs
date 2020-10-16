using System;
using System.Collections.Generic;
using System.Text;

namespace _05.GenericCountMethodString
{
    public class Box<T> where T : IComparable
    {
        private List<T> list;

        public Box(List<T> list)
        {
            this.list = list;
        }

        public int Compare(T element)
        {
            int counter = 0;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].CompareTo(element) > 0)
                {

                    counter++;
                }
            }

            return counter;
        }
    }
}
