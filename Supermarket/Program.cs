using System;
using System.Collections.Generic;

namespace Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            var command = Console.ReadLine();
            var queue = new Queue<string>();
            while (command!="End")
            {
                if(command!="Paid")
                {
                    queue.Enqueue(command);
                }
                else
                {
                    while (queue.Count>0)
                    {
                        Console.WriteLine(queue.Dequeue());
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"{queue.Count} people remaining.");
        }
    }
}
