using System;
using System.Collections.Generic;

namespace _08._Balanced_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            var charParenthesis = new char[]
            {
                '[',
                '(',
                '{',
                ']',
                ')',
                '}'
            };

            var input = Console.ReadLine().ToCharArray();

            Stack<char> stack = new Stack<char>();

            bool isBalanced = true;

            for (int i = 0; i < input.Length; i++)
            {
                char current = input[i];
                switch (current)
                {
                    case '(':
                        stack.Push(')');
                        break;
                    case '[':
                        stack.Push(']');
                        break;
                    case '{':
                        stack.Push('}');
                        break;
                    case ')':
                    case ']':
                    case '}':
                        if (stack.Count == 0 || stack.Pop() != current)
                        {
                            isBalanced = false;
                        }
                        break;

                    default:
                        break;
                }

                if (!isBalanced)
                {
                    break;
                }
            }

            Console.WriteLine(isBalanced ? "YES" : "NO");
        }
    }
}
