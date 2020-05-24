using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityOfFood = int.Parse(Console.ReadLine());

            int[] orders = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            Queue<int> order = new Queue<int>();

            for (int i = 0; i < orders.Length; i++)
            {
                order.Enqueue(orders[i]);
            }

            Console.WriteLine(order.Max());
            int sumOrder = 0;

            while (order.Count > 0)
            {
                int servedOrder = order.Peek();
                sumOrder += servedOrder;

                if (sumOrder <= quantityOfFood)
                {
                    order.Dequeue();
                }
                else
                {
                    Console.WriteLine("Orders left: " + string.Join(" ", order));
                    return;
                }
            }
            Console.WriteLine("Orders complete");
        }
    }
}
