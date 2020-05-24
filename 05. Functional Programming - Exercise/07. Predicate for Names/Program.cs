using System;
using System.Linq;

namespace _07._Predicate_for_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxLength = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split();

            Func<string[], string[]> removeWithGreaterLength = arr => arr.Where(s => s.Length <= maxLength).ToArray();

            Action<string[]> printAction = arr =>
            {
                foreach (var s in arr)
                {
                    Console.WriteLine(s);
                }
            };

            printAction(removeWithGreaterLength(names));
        }
    }
}
