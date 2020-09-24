using System;
using System.Linq;

namespace _05.SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string snake = Console.ReadLine();

            char[,] matrix = new char[size[0], size[1]];

            int counter = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = snake[counter];
                    counter++;

                    if (counter == snake.Length)
                    {
                        counter = 0;
                    }
                }

                if (matrix.GetLength(0) - 1 == row)
                {
                    break;
                }

                row++;

                for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                {
                    matrix[row, col] = snake[counter];
                    counter++;

                    if (counter == snake.Length)
                    {
                        counter = 0;
                    }
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
