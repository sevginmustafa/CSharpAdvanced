using System;
using System.Collections.Generic;

namespace _06.SpeedRacing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split();

                string model = info[0];
                double fuelAmount = double.Parse(info[1]);
                double fuelConsumptionFor1km = double.Parse(info[2]);

                Car car = new Car(model, fuelAmount, fuelConsumptionFor1km);

                cars.Add(car);
            }

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] splittedInput = input.Split();

                string carModel = splittedInput[1];
                int amountOfKm = int.Parse(splittedInput[2]);

                foreach (var car in cars)
                {
                    if (car.Model == carModel)
                    {
                        car.CheckDistance(amountOfKm);
                    }
                }
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
        }
    }
}
