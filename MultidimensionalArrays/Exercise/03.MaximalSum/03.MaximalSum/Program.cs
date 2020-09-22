using System;
using System.Linq;

namespace _03.MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[,] matrix = new int[size[0], size[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = data[col];
                }
            }

            int maxRectangularSum = int.MinValue;
            string maxRowOne = string.Empty;
            string maxRowTwo = string.Empty;
            string maxRowThree = string.Empty;

            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                int currentSum = 0;

                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2]
                        + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
                        + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                    if (currentSum > maxRectangularSum)
                    {
                        maxRectangularSum = currentSum;
                        maxRowOne = $"{matrix[row, col]} {matrix[row, col + 1]} {matrix[row, col + 2]}";
                        maxRowTwo = $"{matrix[row + 1, col]} {matrix[row + 1, col + 1]} {matrix[row + 1, col + 2]}";
                        maxRowThree = $"{matrix[row + 2, col]} {matrix[row + 2, col + 1]} {matrix[row + 2, col + 2]}";
                    }
                }
            }

            Console.WriteLine($"Sum = {maxRectangularSum}");
            Console.WriteLine(maxRowOne);
            Console.WriteLine(maxRowTwo);
            Console.WriteLine(maxRowThree);
        }
    }
}
