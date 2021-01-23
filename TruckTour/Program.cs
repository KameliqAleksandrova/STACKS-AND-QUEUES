using System;
using System.Collections.Generic;
using System.Linq;

namespace TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var queue = new Queue<int[]>();
            for (int i = 0; i < n; i++)
            {
                var infoPumps = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                queue.Enqueue(infoPumps);
            }
            int counter = 0;
            while (true)
            {
                int fuelAmount = 0;
                bool foundPoint = true;
                for (int i = 0; i < n; i++)
                {
                    int[] currentPump = queue.Dequeue();
                    fuelAmount += currentPump[0];
                    if(fuelAmount<currentPump[1])
                    {
                        foundPoint = false;
                    }
                    fuelAmount -= currentPump[1];
                    queue.Enqueue(currentPump);
                }
                if(foundPoint)
                {
                    break;
                }
                counter++;
                queue.Enqueue(queue.Dequeue());
            }
            Console.WriteLine(counter);
        }
    }
}
