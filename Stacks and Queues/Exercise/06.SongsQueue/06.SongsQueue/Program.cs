using System;
using System.Collections.Generic;

namespace _06.SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(", ");

            Queue<string> songs = new Queue<string>(array);

            while (songs.Count > 0)
            {
                string[] command = Console.ReadLine().Split();

                if (command[0] == "Play")
                {
                    songs.Dequeue();
                }
                else if (command[0] == "Add")
                {
                    string currentSong = "";

                    for (int i = 1; i < command.Length - 1; i++)
                    {
                        currentSong += command[i] + " ";
                    }
                    currentSong += command[command.Length - 1];

                    if (!songs.Contains(currentSong))
                    {
                        songs.Enqueue(currentSong);
                    }
                    else
                    {
                        Console.WriteLine($"{currentSong} is already contained!");
                    }
                }
                if (command[0] == "Show")
                {
                    Console.WriteLine(string.Join(", ", songs));
                }
            }

            Console.WriteLine("No more songs!");
        }
    }
}
