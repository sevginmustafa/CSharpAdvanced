using System;
using System.Collections.Generic;
using System.Text;

namespace _08.Threeuple
{
    public class Threeuple<Tfirst, Tsecond, Tthird>
    {
        public Tfirst FirstItem { get; set; }
        public Tsecond SecondItem { get; set; }
        public Tthird ThirdItem { get; set; }

        public Threeuple(Tfirst firstItem, Tsecond secondItem, Tthird thirdItem)
        {
            FirstItem = firstItem;
            SecondItem = secondItem;
            ThirdItem = thirdItem;
        }

        public override string ToString()
        {
            return $"{FirstItem} -> {SecondItem} -> {ThirdItem}";
        }
    }
}
