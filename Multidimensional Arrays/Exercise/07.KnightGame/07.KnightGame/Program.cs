using System;

namespace _07.KnightGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string data = Console.ReadLine();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = data[col];
                }
            }

            int counter = 0;
            int maxRow = 0;
            int maxCol = 0;

            while (true)
            {
                int maxAttackCounter = 0;

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        int currentAttack = 0;

                        if (matrix[row, col] == 'K')
                        {
                            if (row - 2 >= 0 && row - 2 < matrix.GetLength(0) && col - 1 >= 0 && col - 1 < matrix.GetLength(1) && matrix[row - 2, col - 1] == 'K')
                            {
                                currentAttack++;
                            }
                            if (row - 2 >= 0 && row - 2 < matrix.GetLength(0) && col + 1 >= 0 && col + 1 < matrix.GetLength(1) && matrix[row - 2, col + 1] == 'K')
                            {
                                currentAttack++;
                            }
                            if (row - 1 >= 0 && row - 1 < matrix.GetLength(0) && col - 2 >= 0 && col - 2 < matrix.GetLength(1) && matrix[row - 1, col - 2] == 'K')
                            {
                                currentAttack++;
                            }
                            if (row - 1 >= 0 && row - 1 < matrix.GetLength(0) && col + 2 >= 0 && col + 2 < matrix.GetLength(1) && matrix[row - 1, col + 2] == 'K')
                            {
                                currentAttack++;
                            }
                            if (row + 1 >= 0 && row + 1 < matrix.GetLength(0) && col - 2 >= 0 && col - 2 < matrix.GetLength(1) && matrix[row + 1, col - 2] == 'K')
                            {
                                currentAttack++;
                            }
                            if (row + 1 >= 0 && row + 1 < matrix.GetLength(0) && col + 2 >= 0 && col + 2 < matrix.GetLength(1) && matrix[row + 1, col + 2] == 'K')
                            {
                                currentAttack++;
                            }
                            if (row + 2 >= 0 && row + 2 < matrix.GetLength(0) && col - 1 >= 0 && col - 1 < matrix.GetLength(1) && matrix[row + 2, col - 1] == 'K')
                            {
                                currentAttack++;
                            }
                            if (row + 2 >= 0 && row + 2 < matrix.GetLength(0) && col + 1 >= 0 && col + 1 < matrix.GetLength(1) && matrix[row + 2, col + 1] == 'K')
                            {
                                currentAttack++;
                            }

                            if (currentAttack > maxAttackCounter)
                            {
                                maxAttackCounter = currentAttack;
                                maxRow = row;
                                maxCol = col;
                            }
                        }
                    }
                }
                if (maxAttackCounter > 0)
                {
                    matrix[maxRow, maxCol] = '0';
                    counter++;
                }
                else
                {
                    Console.WriteLine(counter);
                    break;
                }
            }
        }
    }
}
