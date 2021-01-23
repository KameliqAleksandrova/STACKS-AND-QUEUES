using System;
using System.Collections.Generic;
using System.Linq;

namespace MaximumAndMinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberCommand = int.Parse(Console.ReadLine());
            var stack = new Stack<int>();
            for (int i = 0; i < numberCommand; i++)
            {
                var command = Console.ReadLine().Split().Select(int.Parse).ToList();
                switch (command[0])
                {
                    case 1:
                        stack.Push(command[1]);
                        break;
                    case 2:
                        if(stack.Count==0)
                        {
                            continue;
                        }
                        stack.Pop();
                        break;
                    case 3:
                        if (stack.Count == 0)
                        {
                            continue;
                        }
                        Console.WriteLine( stack.Max()); 
                        break;
                    case 4:
                        if (stack.Count == 0)
                        {
                            continue;
                        }
                        Console.WriteLine(stack.Min());
                        break;                   
                }
            }
            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
