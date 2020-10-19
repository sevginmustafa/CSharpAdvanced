using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace _04.Froggy
{
    public class Lake : IEnumerable<int>
    {
        private List<int> list;

        public Lake(List<int> list)
        {
            this.list = list;
        }

        public IEnumerator<int> GetEnumerator()
        {
            int lastOddIndex = list.Count - 2;

            if (list.Count % 2 == 0)
            {
                lastOddIndex = list.Count - 1;
            }

            for (int i = 0; i < list.Count; i += 2)
            {
                yield return list[i];
            }

            for (int i = lastOddIndex; i >= 0; i -= 2)
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
