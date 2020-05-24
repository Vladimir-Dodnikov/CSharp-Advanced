using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] received = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            Stack<int> clothes = new Stack<int>(received);

            int capacityOfRack = int.Parse(Console.ReadLine());
            int racks = 0;
            int sumOfClothes = 0;

            while (clothes.Count > 0)
            {
                int clothe = clothes.Peek();
                sumOfClothes += clothe;

                if (sumOfClothes < capacityOfRack)
                {
                    clothes.Pop();
                    if (clothes.Count == 0)
                    {
                        racks++;
                    }
                }
                else if (sumOfClothes == capacityOfRack)
                {
                    if (clothes.Count > 0)
                    {
                        clothes.Pop();
                        racks++;
                        sumOfClothes = 0;
                    }
                }
                else if (sumOfClothes > capacityOfRack)
                {
                    racks++;
                    sumOfClothes = 0;
                }
            }
            Console.WriteLine(racks);
        }
    }
}
