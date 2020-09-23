using System;
using System.Linq;

namespace _03.PrimaryDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];

            int diagonalSum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = nums[col];
                }

                diagonalSum += matrix[row,row];
            }

            Console.WriteLine(diagonalSum);
        }
    }
}
