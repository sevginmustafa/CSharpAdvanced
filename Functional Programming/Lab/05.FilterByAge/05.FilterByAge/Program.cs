using System;

namespace _05.FilterByAge
{
    public class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Person[] people = new Person[n];

            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split(", ");

                people[i] = new Person
                {
                    Name = info[0],
                    Age = int.Parse(info[1])
                };
            }

            string condition = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();

            Func<Person, bool> conditionPrinter = GetCondition(condition, age);
            Action<Person> formatPrinter = GetFormat(format);

            foreach (var person in people)
            {
                if (conditionPrinter(person))
                {
                    formatPrinter(person);
                }
            }
        }

        static Func<Person, bool> GetCondition(string conditon, int age)
        {
            switch (conditon)
            {
                case "younger": return p => p.Age < age;
                case "older": return p => p.Age >= age;
                default: return null;
            }
        }

        static Action<Person> GetFormat(string format)
        {
            switch (format)
            {
                case "name":
                    return p => Console.WriteLine($"{p.Name}");
                case "age":
                    return p => Console.WriteLine($"{p.Age}");
                case "name age":
                    return p => Console.WriteLine($"{p.Name} - {p.Age}");
                default: return null;
            }
        }
    }
}
