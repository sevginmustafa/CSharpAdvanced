using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<decimal>> studentGrades = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split();

                string name = info[0];
                decimal grade = decimal.Parse(info[1]);

                if (!studentGrades.ContainsKey(name))
                {
                    studentGrades.Add(name, new List<decimal>());
                }

                studentGrades[name].Add(grade);
            }

            foreach (var student in studentGrades)
            {
                StringBuilder sb = new StringBuilder();

                foreach (var grade in student.Value)
                {
                    sb.Append($"{grade:f2} ");
                }

                Console.WriteLine($"{student.Key} -> {sb}(avg: {student.Value.Average():f2})");
            }
        }
    }
}
