
using System;
using System.Linq;

namespace BookWorm
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var size = int.Parse(Console.ReadLine());

            char[,] matrix = new char[size, size];

            int playerRow = 0;
            int playerCol = 0;

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                char[] chars = Console.ReadLine().ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    char ch = chars[col];
                    if (ch == 'P')
                    {
                        playerRow = rows;
                        playerCol = col;
                    }
                    matrix[rows, col] = chars[col];
                }
            }
            matrix[playerRow, playerCol] = '-';
            string command = Console.ReadLine();

            while (true)
            {
                if (command == "end")
                {
                    matrix[playerRow, playerCol] = 'P';
                    break;
                }

                switch (command)
                {
                    case "up":
                        if (playerRow - 1 < 0)
                        {
                            input = GetSubstring(input);
                        }
                        else
                        {
                            playerRow -= 1;
                        }
                        break;
                    case "down":
                        if (playerRow + 1 > size)
                        {
                            input = GetSubstring(input);
                        }
                        else
                        {
                            playerRow += 1;
                        }
                        break;
                    case "left":
                        if (playerCol - 1 < 0)
                        {
                            input = GetSubstring(input);
                        }
                        else
                        {
                            playerCol -= 1;
                        }
                        break;
                    case "right":
                        if (playerCol + 1 > size)
                        {
                            input = GetSubstring(input);
                        }
                        else
                        {
                            playerCol += 1;
                        }
                        break;
                    default:
                        break;
                }

                if (char.IsLetter(matrix[playerRow, playerCol]))
                {
                    input += matrix[playerRow, playerCol];
                    matrix[playerRow, playerCol] = '-';
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(input);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }

        private static string GetSubstring(string input)
        {
            if (input.Length > 0)
            {
                input = input.Substring(0, input.Length - 1);
            }

            return input;
        }
    }
}
