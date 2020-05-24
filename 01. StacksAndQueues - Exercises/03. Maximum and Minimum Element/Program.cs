using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int queries = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>();

            int maxNumber = int.MinValue;
            int minNumber = int.MaxValue;

            for (int i = 0; i < queries; i++)
            {
                int[] elements = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                int command = elements[0];

                switch (command)
                {
                    case 1:
                        int el = elements[1];
                        stack.Push(elements[1]);

                        if (el > maxNumber)
                        {
                            maxNumber = el;
                        }

                        if (el < minNumber)
                        {
                            minNumber = el;
                        }
                        break;
                    case 2:
                        if (stack.Count > 0)
                        {
                            int elToRemove = stack.Pop();

                            if (elToRemove == maxNumber)
                            {
                                if (stack.Count > 0)
                                {
                                    maxNumber = stack.Max();
                                }
                                else
                                {
                                    maxNumber = int.MinValue;
                                }
                            }
                            if (elToRemove == minNumber)
                            {
                                if (stack.Count > 0)
                                {
                                    minNumber = stack.Min();
                                }
                                else
                                {
                                    minNumber = int.MaxValue;
                                }
                            }
                        }
                        break;
                    case 3:
                        if (stack.Count > 0)
                        {
                            Console.WriteLine(maxNumber);
                        }
                        break;
                    case 4:
                        if (stack.Count > 0)
                        {
                            Console.WriteLine(minNumber);
                        }
                        break;
                }
            }
            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
