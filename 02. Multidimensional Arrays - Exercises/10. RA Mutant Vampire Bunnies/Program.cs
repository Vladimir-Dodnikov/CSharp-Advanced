using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._RA_Mutant_Vampire_Bunnies
{
    class Program
    {
        static char[,] matrix;
        static int playerRow;
        static int playerCol;
        static bool IsDead;
        static void Main(string[] args)
        {
            IsDead = false;
            int[] dimension = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int totalRows = dimension[0];
            int totalCols = dimension[1];

            matrix = new char[totalRows, totalCols];

            PopulateMatrix();

            string direciton = Console.ReadLine();
            foreach (var dir in direciton)
            {
                switch (dir)
                {
                    case 'U':
                        Move(-1, 0);
                        break;
                    case 'D':
                        Move(1, 0);
                        break;
                    case 'L':
                        Move(0, -1);
                        break;
                    case 'R':
                        Move(0, 1);
                        break;
                }

                Spread();

                if (IsDead)
                {
                    Print();
                    Console.WriteLine($"dead: {playerRow} {playerCol}");

                    Environment.Exit(0);
                }
            }
        }

        private static void Spread()
        {
            List<int> indexes = new List<int>();
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 'B')
                    {
                        indexes.Add(row);
                        indexes.Add(col);
                    }
                }
            }

            for (int i = 0; i < indexes.Count; i += 2)
            {
                int currentBunnyRow = indexes[i];
                int currentBunnyCol = indexes[i + 1];
                //Right
                if (IsInside(currentBunnyRow, currentBunnyCol + 1))
                {
                    if (matrix[currentBunnyRow, currentBunnyCol + 1] == 'P')
                    {
                        IsDead = true;
                    }
                    matrix[currentBunnyRow, currentBunnyCol + 1] = 'B';
                }
                //Left
                if (IsInside(currentBunnyRow, currentBunnyCol - 1))
                {
                    if (matrix[currentBunnyRow, currentBunnyCol - 1] == 'P')
                    {
                        IsDead = true;
                    }
                    matrix[currentBunnyRow, currentBunnyCol - 1] = 'B';
                }
                //Up
                if (IsInside(currentBunnyRow - 1, currentBunnyCol))
                {
                    if (matrix[currentBunnyRow - 1, currentBunnyCol] == 'P')
                    {
                        IsDead = true;
                    }
                    matrix[currentBunnyRow - 1, currentBunnyCol] = 'B';
                }
                //Down
                if (IsInside(currentBunnyRow + 1, currentBunnyCol))
                {
                    if (matrix[currentBunnyRow + 1, currentBunnyCol] == 'P')
                    {
                        IsDead = true;
                    }
                    matrix[currentBunnyRow + 1, currentBunnyCol] = 'B';
                }
            }
        }

        private static void Move(int row, int col)
        {
            if (!IsInside(playerRow + row, playerCol + col))
            {
                matrix[playerRow, playerCol] = '.';
                Spread();
                Print();
                Console.WriteLine($"won: {playerRow} {playerCol}");

                Environment.Exit(0);
            }


            if (matrix[playerRow + row, playerCol + col] == 'B')
            {
                Spread();
                Print();
                Console.WriteLine($"dead: {playerRow + row} {playerCol + col}");

                Environment.Exit(0);
            }

            matrix[playerRow, playerCol] = '.';

            playerRow += row;
            playerCol += col;

            matrix[playerRow, playerCol] = 'P';
        }

        private static void Print()
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }

        private static void PopulateMatrix()
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] chars = Console.ReadLine().ToCharArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = chars[col];

                    if (matrix[row, col] == 'P')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }
        }

        private static bool IsInside(int row, int col)
        {
            return row >= 0 && row < matrix.GetLength(0) &&
                   col >= 0 && col < matrix.GetLength(1);
        }
    }
}
