using System;
using System.Linq;

namespace _02._2x2_Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = matrixSize[0];
            int cols = matrixSize[1];

            char[,] matrix = new char[rows, cols];

            InitializeMatrix(matrix);

            int counter = 0;

            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    bool isEqual = matrix[i, j] == matrix[i, j + 1] &&
                                   matrix[i + 1, j] == matrix[i + 1, j + 1] &&
                                   matrix[i + 1, j] == matrix[i, j];

                    if (isEqual)
                    {
                        counter++;
                    }
                }
            }

            Console.WriteLine(counter);
        }

        private static void InitializeMatrix(char[,] matrix)
        {
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                char[] chars = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[rows, col] = chars[col];
                }
            }

        }
    }
}
