using System;
using System.Collections.Generic;
using System.Linq;

namespace Balanced_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {          
            var text = Console.ReadLine();
            var queue = new Queue<char>();
            int middle = text.Length / 2;
            var newText = text.Substring(0, middle + 1);
            Console.WriteLine(newText);
        }
    }
}
