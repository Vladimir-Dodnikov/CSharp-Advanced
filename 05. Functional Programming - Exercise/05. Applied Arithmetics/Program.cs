using System;
using System.Linq;

namespace _05._Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                Func<int, int> convertFunc = null;
                if (input == "add")
                {
                    convertFunc = i => i + 1;
                }
                else if (input == "subtract")
                {
                    convertFunc = i => i - 1;
                }
                else if (input == "multiply")
                {
                    convertFunc = i => i * 2;
                }

                if (input == "print")
                {
                    Console.WriteLine(string.Join(" ", arr));
                }
                else
                {
                    arr = arr.Select(convertFunc).ToArray();
                }
            }
        }
    }
}
