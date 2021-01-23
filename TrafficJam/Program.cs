using System;
using System.Collections.Generic;

namespace TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var command = Console.ReadLine();
            var queue = new Queue<string>();
            int counter = 0;
            while (command!="end")
            {
                if(command!="green")
                {
                    queue.Enqueue(command);
                }
                else
                {
                    for (int i = 0; i < number; i++)
                    {
                        if(queue.Count==0)
                        {
                            break;
                        }
                        Console.WriteLine($"{queue.Dequeue()} passed!");
                        counter++;
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"{counter} cars passed the crossroads.");
        }
    }
}
