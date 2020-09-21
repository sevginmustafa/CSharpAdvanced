using System;
using System.Collections.Generic;

namespace _10.Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenLight = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());

            string input = string.Empty;

            Queue<string> queue = new Queue<string>();

            int counter = 0;

            while ((input = Console.ReadLine()) != "END")
            {
                int timer = greenLight;

                if (input == "green")
                {
                    while (queue.Count > 0)
                    {
                        for (int i = 0; i < queue.Peek().Length; i++)
                        {
                            timer--;
                        }

                        if (timer > 0)
                        {
                            queue.Dequeue();
                            counter++;
                            continue;
                        }
                        else
                        {
                            timer += freeWindow;
                            if (timer >= 0)
                            {
                                queue.Dequeue();
                                counter++;
                                break;
                            }
                            else
                            {
                                int index = queue.Peek().Length + timer;
                                Console.WriteLine("A crash happened!");
                                Console.WriteLine($"{queue.Peek()} was hit at {queue.Peek()[index]}.");
                                return;
                            }
                        }
                    }
                }
                else
                {
                    timer = greenLight;
                    queue.Enqueue(input);
                }
            }

            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{counter} total cars passed the crossroads.");
        }
    }
}
