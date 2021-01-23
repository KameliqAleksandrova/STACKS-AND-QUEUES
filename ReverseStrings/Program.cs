using System;
using System.Collections;

namespace ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack stack = new Stack();
            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];
                stack.Push(ch);
            }
            while (stack.Count!=0)
            {
                Console.Write(stack.Pop());
            }
        }
    }
}
