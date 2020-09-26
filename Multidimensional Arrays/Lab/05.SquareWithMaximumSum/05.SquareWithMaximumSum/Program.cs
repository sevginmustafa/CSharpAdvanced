using System;
using System.Linq;

namespace _05.SquareWithMaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int rows = size[0];
            int cols = size[1];

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var nums = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = nums[col];
                }
            }

            int maxSum = int.MinValue;

            string maxRow = string.Empty;
            string maxCol = string.Empty;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                int currentSum = 0;

                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    currentSum = matrix[row, col] + matrix[row + 1, col] + matrix[row, col + 1] + matrix[row + 1, col + 1];

                    if (maxSum < currentSum)
                    {
                        maxSum = currentSum;
                        maxRow = $"{matrix[row, col]} {matrix[row, col + 1] }";
                        maxCol = $"{ matrix[row + 1, col]} {matrix[row + 1, col + 1]}";
                    }
                }
            }

            Console.WriteLine(maxRow);
            Console.WriteLine(maxCol);
            Console.WriteLine(maxSum);
        }
    }
}
