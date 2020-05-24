using System;
using System.Linq;

namespace _09._Miner
{
    class Program
    {
        static char[,] matrix;      //мове да се достъпва където искаме
        static int minerRow;        //за да знаем къде и колко са винаги предварително
        static int minerCol;
        static int coal;
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            string[] direction = Console.ReadLine().Split();

            matrix = new char[size, size];

            PopulateMatrix();

            foreach (var dir in direction)
            {
                switch (dir)
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
            }

            Console.WriteLine($"{coal} coals left. ({minerRow}, {minerCol})");
        }

        private static void Move(int row, int col)
        {
            if (IsInside(minerRow + row, minerCol + col))
            {
                minerRow += row;
                minerCol += col;

                if (matrix[minerRow, minerCol] == 'e')
                {
                    Console.WriteLine($"Game over! ({minerRow}, {minerCol})");
                    Environment.Exit(0);
                    //v OOP ne e pravilen nachin, no zasega e ok, prekusva programata, inache ni vryshata v switch
                }

                if (matrix[minerRow, minerCol] == 'c')
                {
                    coal--;
                    matrix[minerRow, minerCol] = '*';

                    if (coal == 0)
                    {
                        Console.WriteLine($"You collected all coals! ({minerRow}, {minerCol})");
                        Environment.Exit(0);
                    }
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

                    if (matrix[row, col] == 's')
                    {
                        minerRow = row;
                        minerCol = col;
                    }
                    if (matrix[row, col] == 'c')
                    {
                        coal++;
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
