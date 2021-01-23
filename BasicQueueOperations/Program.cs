using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();
            var removeNumber = input[1];
            var magicNumber = input[2];
            var number = Console.ReadLine().Split().Select(int.Parse).ToList();
            var queue = new Queue<int>(number);
            for (int i = 0; i < removeNumber; i++)
            {
                queue.Dequeue();
            }
            if (queue.Contains(magicNumber))
            {
                Console.WriteLine($"true");
            }
            else if (queue.Count == 0)
            {
                Console.WriteLine($"0");
            }
            else
            {
                var output = queue.Min();
                Console.WriteLine(output);
            }
        }
    }
}
