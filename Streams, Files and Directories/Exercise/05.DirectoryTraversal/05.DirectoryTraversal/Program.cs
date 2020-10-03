using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _05.DirectoryTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> report = new Dictionary<string, Dictionary<string, double>>();

            DirectoryInfo directoryInfo = new DirectoryInfo("../../../");

            FileInfo[] files = directoryInfo.GetFiles();

            foreach (var file in files)
            {
                if (!report.ContainsKey(file.Extension))
                {
                    report.Add(file.Extension, new Dictionary<string, double>());
                }

                report[file.Extension].Add(file.Name, file.Length / 1024.00);
            }

            using (StreamWriter writer = new StreamWriter(@$"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\report.txt"))
            {
                foreach (var file in report.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
                {
                    writer.WriteLine(file.Key);

                    foreach (var info in file.Value.OrderBy(x => x.Value))
                    {
                        writer.WriteLine($"--{info.Key} - {info.Value}kb");
                    }
                }
            }
        }
    }
}
