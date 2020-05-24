using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Print_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            var evenQueue = new Queue<int>();
            var evenStack = new Stack<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                var number = numbers[i];
                if (number % 2 == 0)
                {
                    evenQueue.Enqueue(number);
                    evenStack.Push(number);
                }
            }
            Console.Write(string.Join(", ", evenQueue));
            Console.WriteLine();
            Console.Write(string.Join(", ", evenStack));
        }
    }
}
