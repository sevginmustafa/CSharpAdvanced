using System;

namespace _07.PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            long[][] matrix = new long[number][];

            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = new long[row + 1];

                matrix[row][0] = 1;
                matrix[row][matrix[row].Length - 1] = 1;

                for (int col = 1; col < matrix[row].Length - 1; col++)
                {
                    matrix[row][col] = matrix[row - 1][col - 1] + matrix[row - 1][col];
                }
            }

            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join(' ', row));
            }
        }
    }
}
