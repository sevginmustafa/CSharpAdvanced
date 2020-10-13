using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.CarSalesman
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] engineInfo = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);

                string model = engineInfo[0];
                int power = int.Parse(engineInfo[1]);

                Engine engine = new Engine(model, power);

                for (int j = 2; j < engineInfo.Length; j++)
                {
                    int temp;
                    bool isSuccess = int.TryParse(engineInfo[j], out temp);

                    if (isSuccess)
                    {
                        string displacement = engineInfo[j];
                        engine.Displacement = displacement;
                    }
                    else
                    {
                        string efficiency = engineInfo[j];
                        engine.Efficiency = efficiency;
                    }
                }

                engines.Add(engine);
            }

            int m = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                string[] carInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = carInfo[0];
                string engineModel = carInfo[1];

                Engine engine = engines.FirstOrDefault(x => x.Model == engineModel);

                Car car = new Car(model, engine);

                for (int j = 2; j < carInfo.Length; j++)
                {
                    int temp;
                    bool isSuccess = int.TryParse(carInfo[j], out temp);

                    if (isSuccess)
                    {
                        string weight = carInfo[j];
                        car.Weight = weight;
                    }
                    else
                    {
                        string color = carInfo[j];
                        car.Color = color;
                    }
                }

                cars.Add(car);
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car.ToString());
            }
        }
    }
}
