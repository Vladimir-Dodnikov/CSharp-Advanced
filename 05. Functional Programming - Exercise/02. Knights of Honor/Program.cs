﻿using System;

namespace _02._Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split();

            Action<string> printAction = s => Console.WriteLine($"Sir {s}");
            
            foreach (var name in names)
            {
                printAction(name);
            }
        }
    }
}
