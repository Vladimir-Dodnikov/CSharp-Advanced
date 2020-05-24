using System;
using System.Collections.Generic;

namespace _08._Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            int troughput = int.Parse(Console.ReadLine());
            var queue = new Queue<string>();
            int count = 0;

            while (true)
            {
                var command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }
                else if (command == "green")
                {
                    for (int i = 0; i < troughput; i++)
                    {
                        if (queue.Count > 0)
                        {
                            var car = queue.Dequeue();
                            Console.WriteLine($"{car} passed!");
                            count++;
                        }
                    }
                }
                else
                {
                    queue.Enqueue(command);
                }
            }
            Console.WriteLine($"{count} cars passed the crossroads.");
        }
    }
}
