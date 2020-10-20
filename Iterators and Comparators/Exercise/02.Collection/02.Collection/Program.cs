using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace _01.ListyIterator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            ListyIterator<string> listyIterator = null;

            while ((input = Console.ReadLine()) != "END")
            {
                string[] command = input.Split();

                if (command[0] == "Create")
                {
                    listyIterator = new ListyIterator<string>(command.Skip(1).ToArray());
                }
                else if (command[0] == "Move")
                {
                    Console.WriteLine(listyIterator.Move());
                }
                else if (command[0] == "Print")
                {
                    try
                    {
                        listyIterator.Print();
                    }
                    catch (InvalidOperationException io)
                    {
                        Console.WriteLine(io.Message);
                    }
                }
                else if (command[0] == "HasNext")
                {
                    Console.WriteLine(listyIterator.HasNext());
                }
                else if (command[0] == "PrintAll")
                {
                    foreach (var item in listyIterator)
                    {
                        Console.Write(item + " ");
                    }
                    Console.WriteLine();
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
    }
}
