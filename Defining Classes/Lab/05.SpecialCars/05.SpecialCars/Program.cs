using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            List<Tire[]> allTires = new List<Tire[]>();

            while ((input = Console.ReadLine()) != "No more tires")
            {
                string[] tireInfo = input.Split();

                Tire[] tires = new Tire[tireInfo.Length / 2];

                int indexCounter = 0;

                for (int j = 0; j < tireInfo.Length - 1; j += 2)
                {
                    int year = int.Parse(tireInfo[j]);
                    double pressure = double.Parse(tireInfo[j + 1]);

                    tires[indexCounter] = new Tire(year, pressure);
                    indexCounter++;
                }

                allTires.Add(tires);
            }

            List<Engine> engines = new List<Engine>();

            while ((input = Console.ReadLine()) != "Engines done")
            {
                string[] engineInfo = input.Split();

                int horsePower = int.Parse(engineInfo[0]);
                double cubicCapacity = double.Parse(engineInfo[1]);

                Engine engine = new Engine(horsePower, cubicCapacity);

                engines.Add(engine);
            }

            List<Car> cars = new List<Car>();

            while ((input = Console.ReadLine()) != "Show special")
            {
                string[] carInfo = input.Split();

                string make = carInfo[0];
                string model = carInfo[1];
                int year = int.Parse(carInfo[2]);
                double fuelQuantity = double.Parse(carInfo[3]);
                double fuelConsumption = double.Parse(carInfo[4]);
                int engineIndex = int.Parse(carInfo[5]);
                int tireIndex = int.Parse(carInfo[6]);

                Car car = new Car(make, model, year, fuelQuantity, fuelConsumption, engines[engineIndex], allTires[tireIndex]);

                cars.Add(car);
            }

            var specialCars = cars.Where
                (c => c.Year >= 2017 &&
                c.Engine.HorsePower > 330 &&
                c.Tires.Select(x => x.Pressure).Sum() >= 9 &&
                c.Tires.Select(x => x.Pressure).Sum() <= 10);

            foreach (var specialCar in specialCars)
            {
                specialCar.Drive(20);
                Console.WriteLine($"Make: {specialCar.Make}");
                Console.WriteLine($"Model: {specialCar.Model}");
                Console.WriteLine($"Year: {specialCar.Year}");
                Console.WriteLine($"HorsePowers: {specialCar.Engine.HorsePower}");
                Console.WriteLine($"FuelQuantity: {specialCar.FuelQuantity}");
            }
        }
    }
}
