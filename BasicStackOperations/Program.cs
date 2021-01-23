using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();            
            var removeNumber = input[1];
            var magicNumber = input[2];
            var number= Console.ReadLine().Split().Select(int.Parse).ToList();
            var stack = new Stack<int>(number);
            for (int i = 0; i < removeNumber; i++)
            {
                stack.Pop();
            }
            if(stack.Contains(magicNumber))
            {
                Console.WriteLine($"true");
            }
            else if(stack.Count==0)
            {
                Console.WriteLine($"0");
            }
            else
            {
                var output = stack.Min();
                Console.WriteLine(output);
            }
        }
    }
}
