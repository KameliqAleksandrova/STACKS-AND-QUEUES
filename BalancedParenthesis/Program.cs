using System;
using System.Collections.Generic;

namespace BalancedParenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Dictionary<char, char> pairs = new Dictionary<char, char>
            {
                {'(',')' }, {'[',']' },{'{','}' }
            };


           if(text.Length%2!=0)
            {
                Console.WriteLine("NO");
                return;
            }
            var stack = new Stack<char>();
            for (int i = 0; i < text.Length; i++)
            {
                char ch = text[i];
                if (ch == '[' || ch == '(' || ch == '{')
                {
                    stack.Push(ch);
                }
                else if(stack.Count==0)
                {
                    Console.WriteLine("NO");
                    return;
                }
                else
                {
                    char lastSymbol = stack.Pop();
                    char expected = pairs[lastSymbol];
                    if(ch!= expected)
                    {
                        Console.WriteLine("NO");
                        return;
                    }

                }
            }
            if(stack.Count==0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
