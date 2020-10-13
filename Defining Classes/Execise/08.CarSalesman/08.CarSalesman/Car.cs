using System;
using System.Collections.Generic;
using System.Text;

namespace _08.CarSalesman
{
    public class Car
    {
        public Car(string model, Engine engine)
        {
            Model = model;
            Engine = engine;
            Weight = "n/a";
            Color = "n/a";
        }

        public string Model { get; set; }
        public Engine Engine { get; set; }
        public string Weight { get; set; }
        public string Color { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(Model + ":");
            sb.AppendLine("  " + Engine.Model + ":");
            sb.AppendLine("    Power: " + Engine.Power);
            sb.AppendLine("    Displacement: " + Engine.Displacement);
            sb.AppendLine("    Efficiency: " + Engine.Efficiency);
            sb.AppendLine("  Weight: " + Weight);
            sb.AppendLine("  Color: " + Color);

            return sb.ToString().TrimEnd();
        }
    }
}
