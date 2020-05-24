using System;
using System.Collections.Generic;

namespace _06._Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new Queue<string>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }
                else if (input != "Paid")
                {
                    names.Enqueue(input);
                }
                else
                {
                    var counter = names.Count;
                    for (int i = 0; i < counter; i++)
                    {
                        Console.WriteLine(names.Dequeue());
                    }
                }
            }
            Console.WriteLine($"{names.Count} people remaining.");
        }
    }
}
