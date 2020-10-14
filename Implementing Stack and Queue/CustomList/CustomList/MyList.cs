using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;

namespace CustomList
{
    public class MyList
    {
        private const int INITIAL_CAPACITY = 2;

        private int[] items;

        public int Count { get; set; }

        public MyList()
        {
            items = new int[INITIAL_CAPACITY];
        }

        public int this[int index]
        {
            get
            {
                if (index < 0 || index >= items.Length)
                {
                    throw new ArgumentOutOfRangeException();
                }

                return items[index];
            }
            set
            {
                if (index < 0 || index >= items.Length)
                {
                    throw new ArgumentOutOfRangeException();
                }

                items[index] = value;
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

            for (int i = 0; i < Count; i++)
            {
                copy[i] = items[i];
            }

            items = copy;
        }

        public void Add(int item)
        {
            if (Count == items.Length)
            {
                Resize();
            }

            items[Count] = item;
            Count++;
        }

        public void ShiftToLeft(int index)
        {
            for (int i = index; i < Count; i++)
            {
                items[i] = items[i + 1];
            }
        }

        public void ShiftToRight(int index)
        {
            for (int i = Count; i > index; i--)
            {
                items[i] = items[i - 1];
            }
        }

        public int RemoveAt(int index)
        {
            if (index < 0 || index >= Count)
            {
                throw new ArgumentOutOfRangeException();
            }

            int item = items[index];
            items[index] = 0;
            ShiftToLeft(index);

            Count--;

            if (Count <= items.Length / 4)
            {
                Shrink();
            }

            return item;
        }

        public void Insert(int index, int item)
        {
            if (index < 0 || index >= Count)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (Count == items.Length)
            {
                Resize();
            }

            ShiftToRight(index);
            items[index] = item;

            Count++;
        }

        public bool Contains(int item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (items[i] == item)
                {
                    return true;
                }
            }

            return false;
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            if (firstIndex < 0 || firstIndex >= Count ||
                secondIndex < 0 || secondIndex >= Count)
            {
                throw new ArgumentOutOfRangeException();
            }

            items[firstIndex] = items[firstIndex] ^ items[secondIndex];
            items[secondIndex] = items[firstIndex] ^ items[secondIndex];
            items[firstIndex] = items[firstIndex] ^ items[secondIndex];
        }

        public int Find(int item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (items[i] == item)
                {
                    return i;
                }
            }

            return -1;
        }

        public void Reverse()
        {
            int[] copy = new int[Count];

            int counter = 0;

            for (int i = Count - 1; i >= 0; i--)
            {
                copy[i] = items[counter];
                counter++;
            }

            items = copy;
        }

        public override string ToString()
        => string.Join(", ", items);
    }
}
