using System;

namespace _07.Tuple
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] inputOne = Console.ReadLine().Split();
            string personName = $"{inputOne[0]} {inputOne[1]}";
            string address = inputOne[2];

            Tuple<string, string> personInfo = new Tuple<string, string>(personName, address);

            string[] inputTwo = Console.ReadLine().Split();
            string name = inputTwo[0];
            int beerAmount = int.Parse(inputTwo[1]);

            Tuple<string, int> beerInfo = new Tuple<string, int>(name, beerAmount);

            string[] inputThree = Console.ReadLine().Split();
            int integer = int.Parse(inputThree[0]);
            double floatingNum = double.Parse(inputThree[1]);

            Tuple<int, double> numsInfo = new Tuple<int, double>(integer, floatingNum);

            Console.WriteLine(personInfo);
            Console.WriteLine(beerInfo);
            Console.WriteLine(numsInfo);
        }
    }
}