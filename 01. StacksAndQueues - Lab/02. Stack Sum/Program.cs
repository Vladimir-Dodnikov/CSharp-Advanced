using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            var stack = new Stack<int>(numbers);

            string commandArgs = Console.ReadLine().ToLower();
            while (commandArgs != "end")
            {
                var command = commandArgs.Split(' ');
                var token = command[0];

                if (token == "add")
                {
                    stack.Push(int.Parse(command[1]));
                    stack.Push(int.Parse(command[2]));
                }
                else if (token == "remove")
                {
                    var itemsToRemove = int.Parse(command[1]);
                    if (stack.Count >= itemsToRemove)
                    {
                        for (int i = 0; i < itemsToRemove; i++)
                        {
                            if (stack.Count > 0)
                            {
                                stack.Pop();
                            }
                        }
                    }
                }
                commandArgs = Console.ReadLine().ToLower();
            }
            var result = stack.Sum();
            Console.WriteLine("Sum: " + result);
        }
    }
}
