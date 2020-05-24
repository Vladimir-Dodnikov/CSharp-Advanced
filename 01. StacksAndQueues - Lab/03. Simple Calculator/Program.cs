using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();
            var parts = expression.Split(' ');
            var stack = new Stack<string>(parts.Reverse());
            var result = 0;
            while (stack.Count > 0)
            {
                var element = stack.Pop();
                if (element == "+")
                {
                    var number = stack.Pop();
                    result +=int.Parse(number);
                }
                else if (element == "-")
                {
                    var number = stack.Pop();
                    result -= int.Parse(number);
                }
                else
                {
                    result += int.Parse(element);
                }

            }
            Console.WriteLine(result);
        }
    }
}
