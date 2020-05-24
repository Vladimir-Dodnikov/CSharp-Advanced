using System;
using System.Linq;

namespace _05._Square_with_Maximum_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrixSize = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();
            var matrix = new int[matrixSize[0], matrixSize[1]];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                var input = Console.ReadLine()
                    .Split(", ")
                    .Select(int.Parse)
                    .ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = input[j];
                }
            }

            int sumMax = int.MinValue;
            int maxSumRow = -1;
            int maxSumCol = -1;

            if (matrix.GetLength(0) >= 2 && matrix.GetLength(1) >= 2)
            {
                for (int i = 0; i < matrix.GetLength(0) - 1; i++)
                {
                    for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                    {
                        int sum =
                            matrix[i + 0, j + 0] + matrix[i + 0, j + 1] +
                            matrix[i + 1, j + 0] + matrix[i + 1, j + 1];

                        if (sum > sumMax)
                        {
                            sumMax = sum;
                            maxSumRow = i;
                            maxSumCol = j;
                        }
                    }
                }
            }
            Console.WriteLine($"{matrix[maxSumRow, maxSumCol]} {matrix[maxSumRow, maxSumCol + 1]}");
            Console.WriteLine($"{matrix[maxSumRow + 1, maxSumCol]} {matrix[maxSumRow + 1, maxSumCol + 1]}");
            Console.WriteLine(sumMax);
        }
    }
}
