using System;
using System.Collections.Generic;
using System.IO;

namespace _04.MergeFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputOne = File.ReadAllLines("../../../FileOne.txt");
            string[] inputTwo = File.ReadAllLines("../../../FileTwo.txt");

            List<string> result = new List<string>();

            int max = Math.Max(inputOne.Length, inputTwo.Length);

            for (int i = 0; i < max; i++)
            {
                if (i < inputOne.Length)
                {
                    result.Add(inputOne[i]);
                }
                if (i < inputTwo.Length)
                {
                    result.Add(inputTwo[i]);
                }
            }

            File.WriteAllLines("../../../output.txt", result);
        }
    }
}
