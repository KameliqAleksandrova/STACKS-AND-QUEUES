using System;
using System.Collections.Generic;
using System.Linq;

namespace FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            var quantityFood = int.Parse(Console.ReadLine());
            var orders = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var queue = new Queue<int>(orders);
            Console.WriteLine(queue.Max());
            while (queue.Any())
            {
                int currentOrder = queue.Peek();
                if (currentOrder <= quantityFood)
                {
                    queue.Dequeue();
                    quantityFood=quantityFood- currentOrder;
                }
                else
                {
                    break;
                }
            }
            if (queue.Count > 0)
            {
                Console.WriteLine($"Orders left: {string.Join(" ", queue)}");
            }
            else
            {
                Console.WriteLine($"Orders complete");
            }
        }
    }
}
