using System;
using System.IO;

namespace _06.FolderSize
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] files = Directory.GetFiles("../../../TestFolder");

            double sum = 0;

            foreach (var file in files)
            {
                FileInfo fileInfo = new FileInfo(file);

                sum += fileInfo.Length;
            }

            sum /= 1024 * 1024;
            Console.WriteLine(sum);
        }
    }
}
