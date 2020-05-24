using System;
using System.Collections.Generic;

namespace _04._Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            var expression = Console.ReadLine();
            var stack = new Stack<int>();

            for (int i = 0; i < expression.Length; i++)
            {
                char @char = expression[i];
                if (@char == '(')
                {
                    stack.Push(i);
                }
                else if (@char == ')')
                {
                    var leftIndex = stack.Pop();
                    var subExpression = expression.Substring(leftIndex, i - leftIndex + 1);
                    Console.WriteLine(subExpression);
                }
            }
        }
    }
}
