using System;

namespace _04._Symbol_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());
            var matrix = new char[matrixSize, matrixSize];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                var input = Console.ReadLine();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] += input[j];
                }
            }
            char searchedSymbol = char.Parse(Console.ReadLine());

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (searchedSymbol == matrix[i, j])
                    {
                        Console.WriteLine($"({i}, {j})");
                        return;
                    }
                }
            }

            Console.WriteLine($"{searchedSymbol} does not occur in the matrix");
        }
    }
}
