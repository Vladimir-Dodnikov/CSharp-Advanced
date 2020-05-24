using System;
using System.Linq;

namespace _02._Sum_Matrix_Columns
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrixSize = Console.ReadLine().Split(", ");
            int row = int.Parse(matrixSize[0]);
            int col = int.Parse(matrixSize[1]);

            int[,] matrix = new int[row, col];
            var colSum = new int[col];
                        //int < matrix.GetLength(0)
            for (int i = 0; i < row; i++)
            {
                var input = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();
                              //j < matrix.GetLength(1)
                for (int j = 0; j < input.Length; j++)
                {
                    matrix[i, j] = input[j];
                    colSum[j] += matrix[i, j];
                }
            }

            foreach (var element in colSum)
            {
                Console.WriteLine(element);
            }
        }
    }
}
