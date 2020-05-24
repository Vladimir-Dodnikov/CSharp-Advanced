using System;
using System.Collections.Generic;

namespace _01._Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var stack = new Stack<char>(input);

            while (stack.Count > 0)
            {
                char ch = stack.Pop();
                Console.Write(ch);
            }
        }
    }
}
