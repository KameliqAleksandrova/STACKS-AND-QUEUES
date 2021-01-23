using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            Stack<int> stack = new Stack<int>(numbers);
            var commandInfo = Console.ReadLine().ToLower();
            while (commandInfo != "end")
            {
                var command = commandInfo.Split();
                if (command.Length == 2)
                {
                    int numberRemove = int.Parse(command[1]);
                    if (numberRemove > stack.Count)
                    {

                        commandInfo = Console.ReadLine().ToLower();
                        continue;
                    }
                    else
                    {
                        for (int i = 0; i < numberRemove; i++)
                        {
                            stack.Pop();

                        }
                    }
                }
                else
                {
                    int numberOne = int.Parse(command[1]);
                    int numberTwo = int.Parse(command[2]);
                    stack.Push(numberOne);
                    stack.Push(numberTwo);
                }
                commandInfo = Console.ReadLine().ToLower();
            }
            var sum = stack.Sum();
            Console.WriteLine($"Sum: {sum}");

        }
    }
}
