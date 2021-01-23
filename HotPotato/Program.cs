﻿using System;
using System.Collections.Generic;

namespace HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            var kids = Console.ReadLine().Split();
            int number = int.Parse(Console.ReadLine());
            var queue = new Queue<string>(kids);
            while (queue.Count>1)
            {
                for (int i = 1; i < number; i++)
                {
                    string name = queue.Dequeue();
                    queue.Enqueue(name);
                }
                Console.WriteLine($"Removed {queue.Dequeue()}"); 
            }
            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}
