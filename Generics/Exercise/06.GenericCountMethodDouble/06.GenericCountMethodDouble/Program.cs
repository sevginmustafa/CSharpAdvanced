using System;
using System.Collections.Generic;

namespace _06.GenericCountMethodDouble
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<double> list = new List<double>();

            for (int i = 0; i < n; i++)
            {
                double input = double.Parse(Console.ReadLine());

                list.Add(input);
            }

            Box<double> box = new Box<double>(list);

            double compare = double.Parse(Console.ReadLine());

            Console.WriteLine(box.Compare(compare));
        }
    }
}
