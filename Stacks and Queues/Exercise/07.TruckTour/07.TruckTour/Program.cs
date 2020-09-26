using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Queue<string> queue = new Queue<string>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                input += $" {i}";
                queue.Enqueue(input);
            }

            int fuelSum = 0;

            for (int i = 0; i < n; i++)
            {
                string info = queue.Dequeue();
                var fuelAmount = info.Split().Select(int.Parse).ToArray()[0];
                var distance = info.Split().Select(int.Parse).ToArray()[1];

                fuelSum += fuelAmount;

                if (fuelSum >= distance)
                {
                    fuelSum -= distance;
                }
                else
                {
                    i = -1;
                    fuelSum = 0;
                }

                queue.Enqueue(info);
            }

            var result = queue.Peek().Split().ToArray()[2];

            Console.WriteLine(result);
        }
    }
}
