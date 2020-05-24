using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericSwapMethodStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var boxes = new List<Box<string>>();

            for (int i = 0; i < n; i++)
            {
                var box = new Box<string>(Console.ReadLine());
                boxes.Add(box);
            }

            int[] toSwap = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            SwapBoxes(boxes, toSwap[0], toSwap[1]);

            boxes.ForEach(Console.WriteLine);
        }
        public static void SwapBoxes<T>(List<Box<T>> box, int firstIndex, int secondIndex)
        {
            var temp = box[firstIndex];
            box[firstIndex] = box[secondIndex];
            box[secondIndex] = temp;
        }
    }
}
