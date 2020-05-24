using System;
using System.Linq;

namespace PresentDelivery
{
    class Program
    {
        static char[,] matrix;
        static int santaRow;
        static int santaCol;
        static int naughtyKids;
        static int goodKids;
        static int cookies;
        static int countOfPresents;
        static void Main()
        {

            countOfPresents = int.Parse(Console.ReadLine());

            int matrixSize = int.Parse(Console.ReadLine());

            matrix = new char[matrixSize, matrixSize];

            PopulateMatrix();

            string direction = Console.ReadLine();
            while (direction != "Christmas morning" || countOfPresents > 0)
            {
                if (direction == "Christmas morning")
                {
                    break;
                }
                switch (direction)
                {
                    case "up":
                        Move(-1, 0);
                        break;
                    case "down":
                        Move(1, 0);
                        break;
                    case "left":
                        Move(0, -1);
                        break;
                    case "right":
                        Move(0, 1);
                        break;
                    default:
                        break;
                }

                direction = Console.ReadLine();
            }

            Print();
            if (countOfPresents == 0)
            {
                Console.WriteLine($"Good job, Santa! {goodKids} happy nice kid/s.");
            }
            else
            {
                Console.WriteLine($"No presents for {goodKids} nice kid/s.");
            }
        }

        private static void Move(int row, int col)
        {
            if (IsInside(santaRow + row, santaCol + col))
            {
                santaRow += row;
                santaCol += col;

                if (matrix[santaRow, santaCol] == 'X')
                {
                    matrix[santaRow, santaCol] = '-';
                    naughtyKids++;
                }

                if (matrix[santaRow, santaCol] == 'V')
                {
                    if (countOfPresents > 0)
                    {
                        countOfPresents--;
                        goodKids++;
                        matrix[santaRow, santaCol] = '-';
                    }
                }

                if (matrix[santaRow, santaCol] == 'C')
                {
                    cookies++;
                    matrix[santaRow, santaCol] = '-';

                    int rowToGive = santaRow;
                    int colToGive = santaCol;

                    if (countOfPresents > 0)
                    {
                        Spread(rowToGive, colToGive);
                    }
                }
                santaRow += row;
                santaCol += col;
            }
            else
            {
                Console.WriteLine("Santa ran out of presents.");
            }
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

        private static void Spread(int rowToGive, int colToGive)
        {
            //Right
            if (IsInside(rowToGive, colToGive + 1))
            {
                if (matrix[rowToGive, colToGive + 1] == 'X')
                {
                    naughtyKids++;
                    countOfPresents--;
                }
                else if (matrix[rowToGive, colToGive + 1] == 'V')
                {
                    goodKids++;
                    countOfPresents--;
                }
            }
            //Left
            if (IsInside(rowToGive, colToGive - 1))
            {
                if (matrix[rowToGive, colToGive - 1] == 'X')
                {
                    naughtyKids++;
                    countOfPresents--;
                }
                else if (matrix[rowToGive, colToGive - 1] == 'V')
                {
                    goodKids++;
                    countOfPresents--;
                }
            }
            //Up
            if (IsInside(rowToGive - 1, colToGive))
            {
                if (matrix[rowToGive - 1, colToGive] == 'X')
                {
                    naughtyKids++;
                    countOfPresents--;
                }
                else if (matrix[rowToGive - 1, colToGive] == 'V')
                {
                    goodKids++;
                    countOfPresents--;
                }
            }
            //Down
            if (IsInside(rowToGive + 1, colToGive))
            {
                if (matrix[rowToGive + 1, colToGive] == 'X')
                {
                    naughtyKids++;
                    countOfPresents--;
                }
                else if (matrix[rowToGive + 1, colToGive] == 'V')
                {
                    goodKids++;
                    countOfPresents--;
                }
            }
        }

        private static void PopulateMatrix()
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] input = Console.ReadLine()
                    .Split()
                    .Select(char.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];

                    if (matrix[row, col] == 'S')
                    {
                        santaRow = row;
                        santaCol = col;
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
