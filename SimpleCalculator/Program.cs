using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            var stack = new Stack<string>(input.Reverse());
            while (stack.Count>1)
            {
                int first = int.Parse(stack.Pop());
                string symbol = stack.Pop();
                int second= int.Parse(stack.Pop());
                if(symbol=="-")
                {
                    stack.Push((first - second).ToString());
                }
                else
                {
                    stack.Push((first + second).ToString());
                }
            }            
            Console.WriteLine(stack.Pop());
        }
    }
}
