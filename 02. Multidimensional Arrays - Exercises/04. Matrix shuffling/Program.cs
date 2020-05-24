using System;
using System.Linq;

namespace _04._Matrix_shuffling
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

            string[,] matrix = new string[rows, cols];

            InitializeMatrix(matrix);

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "END")
                {
                    break;
                }
                string[] commandArgs = command.Split(" ");
                string keyWord = commandArgs[0];

                if (keyWord == "swap")
                {
                    if (commandArgs.Length == 5)
                    {
                        long x1 = long.Parse(commandArgs[1]);
                        long y1 = long.Parse(commandArgs[2]);
                        long x2 = long.Parse(commandArgs[3]);
                        long y2 = long.Parse(commandArgs[4]);

                        if (!AreValid(x1, y1, x2, y2, rows, cols))
                        {
                            Console.WriteLine("Invalid input!");
                            continue;
                        }

                        var tempValue = matrix[x1, y1];
                        matrix[x1, y1] = matrix[x2, y2];
                        matrix[x2, y2] = tempValue;

                        PrintMatrix(matrix);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }


            }
        }

        private static void PrintMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }

        private static bool AreValid(long x1, long y1, long x2, long y2, int rows, int cols)
        {
            bool isValid = true;
            if (x1 < 0 || x1 > rows)
            {
                isValid = false;
            }
            if (x2 < 0 || x2 > rows)
            {
                isValid = false;
            }
            if (y1 < 0 || y1 > cols)
            {
                isValid = false;
            }
            if (y2 < 0 || y2 > cols)
            {
                isValid = false;
            }
            return isValid;
        }

        private static void InitializeMatrix(string[,] matrix)
        {
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
               string[] input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[rows, col] = input[col];
                }
            }
        }
    }
}
