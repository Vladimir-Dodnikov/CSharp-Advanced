using System;
using System.Linq;

namespace _06._Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var jaggedArr = new int[n][];
            for (int i = 0; i < n; i++)
            {
                var numbers = Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();
                for (int j = 0; j < numbers.Length; j++)
                {
                    jaggedArr[i] = numbers;
                }
            }

            while (true)
            {
                var input = Console.ReadLine();
                var parts = input.Split(' ');

                if (input == "END")
                {
                    break;
                }

                int row = int.Parse(parts[1]);
                int col = int.Parse(parts[2]);
                int num = int.Parse(parts[3]);

                if (row < 0 || row > jaggedArr.Length - 1)
                {
                    Console.WriteLine($"Invalid coordinates");
                    continue;
                }

                if (col < 0 || col > jaggedArr.Length - 1)
                {
                    Console.WriteLine($"Invalid coordinates");
                    continue;
                }

                if (input.StartsWith("Add "))
                {
                    jaggedArr[row][col] += num;
                }
                else if (input.StartsWith("Subtract"))
                {
                    jaggedArr[row][col] -= num;
                }
            }

            for (int i = 0; i < jaggedArr.Length; i++)
            {
                for (int j = 0; j < jaggedArr[i].Length; j++)
                {
                    Console.Write(jaggedArr[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
