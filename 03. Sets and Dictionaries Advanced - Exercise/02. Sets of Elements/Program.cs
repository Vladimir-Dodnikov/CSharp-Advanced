using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] setsLength = Console.ReadLine().Trim()
                              .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                              .Select(int.Parse)
                              .ToArray();

            var setN = new HashSet<int>();
            var setM = new HashSet<int>();

            for (int i = 0; i < setsLength[0]; i++)
            {
                setN.Add(int.Parse(Console.ReadLine().Trim()));
            }

            for (int i = 0; i < setsLength[1]; i++)
            {
                setM.Add(int.Parse(Console.ReadLine().Trim()));
            }

            setN.IntersectWith(setM);

            Console.WriteLine(string.Join(" ", setN));
        }
    }
}
