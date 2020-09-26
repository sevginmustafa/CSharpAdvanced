using System;
using System.Linq;

namespace _06.Jagged_ArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] matrix = new int[rows][];

            for (int row = 0; row < matrix.Length; row++)
            {
                var nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

                matrix[row] = new int[nums.Length];

                for (int col = 0; col < matrix[row].Length; col++)
                {
                    matrix[row][col] = nums[col];
                }
            }

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "END")
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
                    else
                    {
                        matrix[row][col] -= value;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid coordinates");
                }
            }

            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
