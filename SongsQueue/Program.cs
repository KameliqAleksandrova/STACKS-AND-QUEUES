using System;
using System.Collections.Generic;
using System.Linq;

namespace SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(", ");
            var queue = new Queue<string>(input);
            while (queue.Any())
            {
                var command = Console.ReadLine();
                switch (command)
                {
                    case "Play":
                        queue.Dequeue();
                        break;
                    case "Show":
                        Console.Write(string.Join(", ", queue));
                        Console.WriteLine();
                        break;
                   default:
                        var song = "";
                        for (int i = 4; i < command.Length; i++)
                        {
                            song += command[i];
                        }
                        if (queue.Contains(song))
                        {
                            Console.WriteLine($"{song} is already contained!");
                        }
                        else
                        {
                            queue.Enqueue(song);
                        }
                        break;
                }               
            }
            Console.WriteLine($"No more songs!");
        }
    }
}
