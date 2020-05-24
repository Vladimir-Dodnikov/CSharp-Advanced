using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] elements = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int elementsToPush = elements[0];
            int elementsToPop = elements[1];
            int element = elements[2];

            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            Queue<int> stack = new Queue<int>();

            for (int i = 0; i < Math.Min(numbers.Length, elementsToPush); i++)
            {
                stack.Enqueue(numbers[i]);
            }

            for (int i = 0; i < elementsToPop; i++)
            {
                stack.Dequeue();
            }

            if (stack.Count >= 0)
            {
                if (stack.Count == 0)
                {
                    Console.WriteLine(0);
                }
                else if (stack.Contains(element))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(stack.Min());
                }
            }
        }
    }
}
