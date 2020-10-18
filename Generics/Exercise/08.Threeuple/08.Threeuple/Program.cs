using System;

namespace _08.Threeuple
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] inputOne = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string personName = $"{inputOne[0]} {inputOne[1]}";
            string address = inputOne[2];
            string town = string.Empty;
            for (int i = 3; i < inputOne.Length; i++)
            {
                town += inputOne[i] + " ";
            }

            Threeuple<string, string, string> personInfo = new Threeuple<string, string, string>(personName, address, town);

            string[] inputTwo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string name = inputTwo[0];
            int beerAmount = int.Parse(inputTwo[1]);
            string drunkOrNot = inputTwo[2];
            bool isDrunk = drunkOrNot == "drunk";

            Threeuple<string, int, bool> beerInfo = new Threeuple<string, int, bool>(name, beerAmount, isDrunk);

            string[] inputThree = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string nameTwo = inputThree[0];
            double accountBalance = double.Parse(inputThree[1]);
            string bankName = inputThree[2];

            Threeuple<string, double, string> bankInfo = new Threeuple<string, double, string>(nameTwo, accountBalance, bankName);

            Console.WriteLine(personInfo);
            Console.WriteLine(beerInfo);
            Console.WriteLine(bankInfo);
        }
    }
}
