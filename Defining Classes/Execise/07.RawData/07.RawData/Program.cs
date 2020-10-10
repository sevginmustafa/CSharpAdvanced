using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.RawData
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
                int engineSpeed = int.Parse(info[1]);
                int enginePower = int.Parse(info[2]);
                int cargoWeight = int.Parse(info[3]);
                string cargoType = info[4];
                double tire1Pressure = double.Parse(info[5]);
                int tire1Age = int.Parse(info[6]);
                double tire2Pressure = double.Parse(info[7]);
                int tire2Age = int.Parse(info[8]);
                double tire3Pressure = double.Parse(info[9]);
                int tire3Age = int.Parse(info[10]);
                double tire4Pressure = double.Parse(info[11]);
                int tire4Age = int.Parse(info[12]);

                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoWeight, cargoType);
                Tire tire1 = new Tire(tire1Pressure, tire1Age);
                Tire tire2 = new Tire(tire1Pressure, tire1Age);
                Tire tire3 = new Tire(tire1Pressure, tire1Age);
                Tire tire4 = new Tire(tire1Pressure, tire1Age);
                Tire[] tires = new Tire[] { tire1, tire2, tire3, tire4 };

                Car car = new Car(model, engine, cargo, tires);

                cars.Add(car);
            }

            string command = Console.ReadLine();

            List<Car> result = null;

            if (command == "fragile")
            {
                result = cars.Where(x => x.Cargo.Type == "fragile" && x.Tires.Any(y => y.Pressure < 1)).ToList();
            }
            else
            {
                result = cars.Where(x => x.Cargo.Type == "flamable" && x.Engine.Power > 250).ToList();
            }

            foreach (var car in result)
            {
                Console.WriteLine(car.Model);
            }
        }
    }
}
