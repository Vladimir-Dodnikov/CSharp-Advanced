using System;
using System.Collections.Generic;

namespace _07._Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = Console.ReadLine().Split(' ');
            var queue = new Queue<string>(people);

            var count = int.Parse(Console.ReadLine());

            while (queue.Count != 1)
            {
                for (int i = 1; i < count; i++)
                {
                    queue.Enqueue(queue.Dequeue());
                }
                Console.WriteLine("Removed " + queue.Dequeue());

            }
            Console.WriteLine("Last is " + queue.Dequeue());
        }
    }
}
