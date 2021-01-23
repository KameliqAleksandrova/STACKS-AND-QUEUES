using System;
using System.Collections.Generic;
using System.Linq;

namespace CupsAndBottles
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> cups = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            Stack<int> bottles = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            int wastedWater = 0;
            while (bottles.Any())
            {
                if(!cups.Any())
                {
                    break;
                }
                int currentBottle = bottles.Pop();
                int currentCup = cups.Peek();
                if (currentBottle==currentCup)
                {
                    cups.Dequeue();                    
                }
                else if(currentBottle>currentCup)
                {
                    wastedWater += currentBottle - currentCup;
                    cups.Dequeue();                   
                }
                else
                {                   
                    currentCup -= currentBottle;                    
                    cups.Dequeue();
                    cups.Enqueue(currentCup);
                    for (int i = 0; i < cups.Count-1; i++)
                    {
                        cups.Enqueue(cups.Dequeue());
                    }             
                }
            }
            if(cups.Any())
            {
                Console.WriteLine($"Cups: {string.Join(" ", cups)}");
            }
            if(bottles.Any())
            {
                Console.WriteLine($"Bottles: {string.Join(" ", bottles)}");
            }  
            Console.WriteLine($"Wasted litters of water: {wastedWater}");
        }
    }
}
