using System;
using System.IO;
using System.Linq;

namespace _02.LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("../../../text.txt");

            string[] result = new string[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];

                int lettersCount = 0;
                int punctuationMarkscounter = 0;

                for (int j = 0; j < line.Length; j++)
                {
                    char current = line[j];

                    char[] punctuationMarks = { '-', ',', '.', '!', '?', ':', ';', '\'' };

                    if (char.IsLetter(current))
                    {
                        lettersCount++;
                    }
                    else if (punctuationMarks.Contains(current))
                    {
                        punctuationMarkscounter++;
                    }
                }

                result[i] = $"Line {i + 1}: {line} ({lettersCount})({punctuationMarkscounter})";
            }

            File.WriteAllLines("../../../output.txt", result);
        }
    }
}
