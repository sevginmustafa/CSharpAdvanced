using System;
using System.Collections.Generic;

namespace _06.ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            HashSet<string> cars = new HashSet<string>();

            while ((input = Console.ReadLine()) != "END")
            {
                string[] info = input.Split(", ");

                string direction = info[0];
                string carNumber = info[1];

                if (direction == "IN")
                {
                    cars.Add(carNumber);
                }
                else
                {
                    cars.Remove(carNumber);
                }
            }

            if (cars.Count > 0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, cars));
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
