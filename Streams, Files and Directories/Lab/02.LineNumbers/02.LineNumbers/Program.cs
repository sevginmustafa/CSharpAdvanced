using System;
using System.IO;

namespace _02.LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("../../../Input.txt"))
            {
                using (StreamWriter writer = new StreamWriter("../../../Output.txt"))
                {
                    string line = reader.ReadLine();
                    int index = 1;

                    while (line != null)
                    {
                        writer.WriteLine($"Line {index}: {line}");
                        index ++;
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
