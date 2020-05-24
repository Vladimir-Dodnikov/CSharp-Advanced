using System;
using System.Linq;

namespace _03._Primary_Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());
            var matrix = new int[matrixSize,matrixSize];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                var inputRow = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = inputRow[j];
                }
            }

            int sum = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                    sum += matrix[row, row];
            }

            Console.WriteLine(sum);
        }
    }
}
