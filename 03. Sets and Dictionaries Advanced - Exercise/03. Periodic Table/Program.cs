using System;
using System.Collections.Generic;

namespace _03._Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var periodicTable = new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {
                var elements = Console.ReadLine()
                              .Trim()
                              .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var element in elements)
                {
                    periodicTable.Add(element);
                }
            }

            Console.WriteLine(string.Join(" ", periodicTable));
        }
    }
}
