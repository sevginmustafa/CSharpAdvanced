using System;
using System.Collections.Generic;
using System.Text;

namespace _07.Tuple
{
    public class Tuple<Tfirst, Tsecond>
    {
        public Tfirst FirstItem { get; set; }
        public Tsecond SecondItem { get; set; }

        public Tuple(Tfirst firstItem, Tsecond secondItem)
        {
            FirstItem = firstItem;
            SecondItem = secondItem;
        }

        public override string ToString()
        {
            return $"{FirstItem} -> {SecondItem}";
        }
    }
}
