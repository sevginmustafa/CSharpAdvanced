using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.RadioactiveMutantVampireBunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = Console.ReadLine().Split().Select(int.Parse).ToArray();

            char[,] matrix = new char[size[0], size[1]];

            List<int> bunniesPositions = new List<int>();
            int playerPositionRow = 0;
            int playerPositionCol = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string data = Console.ReadLine();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = data[col];

                    if (data[col] == 'B')
                    {
                        bunniesPositions.Add(row);
                        bunniesPositions.Add(col);
                    }
                    else if (data[col] == 'P')
                    {
                        playerPositionRow = row;
                        playerPositionCol = col;
                    }
                }
            }

            string command = Console.ReadLine();

            int playerMoveRow = playerPositionRow;
            int playerMoveCol = playerPositionCol;
            string result = string.Empty;

            for (int i = 0; i < command.Length; i++)
            {
                if (command[i] == 'L')
                {
                    playerMoveCol -= 1;
                }
                else if (command[i] == 'R')
                {
                    playerMoveCol += 1;
                }
                else if (command[i] == 'U')
                {
                    playerMoveRow -= 1;
                }
                else if (command[i] == 'D')
                {
                    playerMoveRow += 1;
                }

                if (IsValid(matrix, playerMoveRow, playerMoveCol) && matrix[playerMoveRow, playerMoveCol] == 'B')
                {
                    matrix[playerPositionRow, playerPositionCol] = '.';
                    result = "dead";
                    command = string.Empty;
                }
                else if (IsValid(matrix, playerMoveRow, playerMoveCol))
                {
                    matrix[playerMoveRow, playerMoveCol] = 'P';
                    matrix[playerPositionRow, playerPositionCol] = '.';
                    playerPositionRow = playerMoveRow;
                    playerPositionCol = playerMoveCol;
                }
                else if (!IsValid(matrix, playerMoveRow, playerMoveCol))
                {
                    matrix[playerPositionRow, playerPositionCol] = '.';
                    result = "won";
                    command = string.Empty; ;
                }

                for (int j = 0; j < bunniesPositions.Count; j += 2)
                {
                    int row = bunniesPositions[j];
                    int col = bunniesPositions[j + 1];

                    if (IsValid(matrix, row, col - 1) && matrix[row, col - 1] == '.')
                    {
                        matrix[row, col - 1] = 'B';
                    }
                    else if (IsValid(matrix, row, col - 1) && matrix[row, col - 1] == 'P')
                    {
                        matrix[row, col - 1] = 'B';
                        result = "dead";
                        command = string.Empty;
                    }

                    if (IsValid(matrix, row, col + 1) && matrix[row, col + 1] == '.')
                    {
                        matrix[row, col + 1] = 'B';
                    }
                    else if (IsValid(matrix, row, col + 1) && matrix[row, col + 1] == 'P')
                    {
                        matrix[row, col + 1] = 'B';
                        result = "dead";
                        command = string.Empty;
                    }

                    if (IsValid(matrix, row + 1, col) && matrix[row + 1, col] == '.')
                    {
                        matrix[row + 1, col] = 'B';
                    }
                    else if (IsValid(matrix, row + 1, col) && matrix[row + 1, col] == 'P')
                    {
                        matrix[row + 1, col] = 'B';
                        result = "dead";
                        command = string.Empty;
                    }

                    if (IsValid(matrix, row - 1, col) && matrix[row - 1, col] == '.')
                    {
                        matrix[row - 1, col] = 'B';
                    }
                    else if (IsValid(matrix, row - 1, col) && matrix[row - 1, col] == 'P')
                    {
                        matrix[row - 1, col] = 'B';
                        result = "dead";
                        command = string.Empty;
                    }
                }

                bunniesPositions.Clear();

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        if (matrix[row, col] == 'B')
                        {
                            bunniesPositions.Add(row);
                            bunniesPositions.Add(col);
                        }
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

            if (result == "won")
            {
                Console.WriteLine($"won: {playerPositionRow} {playerPositionCol}");
            }
            else
            {
                Console.WriteLine($"dead: {playerMoveRow} {playerMoveCol}");
            }
        }

        public static bool IsValid(char[,] matrix, int row, int col)
        {
            return row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1);
        }
    }
}
