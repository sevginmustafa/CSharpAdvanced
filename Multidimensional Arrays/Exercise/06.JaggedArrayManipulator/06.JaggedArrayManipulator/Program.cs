using System;
using System.Linq;

namespace _06.JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            double[][] matrix = new double[rows][];

            for (int row = 0; row < matrix.Length; row++)
            {
                var data = Console.ReadLine().Split().Select(int.Parse).ToArray();

                matrix[row] = new double[data.Length];

                for (int col = 0; col < matrix[row].Length; col++)
                {
                    matrix[row][col] = data[col];
                }
            }

            for (int row = 0; row < matrix.Length - 1; row++)
            {
                if (matrix[row].Length == matrix[row + 1].Length)
                {
                    for (int col = 0; col < matrix[row].Length; col++)
                    {
                        matrix[row][col] *= 2.0;
                        matrix[row + 1][col] *= 2.0;
                    }
                }
                else
                {
                    for (int col = 0; col < matrix[row].Length; col++)
                    {
                        matrix[row][col] /= 2.0;
                    }
                    for (int col = 0; col < matrix[row + 1].Length; col++)
                    {
                        matrix[row + 1][col] /= 2.0;
                    }
                }
            }

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] command = input.Split();

                int row = int.Parse(command[1]);
                int col = int.Parse(command[2]);
                int value = int.Parse(command[3]);

                if (row >= 0 && row < matrix.Length && col >= 0 && col < matrix[row].Length)
                {
                    if (command[0] == "Add")
                    {
                        matrix[row][col] += value;
                    }
                    else if (command[0] == "Subtract")
                    {
                        matrix[row][col] -= value;
                    }
                }
            }

            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join(' ', row));
            }
        }
    }
}
