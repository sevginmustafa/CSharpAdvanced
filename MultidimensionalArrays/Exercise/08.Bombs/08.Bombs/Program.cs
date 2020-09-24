using System;
using System.Linq;

namespace _08.Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var data = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = data[col];
                }
            }

            var input = Console.ReadLine().Split();

            for (int i = 0; i < input.Length; i++)
            {
                var splittedInput = input[i].Split(',').Select(int.Parse).ToArray();
                int row = splittedInput[0];
                int col = splittedInput[1];

                int bombValue = matrix[row, col];

                if (bombValue > 0)
                {
                    matrix[row, col] = 0;
                    if (row - 1 >= 0 && row - 1 < matrix.GetLength(0) && col - 1 >= 0 && col - 1 < matrix.GetLength(1) && matrix[row - 1, col - 1] > 0)
                    {
                        matrix[row - 1, col - 1] -= bombValue;
                    }
                    if (row - 1 >= 0 && row - 1 < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1) && matrix[row - 1, col] > 0)
                    {
                        matrix[row - 1, col] -= bombValue;
                    }
                    if (row - 1 >= 0 && row - 1 < matrix.GetLength(0) && col + 1 >= 0 && col + 1 < matrix.GetLength(1) && matrix[row - 1, col + 1] > 0)
                    {
                        matrix[row - 1, col + 1] -= bombValue;
                    }
                    if (row >= 0 && row < matrix.GetLength(0) && col + 1 >= 0 && col + 1 < matrix.GetLength(1) && matrix[row, col + 1] > 0)
                    {
                        matrix[row, col + 1] -= bombValue;
                    }
                    if (row >= 0 && row < matrix.GetLength(0) && col - 1 >= 0 && col - 1 < matrix.GetLength(1) && matrix[row, col - 1] > 0)
                    {
                        matrix[row, col - 1] -= bombValue;
                    }
                    if (row + 1 >= 0 && row + 1 < matrix.GetLength(0) && col - 1 >= 0 && col - 1 < matrix.GetLength(1) && matrix[row + 1, col - 1] > 0)
                    {
                        matrix[row + 1, col - 1] -= bombValue;
                    }
                    if (row + 1 >= 0 && row + 1 < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1) && matrix[row + 1, col] > 0)
                    {
                        matrix[row + 1, col] -= bombValue;
                    }
                    if (row + 1 >= 0 && row + 1 < matrix.GetLength(0) && col + 1 >= 0 && col + 1 < matrix.GetLength(1) && matrix[row + 1, col + 1] > 0)
                    {
                        matrix[row + 1, col + 1] -= bombValue;
                    }
                }
            }

            int counter = 0;
            int sum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] > 0)
                    {
                        counter++;
                        sum += matrix[row, col];
                    }
                }
            }

            Console.WriteLine($"Alive cells: {counter}");
            Console.WriteLine($"Sum: {sum}");
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
