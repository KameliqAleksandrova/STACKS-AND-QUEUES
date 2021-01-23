using System;
using System.Collections.Generic;
using System.Linq;

namespace PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var queue = new Queue<int>(input);
            var output = new List<int>();
            while (queue.Count > 0)
            {
                int number = queue.Dequeue();
                if (number % 2 == 0)
                {
                    output.Add(number);
                }
            }

            Console.Write(string.Join(", ", output));

        }
    }
}
