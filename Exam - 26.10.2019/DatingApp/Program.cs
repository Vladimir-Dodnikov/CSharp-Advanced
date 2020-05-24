using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DatingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var male = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            var female = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            var maleStack = new Stack<int>();
            var femaleQueue = new Queue<int>();

            for (int i = 0; i < male.Length; i++)
            {
                if (male[i] <= 0 || male[i] == 25)
                {
                    continue;
                }
                maleStack.Push(male[i]);
            }
            for (int i = 0; i < female.Length; i++)
            {
                if (female[i] <= 0 || female[i] == 25)
                {
                    continue;
                }

                femaleQueue.Enqueue(female[i]);
            }

            int matchesCount = 0;
            while (true)
            {
                if (maleStack.Count == 0 || femaleQueue.Count == 0)
                {
                    break;
                }
                var firstMale = maleStack.Pop();
                var firstFemale = femaleQueue.Dequeue();

                if (firstFemale == firstMale)
                {
                    matchesCount++;
                }
                else
                {
                    firstMale -= 2;
                    if (firstMale <= 0)
                    {
                        continue;
                    }
                    maleStack.Push(firstMale);
                }
            }


            Console.WriteLine($"Matches: {matchesCount}");

            if (maleStack.Count == 0)
            {
                Console.WriteLine("Males left: none");
            }
            else
            {
                Console.WriteLine("Males left: " + string.Join(", ", maleStack));
            }

            if (femaleQueue.Count == 0)
            {
                Console.WriteLine("Females left: none");
            }
            else
            {
                Console.WriteLine("Females left: " + string.Join(", ", femaleQueue));
            }
        }
    }
}
