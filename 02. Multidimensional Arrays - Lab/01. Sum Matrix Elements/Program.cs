using System;
using System.Linq;

namespace _01._Sum_Matrix_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrixSize = Console.ReadLine().Split(", ");
            int row = int.Parse(matrixSize[0]);
            int col = int.Parse(matrixSize[1]);

            int[,] matrix = new int[row, col];
                            //int < matrix.GetLength(0)
            for (int i = 0; i < row; i++)
            {
                var input = Console.ReadLine()
                    .Split(", ")
                    .Select(int.Parse)
                    .ToArray();
                                //j < matrix.GetLength(1)
                for (int j = 0; j < input.Length; j++)
                {
                    matrix[i, j] = input[j];
                }
            }

            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));
            Console.WriteLine(matrix.Cast<int>().Sum());

            //long sum = 0;
            //foreach (var num in matrix)
            //{
            //    sum += num;
            //}
            //Console.WriteLine(sum);
        }
    }
}
