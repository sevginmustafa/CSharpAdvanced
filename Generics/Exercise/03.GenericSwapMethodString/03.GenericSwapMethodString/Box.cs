using System;
using System.Collections.Generic;
using System.Text;

namespace _03.GenericSwapMethodString
{
    class Box
    {
        public static void Swap<T>(List<T> list, int firstIndex, int secondIndex)
        {
            T temp = list[firstIndex];
            list[firstIndex] = list[secondIndex];
            list[secondIndex] = temp;
        }
    }
}
