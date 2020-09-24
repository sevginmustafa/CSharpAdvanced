using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            var command = Console.ReadLine().Split();

            char[,] matrix = new char[size, size];

            int startRow = 0;
            int startCol = 0;
            int coalsCount = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var data = Console.ReadLine().Split().Select(char.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = data[col];

                    if (matrix[row, col] == 's')
                    {
                        startRow = row;
                        startCol = col;
                    }
                    else if (matrix[row, col] == 'c')
                    {
                        coalsCount++;
                    }
                }
            }

            int coalsCollected = 0;

            Stack<int> lastRow = new Stack<int>();
            Stack<int> lastCol = new Stack<int>();

            for (int i = 0; i < command.Length; i++)
            {
                lastRow.Push(startRow);
                lastCol.Push(startCol);

                if (command[i] == "left")
                {
                    startCol -= 1;
                }
                else if (command[i] == "right")
                {
                    startCol += 1;
                }
                else if (command[i] == "up")
                {
                    startRow -= 1;
                }
                else if (command[i] == "down")
                {
                    startRow += 1;
                }

                if (startRow >= 0 && startRow < matrix.GetLength(0) && startCol >= 0 && startCol < matrix.GetLength(1))
                {
                    if (matrix[startRow, startCol] == 'c')
                    {
                        coalsCollected++;
                        matrix[startRow, startCol] = '*';
                    }
                    if (coalsCollected == coalsCount)
                    {
                        Console.WriteLine($"You collected all coals! ({startRow}, {startCol})");
                        return;
                    }
                    else if (matrix[startRow, startCol] == 'e')
                    {
                        Console.WriteLine($"Game over! ({startRow}, {startCol})");
                        return;
                    }
                }
                else
                {
                    startRow = lastRow.Pop();
                    startCol = lastCol.Pop();
                }
            }

            Console.WriteLine($"{coalsCount - coalsCollected} coals left. ({startRow}, {startCol})");
        }
    }
}
