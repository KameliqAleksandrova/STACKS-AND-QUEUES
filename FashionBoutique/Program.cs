using System;
using System.Collections.Generic;
using System.Linq;

namespace FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            var capacity = int.Parse(Console.ReadLine());
            var stack = new Stack<int>(numbers);
            var counter = 0;
            var sum = 0;
            while (stack.Any())
            {
                
                var num = stack.Peek();               
                if(sum+num<=capacity)
                {
                    sum += num;
                    stack.Pop();
                }
                else
                {
                    sum = 0;
                    counter++;
                }
            }
            if(sum!=0)
            {
                counter++;
            }
            Console.WriteLine(counter);
        }
    }
}
